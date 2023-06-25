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

namespace 外聘教师工资管理
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class login : Window
    {
        static string constr = "server=localhost;user id=sa;pwd=xuxiao; database=outtechmanage";
        SqlConnection mycon = new SqlConnection(constr);
        SqlCommand mycmd = new SqlCommand();
        public login()
        {
            InitializeComponent();
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
                    string sqlstr = string.Format(@"select * from [dbo].[user] where [id]='{0}' and [password]='{1}'",Convert.ToInt32( tx1.Text), tx2.Password.ToString());
                    mycon.Open();
                    mycmd.Connection = mycon;
                    mycmd.CommandText = sqlstr;
                    mycmd.CommandType = CommandType.Text;
                    SqlDataReader dr = mycmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)//登录查询，如果查询到结果
                    {
                        MainWindow mw = new MainWindow();
                        mw.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxX.Show(ex.ToString(), "错误");
            }
        }
    }
}
