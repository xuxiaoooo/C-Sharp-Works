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
    public partial class staff_del : Form
    {
        public staff_del()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            string sql;
            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            sql = @"select * from 普通员工信息 where 员工编号 = '{0}'";
            sql = string.Format(sql, textBox1.Text);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader result = cmd.ExecuteReader();

            result.Read();
            textBox2.Text = (string)result[0];
            textBox3.Text = (string)result[1];
            textBox4.Text = (string)result[2];
            textBox5.Text = (string)result[3];
            textBox6.Text = (string)result[4];
            textBox7.Text = (string)result[5];
            }
            catch
            {
                MessageBox.Show("查询错误,请核实后重新输入!");
            }

}

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            sql = @"DELETE FROM 普通员工信息 WHERE 员工编号 = {0}";
            sql = string.Format(sql, textBox2.Text);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show("删除成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void staff_del_Load(object sender, EventArgs e)
        {

        }
    }
}
