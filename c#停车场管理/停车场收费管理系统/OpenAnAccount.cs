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
    public partial class OpenAnAccount : Form
    {
        public OpenAnAccount()
        {
            InitializeComponent();
        }

        static String connetStr = "server=49.232.138.196;port=3306;user=parkingsystem;password=jHE6nzhrZm6fXHPw; database=parkingsystem;";
        MySqlConnection conn = new MySqlConnection(connetStr);

        private void OpenAnAccount_Load(object sender, EventArgs e)
        {
            for (int i = 8886001; i <= 8886100; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private bool check()
        {
            bool result = false;

            string sql = "select * from vip where cardnumber = @para1";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("para1", comboBox1.Text);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                result = true;
            }

            reader.Close();

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("请选择");
                }
                else
                {
                    if (check())
                    {
                        MessageBox.Show("此卡号已注册!请重新选择!");
                    }
                    else
                    {
                        string sql = "insert into vip values(@para1 ,@para2,@para3,@para4,@para5,@para6)";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("para1", comboBox1.Text);
                        cmd.Parameters.AddWithValue("para2", textBox2.Text);
                        cmd.Parameters.AddWithValue("para3", textBox3.Text);
                        cmd.Parameters.AddWithValue("para4", textBox5.Text);
                        cmd.Parameters.AddWithValue("para5", Convert.ToSingle(textBox4.Text));
                        cmd.Parameters.AddWithValue("para6", DateTime.Parse(DateTime.Now.ToString()));

                        int result = cmd.ExecuteNonQuery();

                        if (result == 1)
                        {
                            MessageBox.Show("开户成功!");
                            this.Close();
                        }
                    }

    
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
