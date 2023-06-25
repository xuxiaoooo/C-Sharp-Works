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
    public partial class frm_Password : Form
    {
        public frm_Password()
        {
            InitializeComponent();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            if (txb_new.Text != txb_check.Text)
            {
                MessageBox.Show("两次新密码输入不同！");
            }
            else
            {
                if (txb_old.Text != global.b)
                {
                    MessageBox.Show("原密码错误！");
                }
                else
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
                    con.Open();
                    string str = string.Format("UPDATE dbo.tb_User SET Password =HASHBYTES('MD5','{0}') where Account='{1}';", txb_new.Text,global.a);
                    SqlCommand comm = new SqlCommand(str, con);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("修改密码成功！");
                }
            }
        }
    }
}
