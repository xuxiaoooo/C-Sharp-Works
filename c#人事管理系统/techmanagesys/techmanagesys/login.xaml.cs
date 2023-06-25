using MySql.Data.MySqlClient;
using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace techmanagesys
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        #region 数据库连接
        static string constr = "server=49.232.138.196;port=3306;user=techmanage;password=M2en6LFNTYwxLSWt; database=techmanage";
        MySqlConnection mycon = new MySqlConnection(constr);
        MySqlCommand mycmd = new MySqlCommand();
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (account.Text.Equals("") || password.Password.Equals(""))//检测用户名密码是否为空，空就错误提示
                {
                    MessageBoxX.Show("请输入正确的账号密码！", "错误");
                }
                else
                {
                    string sqlstr = string.Format(@"select * from user where account='{0}' and password='{1}'", account.Text.ToString(), password.Password.ToString());
                    mycon.Open();
                    mycmd.Connection = mycon;
                    mycmd.CommandText = sqlstr;
                    mycmd.CommandType = CommandType.Text;
                    MySqlDataReader dr = mycmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)//登录查询，如果查询到结果
                    {
                        mainfun mf = new mainfun();
                        mf.Show();
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
