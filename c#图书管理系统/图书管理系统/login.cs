using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userid = this.textBox1.Text;
            string psword = this.textBox2.Text;
            if (userid.Equals("") || psword.Equals(""))//用户名或密码为空
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                string sql = string.Format(@"select * from [dbo].[operator] where [name] = '{0}' and [code] = '{1}'", userid, psword);
                DBHelper dbHelper = new DBHelper();
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                dbHelper.OpenConnection();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    DBHelper.a = userid;
                    MessageBox.Show("信息验证成功");
                    图书馆管理系统 m = new 图书馆管理系统();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                }
            }
        }
    }
}
