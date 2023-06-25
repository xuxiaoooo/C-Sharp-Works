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
    public partial class 验收新书 : Form
    {
        public 验收新书()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"update [dbo].[order] set [ischecked]='1' where [no]='{0}';", Convert.ToInt32(textBox1.Text));
            DBHelper dbHelper = new DBHelper();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                dbHelper.OpenConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("验收成功");
                dbHelper.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
