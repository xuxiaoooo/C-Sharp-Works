using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Course_Design
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string identity = "", sql = "", sql_count = "";

            if (radioButton1.Checked)
            {
                identity = radioButton1.Text;
            }
            else
            {
                identity = radioButton2.Text;
             }


                SqlConnection conn = new SqlConnection(@data.s);
                conn.Open();

                sql = "Select * from {0} where 账号='{1}' and 密码='{2}'";
                sql = string.Format(sql, identity + "信息", textBox1.Text, textBox2.Text);
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader result = cmd.ExecuteReader();

                if (!result.HasRows)
                {
                    MessageBox.Show("用户名或密码错误!");
                }
                else if (radioButton1.Checked && result.HasRows)
                {
                    result.Read();
                    string index = (string)result[0];
                    string name = (string)result[1];
                    string department = (string)result[3];
                    staff staff1 = new staff(index, name, department);
                    staff1.Show();

                }
                else if (radioButton2.Checked && result.HasRows)
                {
                    result.Read();
                    string index = (string)result[0];
                    string name = (string)result[1];
                    string department = (string)result[2];
                    manage manage1 = new manage(index, name, department);
                    manage1.Show();
                }
            }

        private void button2_Click_1(object sender, EventArgs e)
        {
                MessageBox.Show("你已退出系统!");
                this.Close();
        }

        }
    }

