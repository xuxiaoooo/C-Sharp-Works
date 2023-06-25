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
using System.Windows.Shapes;

namespace StuScorePublishSys
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        static string con = "Server=localhost;Database=stuscorepublish;user id=sa;pwd=xuxiao";
        SqlConnection mycon = new SqlConnection(con);
        public Login()
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
            else if(cb.IsChecked == false)
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
                    string sqlstr = string.Format(@"select * from [dbo].[user] WHERE id={0} and password='{1}' and type={2};",Convert.ToInt32(tx1.Text), tx2.Password.ToString(),cbr);
                    mycon.Open();
                    SqlCommand sqlres = new SqlCommand(sqlstr, mycon);
                    SqlDataReader reader = sqlres.ExecuteReader();
                    if (reader.HasRows)//登录查询，如果查询到结果
                    {
                        global.a = Convert.ToInt32(tx1.Text);
                        global.b = tx2.Password.ToString();
                        if (cbr == 0)
                        {
                            stu s = new stu();
                            s.Show();
                            this.Hide();
                        }
                        else if (cbr == 1)
                        {
                            teach t = new teach();
                            t.Show();
                            this.Hide();
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
