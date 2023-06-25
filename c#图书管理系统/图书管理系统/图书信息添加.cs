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
    public partial class 图书信息添加 : Form
    {
        public 图书信息添加()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("填写不完整");
            }
            else
            {
                string sql = string.Format(@"insert into [dbo].[book] ([kno],[bookname],[author],[price],[publishtime],[press],[translator]) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text,Convert.ToDecimal( textBox4.Text),dateTimePicker1.Value,textBox5.Text,textBox6.Text);
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
