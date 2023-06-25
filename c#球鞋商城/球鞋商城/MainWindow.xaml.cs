using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 球鞋商城
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection mycon = new SqlConnection(global.con);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txid.Text.Equals("") || txps.Password.Equals(""))//检测用户名密码是否为空，空就错误提示
                {
                    MessageBoxX.Show("请输入正确的账号密码！", "错误");
                }
                else if(txid.Text.Equals("admin") || txps.Password.Equals("admin"))
                {
                    admin ad = new admin();
                    ad.Show();
                    this.Hide();
                }
                else
                {
                    string sqlstr = string.Format(@"select * from [dbo].[user] WHERE [id]='{0}' and [password]='{1}';", Convert.ToString(txid.Text), txps.Password.ToString());
                    mycon.Open();
                    SqlCommand sqlres = new SqlCommand(sqlstr, mycon);
                    SqlDataReader reader = sqlres.ExecuteReader();
                    if (reader.HasRows)//登录查询，如果查询到结果
                    {
                        global.a = Convert.ToString(txid.Text);
                        main m = new main();
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

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txid.Text.Equals("") || txps.Password.Equals(""))//检测用户名密码是否为空，空就错误提示
                {
                    MessageBoxX.Show("请输入正确的账号密码", "错误");
                }
                else
                {
                    string sqlstr = string.Format(@"insert into [dbo].[user] ([id],[password]) values('{0}','{1}')", txid.Text.ToString(), txps.Password.ToString());
                    mycon.Open();
                    SqlCommand mycmd = new SqlCommand();
                    mycmd.Connection = mycon;
                    mycmd.CommandText = sqlstr;
                    mycmd.CommandType = CommandType.Text;
                    int result = mycmd.ExecuteNonQuery();
                    if (result > 0)//登录查询，如果查询到结果
                    {
                        MessageBoxX.Show("注册成功！", "提示");
                    }
                    mycon.Close();
                }
            }
            catch
            {
                MessageBoxX.Show("错误", "错误");
            }
        }
    }
}
