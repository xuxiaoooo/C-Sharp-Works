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
    public partial class staff_new : Form
    {
        public staff_new()
        {
            InitializeComponent();
        }

        private void staff_new_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            sql = @"INSERT INTO 普通员工信息 VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')";
            sql = string.Format(sql, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show("添加成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
