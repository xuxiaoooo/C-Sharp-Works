using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace 贪吃蛇
{
    /// <summary>
    /// login.xaml 的交互逻辑
    /// </summary>
    public partial class login : Window
    {
        static string con = "Server=localhost;Database=tanchishe;user id=sa;pwd=xuxiao";
        SqlConnection mycon = new SqlConnection(con);
        public login()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tx1.Text.Equals("") || tx2.Password.Equals(""))//检测用户名密码是否为空，空就错误提示
                {
                    MessageBoxX.Show("请输入正确的账号密码！", "错误");
                }
                else
                {
                    string sqlstr = string.Format(@"insert into [dbo].[user] ([id],[password]) values({0},'{1}');", Convert.ToInt32(tx1.Text), tx2.Password.ToString());
                    mycon.Open();
                    SqlCommand sqlres = new SqlCommand(sqlstr, mycon);
                    sqlres.ExecuteReader();
                    MessageBoxX.Show("注册成功", "提示");
                    mycon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBoxX.Show(ex.Message, "错误");
            }
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tx1.Text.Equals("") || tx2.Password.Equals(""))//检测用户名密码是否为空，空就错误提示
                {
                    MessageBoxX.Show("请输入正确的账号密码！", "错误");
                }
                else
                {
                    string sqlstr = string.Format(@"select * from [dbo].[user] WHERE id={0} and password='{1}';", Convert.ToInt32(tx1.Text), tx2.Password.ToString());
                    mycon.Open();
                    SqlCommand sqlres = new SqlCommand(sqlstr, mycon);
                    SqlDataReader reader = sqlres.ExecuteReader();
                    if (reader.HasRows)//登录查询，如果查询到结果
                    {
                        MainWindow m = new MainWindow();
                        m.Show();
                        this.Hide();
                    }
                    else
                        MessageBoxX.Show("账号密码错误", "错误");
                    mycon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBoxX.Show(ex.Message, "错误");
            }
        }
    }
}
