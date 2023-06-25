using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace exp1
{
    public partial class frm_ManagePlan : Form
    {
        private string Uname;
        SqlConnection sqlConnection = new SqlConnection();
        public frm_ManagePlan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frm_ManagePlan(string uname) : this()
        {
            this.AcceptButton = btn_Query;
            this.Uname = uname;
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT M.No AS 药品编号,M.Name AS 药品名称,M.Quantity AS 库存数量,M.StockPotency AS 库存基数,M.StockTopLimit AS 库存上限,m.StockLowerLimit AS 库存下限
                                        FROM dbo.tb_Medicines AS M
                                        WHERE M.Quantity<M.StockPotency";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable MedicineTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(MedicineTable);
            sqlConnection.Close();
            dgv_StockPotency.DataSource = MedicineTable;
        }

       


     

        private void btn_QueryLower_Click_1(object sender, EventArgs e)
        {
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT M.No AS 药品编号,M.Name AS 药品名称,M.Quantity AS 库存数量,m.StockLowerLimit AS 库存下限,M.StockPotency AS 库存基数,M.StockTopLimit AS 库存上限
                                        FROM dbo.tb_Medicines AS M
                                        WHERE M.Quantity<M.StockLowerLimit";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable LowerTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(LowerTable);
            sqlConnection.Close();
            dgv_StockLowerLimit.DataSource = LowerTable;
        }

        private void btn_QueryTopLimit_Click_1(object sender, EventArgs e)
        {
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT M.No AS 药品编号,M.Name AS 药品名称,M.Quantity AS 库存数量,M.StockTopLimit AS 库存上限,m.StockLowerLimit AS 库存下限,M.StockPotency AS 库存基数
                                        FROM dbo.tb_Medicines AS M
                                        WHERE M.Quantity>M.StockTopLimit";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable TopMedicineTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(TopMedicineTable);
            sqlConnection.Close();
            dgv_StockTopLimit.DataSource = TopMedicineTable;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT M.No AS 药品编号,M.Name AS 药品名称,MM.ProductionDate AS 生产日期,MM.PeriodOfVAlidityMonth AS 有效期
                                            FROM dbo.tb_Medicines AS M
                                            JOIN dbo.tb_MedicineOrder AS MM ON MM.MedicineNo = M.No
                                            WHERE MM.PeriodOfVAlidityMonth<@PeriodOfValidity";
            sqlCommand.Parameters.AddWithValue("@PeriodOfValidity", dtp_PeriodOfValidity.Value);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable PeriodTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(PeriodTable);
            sqlConnection.Close();
            dgv_PeriodOfValidity.DataSource = PeriodTable;
        }

        private void btn_RetentionQuery_Click(object sender, EventArgs e)
        {
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT MM.No AS 入库编号,M.Name AS 药品名称,MM.ProductionDate AS 生产日期,MM.PeriodOfVAlidityMonth AS 有效期,MM.Remainder AS 滞留数量,MM.PartialQuantity AS 原始数量,mm.TakeOutDate AS 出库时间
                                        FROM dbo.tb_Medicines AS M
                                        JOIN dbo.tb_MedicineOrder AS MM ON MM.MedicineNo = M.No
                                        WHERE MM.Remainder>0 
                                        ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable RemainderTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(RemainderTable);
            sqlConnection.Close();
            dgv_MedicineRetention.DataSource = RemainderTable;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
