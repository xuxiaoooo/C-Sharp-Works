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
    public partial class 用户添加 : Form
    {
        public 用户添加()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("填写不完整");
            }
            else
            {
                string sex = "";
                if (comboBox1.SelectedIndex == 0) sex = "男";
                else if (comboBox1.SelectedIndex == 1) sex = "女";
                string admin = "";
                if (comboBox1.SelectedIndex == 0) admin = "1";
                else if (comboBox1.SelectedIndex == 1) admin = "0";
                string sql = string.Format(@"insert into [dbo].[operator] ([name],[sex],[age],[phone],[idcard],[isadmin],[workdate],[code]) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');", textBox2.Text, sex, Convert.ToInt32(textBox3.Text),textBox4.Text,textBox5.Text,admin,dateTimePicker1.Value,textBox6.Text);
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
