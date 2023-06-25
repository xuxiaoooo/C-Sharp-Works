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
    public partial class 读者信息修改与删除 : Form
    {
        public 读者信息修改与删除()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string sql = string.Format(@"select * from [dbo].[reader] where [code]='{0}';",textBox0.Text);
            DBHelper dbHelper = new DBHelper();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                dbHelper.OpenConnection();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    panel1.Visible = true;
                    textBox1.Text = dr["name"].ToString();
                    textBox2.Text = dr["age"].ToString();
                    textBox3.Text = dr["phone"].ToString();
                    textBox4.Text = dr["guarantee-deposit"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dr["birthday"]);
                    textBox5.Text = dr["job"].ToString();
                    textBox6.Text = dr["IDnumber"].ToString();
                    dateTimePicker2.Value= Convert.ToDateTime(dr["dateofregistration"]);
                    textBox7.Text = dr["IDkind"].ToString();
                    string sex=dr["sex"].ToString();
                    if (sex == "男")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("填写不完整");
            }
            if ((radioButton1.Checked && radioButton2.Checked) || (!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("性别选择错误");
            }
            else
            {
                string sex = "";
                if (radioButton1.Checked && !radioButton2.Checked)
                    sex = "男";
                else if (!radioButton1.Checked && radioButton2.Checked)
                    sex = "女";
                string sql = string.Format(@"update [dbo].[reader] set [name]='{0}',[sex]='{1}',[age]='{2}',[phone]='{3}',[guarantee-deposit]='{4}',[birthday]='{5}',[job]='{6}',[IDnumber]='{7}',[dateofregistration]='{8}',[IDkind]='{9}';", textBox1.Text, sex, Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text, dateTimePicker1.Value, textBox5.Text, textBox6.Text, dateTimePicker2.Value, textBox7.Text);
                DBHelper dbHelper = new DBHelper();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                    dbHelper.OpenConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("更新成功");
                    dbHelper.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"delete from [dbo].[reader] where [code]='{0}';", textBox0.Text);
            DBHelper dbHelper = new DBHelper();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                dbHelper.OpenConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功");
                dbHelper.CloseConnection();
                panel1.Visible = false;
                textBox0.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
