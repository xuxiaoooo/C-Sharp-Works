using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课程表
{
    public partial class 更新 : Form
    {
        public 更新()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("未填写");
            }
            else
            {
                string sql = string.Format(@"update [dbo].[schedule] set [name] ='{0}' where [weekday]='{1}' and [classtime]='{2}';", textBox1.Text,DBHelper.a.ToString(), DBHelper.b.ToString() );
                DBHelper dbHelper = new DBHelper();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                    dbHelper.OpenConnection();
                    cmd.ExecuteNonQuery();
                    if (DialogResult.Yes == MessageBox.Show("更新成功", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                    {
                        this.Close();
                    }
                    dbHelper.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Form1.frm1.labeltext();
                Form1.frm1.searchall();
            }
        }
    }
}
