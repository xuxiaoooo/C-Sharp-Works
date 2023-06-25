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
using System.Windows.Shapes;

namespace 学生助学贷款管理系统
{
    /// <summary>
    /// student.xaml 的交互逻辑
    /// </summary>
    public partial class student : Window
    {
        MySqlConnection mycon = new MySqlConnection(global.constr);
        public student()
        {
            InitializeComponent();
            collapseall();
            gridindex.Visibility = Visibility.Visible;
            welcomelabel.Content = "\t学号为：" + global.a + "的用户，\n欢迎登录到学生助学贷款管理系统——学生端！";
        }

        void collapseall()
        {
            gridindex.Visibility = Visibility.Collapsed;
            grid1.Visibility = Visibility.Collapsed;
            grid2.Visibility = Visibility.Collapsed;
            grid3.Visibility = Visibility.Collapsed;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            collapseall();
            grid1.Visibility = Visibility.Visible;
            string sqlstr = string.Format(@"select * from info where id='{0}'",global.a);
            MySqlCommand mycmd = new MySqlCommand();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr = mycmd.ExecuteReader();
            dr.Read();
            学号.Text = dr["id"].ToString();
            姓名.Text= dr["name"].ToString();
            性别.Text = dr["sex"].ToString();
            身份证号.Text = dr["idcard"].ToString();
            出生日期.Text = dr["borndate"].ToString();
            所在省.Text = dr["province"].ToString();
            所在市.Text = dr["city"].ToString();
            家庭住址.Text = dr["address"].ToString();
            邮编.Text = dr["youbian"].ToString();
            电话号码.Text = dr["phonenumber"].ToString();
            备注.Text = dr["remark"].ToString();
            mycon.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string sqlstr = string.Format(@"update info set name='{0}',sex='{1}',idcard='{2}',borndate='{3}',province='{4}',city='{5}',address='{6}',youbian='{7}',phonenumber='{8}',remark='{9}'", 姓名.Text,性别.Text,身份证号.Text,出生日期.SelectedDateTime,所在省.Text,所在市.Text,家庭住址.Text,邮编.Text,电话号码.Text,备注.Text);
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr;
            mycmd.CommandType = CommandType.Text;
            int result = mycmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBoxX.Show("修改成功！", "提示");
            }
            else
                MessageBoxX.Show("修改失败！", "提示");
            mycon.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            collapseall();
            grid2.Visibility = Visibility.Visible;
            showt();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Random ran = new Random();
            orderno.Content = global.a + DateTime.Now.ToString("yyyyMMddHHmmss") + ran.Next(999);
        }
        void showt()
        {
            string str = string.Format("SELECT * FROM `order` where id={0}", global.a);
            mycon.Open();

            MySql.Data.MySqlClient.MySqlDataAdapter adapter = null;
            System.Data.DataSet ds = null;
            System.Data.DataTable dt = null;

            if (adapter == null)
            {
                adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(str, mycon);

            }
            if (ds == null)
            {
                ds = new System.Data.DataSet();
            }
            ds.Clear();
            adapter.Fill(ds, "order");
            if (dt == null)
            {
                dt = ds.Tables["order"];
            }
            datagrid1.ItemsSource = dt.DefaultView;
            mycon.Close();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (orderno.Content.ToString().Length <=0)
            {
                MessageBoxX.Show("请先生成唯一订单号！", "提示");
            }
            else
            {
                string sqlstr = string.Format(@"insert into `order` (`id`,`orderno`,`reason`,`price`,`condition`,`time`) values ('{0}','{1}','{2}','{3}','未审核','{4}');", global.a,orderno.Content.ToString(), txreason.Text.ToString(),Convert.ToDecimal(txprice.Text),DateTime.Now);
                mycon.Open();
                MySqlCommand mycmd = new MySqlCommand();
                mycmd.Connection = mycon;
                mycmd.CommandText = sqlstr;
                mycmd.CommandType = CommandType.Text;
                int result = mycmd.ExecuteNonQuery();
                if (result > 0)
                {
                    mycon.Close();
                    MessageBoxX.Show("修改成功！", "提示");
                    showt();
                }
                else
                    MessageBoxX.Show("修改失败！", "提示");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (txyuan.Text == "" || txxin.Text == "" || txxin2.Text == "")
            {
                MessageBoxX.Show("请输入完全！", "提示");
            }
            else
            {
                if (txyuan.Text != global.b)
                {
                    MessageBoxX.Show("原密码错误！", "提示");
                }
                else
                {
                    if (txxin.Text != txxin2.Text)
                    {
                        MessageBoxX.Show("两次新密码不同！", "提示");
                    }
                    else
                    {
                        string sqlstr = string.Format(@"update user set password='{0}' where id='{1}'",txxin.Text.ToString(), global.a);
                        mycon.Open();
                        MySqlCommand mycmd = new MySqlCommand();
                        mycmd.Connection = mycon;
                        mycmd.CommandText = sqlstr;
                        mycmd.CommandType = CommandType.Text;
                        int result = mycmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBoxX.Show("修改成功！", "提示");
                            global.b = txxin.Text;
                        }
                        else
                            MessageBoxX.Show("修改失败！", "提示");
                        mycon.Close();
                    }
                }
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            collapseall();
            grid3.Visibility = Visibility.Visible;
        }
    }
}
