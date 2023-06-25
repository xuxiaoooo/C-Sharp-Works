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
    public partial class Recharge : Form
    {
        public Recharge()
        {
            InitializeComponent();
        }

        static String connetStr = "server=49.232.138.196;port=3306;user=parkingsystem;password=jHE6nzhrZm6fXHPw; database=parkingsystem;Allow User Variables=True";
        MySqlConnection conn = new MySqlConnection(connetStr);

        private void Recharge_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sql = "select * from vip where cardnumber = @para1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("para1", comboBox1.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                label6.Text = reader.GetFloat("money").ToString();

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
            if(textBox2.Text == "")
            {
                MessageBox.Show("请填写完整!");
            }
            else
            {
                try
                {
                    conn.Open();

                    string sql = "update vip set money = money + @para1 where cardnumber = @para2";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("para1", Convert.ToSingle(textBox2.Text));
                    cmd.Parameters.AddWithValue("para2", comboBox1.Text);

                    int reader = cmd.ExecuteNonQuery();

                    if(reader == 1)
                    {
                        MessageBox.Show("充值成功!");
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
