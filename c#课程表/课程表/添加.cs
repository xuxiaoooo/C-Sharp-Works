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
    public partial class 添加 : Form
    {
        public 添加()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("未填写");
            }
            else
            {
                string sql = string.Format(@"insert into [dbo].[schedule] ([weekday],[classtime],[name]) values ('{0}','{1}','{2}');",DBHelper.a.ToString(),DBHelper.b.ToString(),textBox1.Text);
                DBHelper dbHelper = new DBHelper();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                    dbHelper.OpenConnection();
                    cmd.ExecuteNonQuery();
                    if (DialogResult.Yes == MessageBox.Show("插入成功", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
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
