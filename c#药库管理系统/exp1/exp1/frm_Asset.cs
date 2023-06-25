using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exp1
{
    public partial class frm_Asset : Form
    {
        public frm_Asset()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
            con.Open();
            string str = string.Format("SELECT * FROM dbo.tb_InputOrder;");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(ds, "tb_InputOrder");
            this.dgv_input.DataSource = ds.Tables["tb_InputOrder"];
            con.Close();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
            con.Open();
            string str = string.Format("select sum(tb_InputOrder.Amounts*tb_InputOrder.MedicinePrice) as sum1 from tb_InputOrder;");
            SqlCommand comm = new SqlCommand(str, con);
            SqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            string s= dr["sum1"].ToString();
            lb_money.Text ="总金额为：" +s+"元";
        }
    }
}
