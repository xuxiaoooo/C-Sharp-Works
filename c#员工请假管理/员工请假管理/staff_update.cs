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
    public partial class staff_update : Form
    {
        public staff_update()
        {
            InitializeComponent();
        }

        private void staff_update_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
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
            }catch
            {
                MessageBox.Show("查询错误, 请核实后重新输入!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            sql = @"UPDATE 普通员工信息 SET 姓名 = '{0}', 上级员工编号 = '{1}', 所在部门编号 = '{2}', 账号 = '{3}', 密码 = '{4}' WHERE 员工编号 = '{5}'";
            sql = string.Format(sql, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox1.Text);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show("修改成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
