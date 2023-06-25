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
    public partial class frm_selectall : Form
    {
        public frm_selectall()
        {
            InitializeComponent();
            dgv_fun1.Visible = false;
            dgv_fun2.Visible = false;
            if (global.i == 1)
            {
                dgv_fun1.Visible = true;
                fun1();
            }
            else if (global.i == 2)
            {
                dgv_fun2.Visible = true;
                fun2();
            }
        }
        void fun1()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
            con.Open();
            string str = string.Format("SELECT * FROM dbo.tb_InputOrder;");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(ds, "tb_InputOrder");
            this.dgv_fun1.DataSource = ds.Tables["tb_InputOrder"];
            con.Close();
        }
        void fun2()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
            con.Open();
            string str = string.Format("SELECT * FROM dbo.tb_OutputOrder;");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(ds, "tb_OutputOrder");
            this.dgv_fun2.DataSource = ds.Tables["tb_OutputOrder"];
            con.Close();
        }
    }
}
