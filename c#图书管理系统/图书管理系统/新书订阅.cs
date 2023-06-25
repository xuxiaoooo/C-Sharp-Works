using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class 新书订阅 : Form
    {
        public 新书订阅()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )
            {
                MessageBox.Show("填写不完整");
            }
            else
            {
                string sql = string.Format(@"insert into [dbo].[order] ([orderdate],[bno],[num],[operator],[ischecked],[discount]) values('{0}','{1}','{2}','{3}','0','{4}');", DateTime.Now,Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),textBox3.Text,textBox4.Text);
                DBHelper dbHelper = new DBHelper();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                    dbHelper.OpenConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("新增成功");
                    dbHelper.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
