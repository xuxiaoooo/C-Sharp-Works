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
    public partial class WithDraw : Form
    {
        public WithDraw()
        {
            InitializeComponent();
        }

        static String connetStr = "server=49.232.138.196;port=3306;user=parkingsystem;password=jHE6nzhrZm6fXHPw; database=parkingsystem;Allow User Variables=True";
        MySqlConnection conn = new MySqlConnection(connetStr);

        private void WithDraw_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "select * from vip order by cardnumber";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("cardnumber"));
                }

                reader.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("请填写完整!");
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql = "select * from vip where cardnumber = @para1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("para1", comboBox1.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    string carnumber = reader.GetString("carnumber");
                    string name = reader.GetString("name");
                    string phone = reader.GetString("phone");

                    reader.Close();

                    if (textBox2.Text == carnumber || textBox3.Text == name || textBox5.Text == phone)
                    {
                        sql = "delete from vip where cardnumber = @para1";
                        MySqlCommand cmd2 = new MySqlCommand(sql, conn);

                        cmd2.Parameters.AddWithValue("para1", comboBox1.Text);
                        int result = cmd2.ExecuteNonQuery();

                        if (result == 1)
                        {
                            MessageBox.Show("注销成功!");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("信息错误!请重新填写!");
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
