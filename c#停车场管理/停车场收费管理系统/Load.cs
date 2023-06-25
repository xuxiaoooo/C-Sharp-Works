using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 停车场收费管理系统
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        static String connetStr = "server=49.232.138.196;port=3306;user=parkingsystem;password=jHE6nzhrZm6fXHPw; database=parkingsystem;";
        MySqlConnection conn = new MySqlConnection(connetStr);

        private bool check()
        {
            bool result = false;
            string sql = "select * from user where username = @para1 and password = @para2";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("para1", textBox1.Text);
            cmd.Parameters.AddWithValue("para2", textBox2.Text);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = true;
            }

            return result;
        }

        private void Load_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (check())
                {
                    Thread th = new Thread(delegate () { new HomePage().ShowDialog(); });
                    th.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("账号/密码错误");
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
