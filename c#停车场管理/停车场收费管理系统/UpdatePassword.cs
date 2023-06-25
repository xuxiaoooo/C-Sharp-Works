using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 停车场收费管理系统
{
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static String connetStr = "server=49.232.138.196;port=3306;user=parkingsystem;password=jHE6nzhrZm6fXHPw; database=parkingsystem;Allow User Variables=True";
        MySqlConnection conn = new MySqlConnection(connetStr);

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("请填写完整!");
            }
            else if(textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("两次密码输入不一致!");
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                bool flag = false;
                try
                {
                    conn.Open();

                    string sql = "select * from user where password = @para1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("para1", textBox1.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        flag = true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                if (flag)
                {
                    try
                    {
                        conn.Open();

                        string sql = "update user set password = @para1 where password = @para2";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("para1", textBox2.Text);
                        cmd.Parameters.AddWithValue("para2", textBox1.Text);

                        int reader = cmd.ExecuteNonQuery();

                        if (reader == 1)
                        {
                            MessageBox.Show("修改成功!");
                            this.Close();
                        }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("原密码错误!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
        }
    }
}
