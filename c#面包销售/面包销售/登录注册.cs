using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 面包销售
{
    public partial class 登录注册 : Form
    {
        public 登录注册()
        {
            InitializeComponent();
        }

        private void btna_Click(object sender, EventArgs e)
        {
            string userid = this.tba.Text;
            string psword = this.tbb.Text;
            if (userid.Equals("") || psword.Equals(""))//用户名或密码为空
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                string sql = string.Format(@"select * from [dbo].[user] where [id] = '{0}' and [password] = '{1}'", userid, psword);
                DBHelper dbHelper = new DBHelper();
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                dbHelper.OpenConnection();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    DBHelper.a = userid;
                    MessageBox.Show("信息验证成功");
                    main m = new main();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                }
            }
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            string userid = this.tba.Text;
            string psword = this.tbb.Text;
            if (userid.Equals("") || psword.Equals(""))//用户名或密码为空
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                string sql = string.Format(@"insert into [dbo].[user]([id],[password]) values('{0}','{1}')", userid, psword);
                DBHelper dbHelper = new DBHelper();
                try
                {
                    //执行工具
                    SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                    //打开数据库
                    dbHelper.OpenConnection();
                    //执行
                    int result = cmd.ExecuteNonQuery();
                    //判断
                    if (result > 0)
                    {
                        MessageBox.Show("注册成功，请登录！");
                    }
                    else
                    {
                        MessageBox.Show("注册失败，请重试！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误，请联系管理员,错误原因是：" + ex.Message);
                }
            }
        }
    }
}
