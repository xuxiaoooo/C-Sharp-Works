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
    public partial class 图书借阅 : Form
    {
        public 图书借阅()
        {
            InitializeComponent();
            label3.Text = "当前时间： " + DateTime.Now.ToString();
            label9.Text = "操作员： " + DBHelper.a;
        }
        void chaxun1()
        {
            string sql = string.Format(@"select * from [dbo].[reader] where [code]='{0}';", textBox1.Text);
            DBHelper dbHelper = new DBHelper();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                dbHelper.OpenConnection();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox3.Text = dr["name"].ToString();
                    textBox5.Text = dr["guarantee-deposit"].ToString();
                }
                else
                {
                    MessageBox.Show("查询失败，请重试！");
                }
                dbHelper.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误，请联系管理员,错误原因是：" + ex.Message);
            }
        }
        void chaxun2()
        {
            string sql = string.Format(@"select * from [dbo].[book] where [bno]='{0}';", textBox2.Text);
            DBHelper dbHelper = new DBHelper();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                dbHelper.OpenConnection();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox6.Text = dr["bookname"].ToString();
                    textBox7.Text = dr["kno"].ToString();
                    textBox8.Text = dr["price"].ToString();
                }
                else
                {
                    MessageBox.Show("查询失败，请重试！");
                }
                dbHelper.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误，请联系管理员,错误原因是：" + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chaxun1();
            chaxun2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("填写不完整");
            }
            else
            {
                string sql = string.Format(@"insert into [dbo].[borrowinfo] ([readerno],[operatorno],[bookno],[borrowtime],[isreturned]) values('{0}','{1}','{2}','{3}','0');", textBox1.Text, Convert.ToInt32(DBHelper.a), Convert.ToInt32(textBox2.Text), DateTime.Now);
                DBHelper dbHelper = new DBHelper();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                    dbHelper.OpenConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("借阅成功");
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
