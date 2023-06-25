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
    public partial class UpdatePrice : Form
    {
        public UpdatePrice()
        {
            InitializeComponent();
        }

        static String connetStr = "server=49.232.138.196;port=3306;user=parkingsystem;password=jHE6nzhrZm6fXHPw; database=parkingsystem;";
        MySqlConnection conn = new MySqlConnection(connetStr);

        private void button1_Click(object sender, EventArgs e)
        {
            float fees = Convert.ToSingle(textBox1.Text);
            float dicount = Convert.ToSingle(comboBox1.Text);

            string sql = "update someinformation set fees = @para1, discount = @para2 where flag = @para3";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("para1", Convert.ToSingle(textBox1.Text));
            cmd.Parameters.AddWithValue("para2", Convert.ToSingle(comboBox1.Text));
            cmd.Parameters.AddWithValue("para3", "here");

            int result = cmd.ExecuteNonQuery();

            if(result == 1)
            {
                MessageBox.Show("修改成功!");
                this.Close();
            }

            conn.Close();
        }

        private void UpdatePrice_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
