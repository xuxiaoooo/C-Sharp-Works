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
    public partial class 读者信息添加 : Form
    {
        public 读者信息添加()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""|| textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("填写不完整");
            }
            if ((radioButton1.Checked && radioButton2.Checked) || (!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("性别选择错误");
            }
            else
            {
                Random ran = new Random();
                string id = DBHelper.a + DateTime.Now.ToString("yyyyMMddHH") + ran.Next(99);
                string sex="";
                if (radioButton1.Checked && !radioButton2.Checked)
                    sex = "男";
                else if (!radioButton1.Checked && radioButton2.Checked)
                    sex = "女";
                string sql = string.Format(@"insert into [dbo].[reader] ([name],[sex],[age],[phone],[guarantee-deposit],[birthday],[job],[IDnumber],[dateofregistration],[IDkind],[code]) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}');", textBox1.Text, sex,Convert.ToInt32(textBox2.Text),textBox3.Text,textBox4.Text,dateTimePicker1.Value,textBox5.Text,textBox6.Text,DateTime.Now,textBox7.Text,id);
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
