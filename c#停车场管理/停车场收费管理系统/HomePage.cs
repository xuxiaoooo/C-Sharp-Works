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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        static String connetStr = "server=49.232.138.196;port=3306;user=parkingsystem;password=jHE6nzhrZm6fXHPw; database=parkingsystem;Allow User Variables=True";
        MySqlConnection conn = new MySqlConnection(connetStr);

        parkinginfo info = new parkinginfo();

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            BePutInStorage from = new BePutInStorage();
            from.StartPosition = FormStartPosition.CenterScreen;
            from.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UpdatePrice from = new UpdatePrice();
            from.StartPosition = FormStartPosition.CenterScreen;
            from.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OpenAnAccount from = new OpenAnAccount();
            from.StartPosition = FormStartPosition.CenterScreen;
            from.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Outbound from = new Outbound();
            from.StartPosition = FormStartPosition.CenterScreen;
            from.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Recharge from = new Recharge();
            from.StartPosition = FormStartPosition.CenterScreen;
            from.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            WithDraw from = new WithDraw();
            from.StartPosition = FormStartPosition.CenterScreen;
            from.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            UpdatePassword from = new UpdatePassword();
            from.StartPosition = FormStartPosition.CenterScreen;
            from.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            DialogResult aa = MessageBox.Show("确认退出系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aa == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sql = "select * from now";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                info.Total = info.Remain = 100;
                while (reader.Read())
                {
                    info.Remain--;
                }

                label8.Text = info.Remain.ToString();

                if(info.Remain <= 50)
                {
                    label8.ForeColor = System.Drawing.Color.FromName("#ff0000");
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

            label5.Text = DateTime.Now.ToString();
        }
    }
}
