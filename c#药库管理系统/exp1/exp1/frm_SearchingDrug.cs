using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace exp1
{
    public partial class frm_SearchingDrug : Form
    {
        private DataTable MedicineTable;

        private DataTable MedicineTypeTable;

        private DataView MedicineViewByName;
        public frm_SearchingDrug()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = this.btn_SearchMedicine;
            rdb_No.Checked = true;
        }

        private void dgv_SearchMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_QueryAll_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT M.No,M.Name,M.Price,M.Quantity,M.VarietyNo,M.PinYin
                                        FROM dbo.tb_Medicines AS M";
            sqlCommand1.CommandText = $@"SELECT *
                                        FROM dbo.tb_VarietiesOfMedicine";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter1.SelectCommand = sqlCommand1;
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            this.MedicineTable = new DataTable("MedicineTable");
            this.MedicineTypeTable = new DataTable("MedicineTypeTable");
            sqlConnection.Open();
            sqlDataAdapter.Fill(this.MedicineTable);
            sqlDataAdapter1.Fill(this.MedicineTypeTable);
            sqlConnection.Close();
            this.MedicineViewByName = new DataView();
            this.MedicineViewByName.Table = this.MedicineTable;
            this.MedicineViewByName.Sort = "Name ASC";
            dgv_SearchMedicine.Columns.Clear();

            dgv_SearchMedicine.DataSource = MedicineTable;
            this.dgv_SearchMedicine.Columns["No"].HeaderText = "药品编号";
            this.dgv_SearchMedicine.Columns["Name"].HeaderText = "药品名称";
            this.dgv_SearchMedicine.Columns["Price"].HeaderText = "药品价格";
            this.dgv_SearchMedicine.Columns["Quantity"].HeaderText = "剩余数量";
            this.dgv_SearchMedicine.Columns["VarietyNo"].Visible = false;
            this.dgv_SearchMedicine.Columns["PinYin"].Visible = false;
            DataGridViewComboBoxColumn Type = new DataGridViewComboBoxColumn();
            this.dgv_SearchMedicine.Columns.Add(Type);
            Type.HeaderText = "药品类型";
            Type.DisplayIndex = 2;
            Type.DataSource = MedicineTypeTable;
            Type.DisplayMember = "VName";
            Type.ValueMember = "No";
            Type.DataPropertyName = "VarietyNo";
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_SearchMedicine.Columns[this.dgv_SearchMedicine.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_SearchMedicine_Click(object sender, EventArgs e)
        {

            if (rdb_No.Checked == true)
            {
                DataRow searchResultRow = MedicineTable.Rows.Find(Convert.ToInt32(this.txb_SearchIng.Text.Trim()));
                DataTable SearchResultTable = this.MedicineTable.Clone();
                SearchResultTable.ImportRow(searchResultRow);
                this.dgv_SearchMedicine.DataSource = SearchResultTable;
            }
            else if (rdb_Name.Checked == true)
            {
                DataRowView[] searchResultRowViews = this.MedicineViewByName.FindRows(this.txb_SearchIng.Text.Trim());
                DataTable searchResultTable = this.MedicineTable.Clone();
                foreach (DataRowView dataRowView in searchResultRowViews)
                {
                    searchResultTable.ImportRow(dataRowView.Row);
                }
                this.dgv_SearchMedicine.DataSource = searchResultTable;
            }

        }

        private void txb_SearchIng_TextChanged(object sender, EventArgs e)
        {

            if (rdb_Pinyin.Checked == true)
            {
                DataRow[] searchResultRows = this.MedicineTable.Select($"PinYin LIKE '%{txb_SearchIng.Text.Trim()}%'");
                DataTable searchResultTable = this.MedicineTable.Clone();
                foreach (DataRow row in searchResultRows)
                {
                    searchResultTable.ImportRow(row);
                }
                this.dgv_SearchMedicine.DataSource = searchResultTable;
            }
        }
    }
}
