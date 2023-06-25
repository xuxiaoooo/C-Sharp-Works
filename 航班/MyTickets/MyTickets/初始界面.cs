using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;


namespace MyTickets
{
    public partial class 初始界面 : Form
    {

        public 初始界面()
        {
            InitializeComponent();
        }
        int count = 0;

        #region 鼠标移动
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void 初始界面_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;

            }
        }

        private void 初始界面_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {

                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void 初始界面_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
        #endregion

        #region 打开其他窗口

        private void 查询订单btn_Click(object sender, EventArgs e)
        {
            string userid = this.用户名TEXT.Text;
            string psword = this.passwordtxt.Text;
            if (userid.Equals("") || psword.Equals(""))//用户名或密码为空
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                /*查询是否有用户信息，有就登陆成功，没有失败*/
                string sql = string.Format(@"select useId,psword from LoginIn where useId = '{0}' and psWord = '{1}'", userid, psword);
                DBHelper dbHelper = new DBHelper();
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                dbHelper.OpenConnection();
                SqlDataReader sdr = cmd.ExecuteReader();
                /*上面的除了数据库查询内容，其他都是固定使用*/
                if (sdr.Read())
                {
                    MessageBox.Show("信息验证成功");

                    //跳转到主页面
                    订单查询 fd = new 订单查询(用户名TEXT.Text);
                    fd.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                }
            }
        }
        #endregion

        #region 轮播
        private void ChangeImage(Image img, int millisecondsTimeOut)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    轮播1.Image = img;
                })
                );
            }
            Thread.Sleep(millisecondsTimeOut);
        }
        private void 初始界面_Load(object sender, EventArgs e)
        {
            Thread th;/*线程开始，循环轮播*/
            th = new Thread
                (
                    delegate ()
                    {
                        // 3就是要循环轮数
                        for (int i = 0; i < 100; i++)
                        {
                            //调用方法
                            ChangeImage(Properties.Resources.东方航空, 2000);
                            count++;
                            ChangeImage(Properties.Resources.南方航空, 2000);
                            count++;
                            ChangeImage(Properties.Resources.四川航空, 2000);
                            count++;
                            ChangeImage(Properties.Resources.海南航空, 2000);
                            count++;
                        }
                    }
                );
            th.IsBackground = true;
            th.Start();
        }

        //关闭
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //轮播点到哪一个就打开对应航空公司官网
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (count % 4 == 0)
            {
                System.Diagnostics.Process.Start("http://www.ceair.com/");
            }
            if (count % 4 == 3)
            {
                System.Diagnostics.Process.Start("https://www.hnair.com/");
            }
            if (count % 4 == 1)
            {
                System.Diagnostics.Process.Start("https://www.csair.com/");
            }
            if (count % 4 == 2)
            {
                System.Diagnostics.Process.Start("http://www.sichuanair.com/");
            }
        }
        #endregion

        #region 绑定登录
        private void 登录btn_Click(object sender, EventArgs e)
        {
            string userid = this.用户名TEXT.Text;
            string psword = this.passwordtxt.Text;
            if (userid.Equals("") || psword.Equals(""))//用户名或密码为空
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                /*查询是否有用户信息，有就登陆成功，没有失败*/
                string sql = string.Format(@"select useId,psword from LoginIn where useId = '{0}' and psWord = '{1}'",userid, psword);
                DBHelper dbHelper = new DBHelper();
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                dbHelper.OpenConnection();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    MessageBox.Show("信息验证成功");

                    //跳转到主页面
                    机票预订 f2 = new 机票预订(用户名TEXT.Text);
                    //this.Hide();
                    f2.ShowDialog();

                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                }
            }
            

        }   
        #endregion
        
        #region 绑定注册
        private void 注册btn_Click(object sender, EventArgs e)
        {
            string userid = this.用户名TEXT.Text;
            string psword = this.passwordtxt.Text;
            if (userid.Equals("") || psword.Equals(""))//用户名或密码为空
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                //插入数据
                string sql = string.Format(@"insert into LoginIn(useId,psWord) values('{0}','{1}')", userid, psword);
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
        #endregion


    }
}
