using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HIS
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            denglu.Visibility = Visibility.Visible;
            zhuce1.Visibility = Visibility.Hidden;
        }
        private void toptab_MouseEnter(object sender, MouseEventArgs e)
        {
            toptab.Opacity = 1;
        }

        private void toptab_MouseLeave(object sender, MouseEventArgs e)
        {
            toptab.Opacity = 0.5;
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void toptab_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void shouji_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (zhanghao.Text == "")
                mima.Clear();
        }

        static string constr = "server=localhost;user id=sa;pwd=xuxiao; database=his;";
        SqlConnection mycon = new SqlConnection(constr);
        SqlCommand mycmd = new SqlCommand();

        private void login_Click(object sender, RoutedEventArgs e)
        {
            string name = this.zhanghao.Text;
            string ps = this.mima.Password;
            if (name.Equals("") || ps.Equals(""))//用户名或密码为空
            {
                MessageBox.Show("输入不可为空！");
            }
            else
            {
                string sqlstr = string.Format(@"select * from [dbo].[registrar] where RNO='{0}' and RPSWD='{1}'", name, ps);
                mycon.Open();
                mycmd.Connection = mycon;
                mycmd.CommandText = sqlstr;
                mycmd.CommandType = CommandType.Text;
                SqlDataReader dr = mycmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    Application.Current.Properties["a"] = name;
                    this.Hide();
                    main m = new main();
                    m.Show();
                }
                else
                {
                    if (MessageBox.Show("账号或密码错误！", "提示", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        zhanghao.Text = "";
                        mima.Password = "";
                    }
                }
                mycon.Close();
            }
        }

        private void zhuce_Click(object sender, RoutedEventArgs e)
        {
            zhuce1.Visibility = Visibility.Visible;
            denglu.Visibility = Visibility.Hidden;
        }

        private void 注册成功_Click(object sender, RoutedEventArgs e)
        {
            String rno = Rno.Text.ToString();
            String rname = Rname.Text.ToString();
            String rps = Rpswd.Password.ToString();
            int rsex;
            if (nan.IsChecked == true) rsex = 1;
            else rsex = 0;
            if (rname.Equals("") || rps.Equals("")||rsex.Equals("")||rno.Equals("")||Rage.Text.Equals(""))
            {
                MessageBox.Show("请输入完整信息！");
            }
            else
            {
                try
                {
                    int rage = Convert.ToInt32(Rage.Text.ToString());
                    string sqlstr = string.Format(@"INSERT INTO [dbo].[registrar] ([RNO], [RPSWD], [RNAME], [RSEX], [RAGE]) VALUES ('{0}', '{1}', '{2}', {3}, {4});", rno, rps,rname,rsex,rage);
                    mycon.Open();
                    mycmd.Connection = mycon;
                    mycmd.CommandText = sqlstr;
                    mycmd.CommandType = CommandType.Text;
                    int result = mycmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        
                        zhuce1.Visibility = Visibility.Hidden;
                        denglu.Visibility = Visibility.Visible;
                        Rname.Text = "";
                        Rno.Text = "";
                        Rpswd.Password = "";
                        MessageBox.Show("注册成功，请登录！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("注册失败！", "提示", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                        {
                            zhanghao.Text = "";
                            mima.Password = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show("该账户已存在！", "提示", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        zhanghao.Text = "";
                        mima.Password = "";
                    }
                }
                mycon.Close();
            }
        }

        private void return_Click(object sender, RoutedEventArgs e)
        {
            zhuce1.Visibility = Visibility.Hidden;
            denglu.Visibility = Visibility.Visible;
        }
    }
}
