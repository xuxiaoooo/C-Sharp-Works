using MySql.Data.MySqlClient;
using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
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

namespace 学生助学贷款管理系统
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection mycon = new MySqlConnection(global.constr);
        MySqlCommand mycmd = new MySqlCommand();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            int cbr = 0;
            if (cb.IsChecked == true)
            {
                cbr = 1;
            }
            else if (cb.IsChecked == false)
            {
                cbr = 0;
            }
            try
            {
                if (tx1.Text.Equals("") || tx2.Password.Equals(""))//检测用户名密码是否为空，空就错误提示
                {
                    MessageBoxX.Show("请输入正确的账号密码！", "错误");
                }
                else
                {
                    string sqlstr = string.Format(@"select * from user WHERE id={0} and password='{1}' and type={2};", Convert.ToInt32(tx1.Text), tx2.Password.ToString(), cbr);
                    mycon.Open();
                    MySqlCommand sqlres = new MySqlCommand(sqlstr, mycon);
                    MySqlDataReader reader = sqlres.ExecuteReader();
                    if (reader.HasRows)//登录查询，如果查询到结果
                    {
                        global.a = Convert.ToInt32(tx1.Text);
                        global.b = Convert.ToString(tx2.Password);
                        if (cbr == 0)
                        {
                            student s = new student();
                            s.Show();
                        }
                        else if (cbr == 1)
                        {
                            admin t = new admin();
                            t.Show();
                        }
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
