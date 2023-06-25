using LiveCharts;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;
using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
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
    /// admin.xaml 的交互逻辑
    /// </summary>
    public partial class admin : Window
    {
        MySqlConnection mycon = new MySqlConnection(global.constr);
        public admin()
        {
            InitializeComponent();
            collapseall();
        }
        void collapseall()
        {
            grid1.Visibility = Visibility.Collapsed;
            grid2.Visibility = Visibility.Collapsed;
            grid3.Visibility = Visibility.Collapsed;
        }
        void chaxun()
        {
            string str = string.Format("SELECT * FROM user where type=0");
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
            adapter.Fill(ds, "user");
            if (dt == null)
            {
                dt = ds.Tables["user"];
            }
            datagrid1.ItemsSource = dt.DefaultView;
            mycon.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            collapseall();
            grid1.Visibility = Visibility.Visible;
            chaxun();
        }
        private void datagrid1_LoadingRow(object sender, System.Windows.Controls.DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid1.SelectedItem;
                string UpdateSqlCommand = string.Format("insert into user (id,password,type) values('{0}','{1}',0)", Convert.ToInt32(mySelectedElement.Row[0]), Convert.ToString(mySelectedElement.Row[1]));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(UpdateSqlCommand, mycon);
                cmd.ExecuteNonQuery();
                MessageBoxX.Show("增加成功", "提示");
            }
            catch (Exception ex)
            {
                MessageBoxX.Show(ex.Message, "错误");
            }
            mycon.Close();
            chaxun();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid1.SelectedItem;
                string UpdateSqlCommand = string.Format("update user set id = '{0}', password = '{1}' where id='{2}'", Convert.ToInt32(mySelectedElement.Row[0]),Convert.ToString(mySelectedElement.Row[1]), Convert.ToInt32(mySelectedElement.Row[0]));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(UpdateSqlCommand, mycon);
                cmd.ExecuteNonQuery();
                MessageBoxX.Show("修改成功", "提示");
            }
            catch
            {
                MessageBoxX.Show("请选择要修改的行！", "错误");
            }
            mycon.Close();
            chaxun();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid1.SelectedItem;
                string DeleteSqlCommand = string.Format("delete from user where id = '{0}'", Convert.ToInt32(mySelectedElement.Row[0]));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(DeleteSqlCommand, mycon);
                cmd.ExecuteNonQuery();
                MessageBoxX.Show("删除成功", "提示");
                mySelectedElement.Delete();
            }
            catch
            {
                MessageBoxX.Show("请选择要删除的行！", "错误");
            }
            mycon.Close();
        }
        void chaxun1()
        {
            string str = string.Format("SELECT * FROM `order` where `condition`='未审核'");
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
            datagrid2.ItemsSource = dt.DefaultView;
            mycon.Close();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            collapseall();
            grid2.Visibility = Visibility.Visible;
            chaxun1();
            string str = string.Format("SELECT * FROM `order`");
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
            datagrid3.ItemsSource = dt.DefaultView;
            mycon.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid2.SelectedItem;
                string UpdateSqlCommand = string.Format("update `order` set `condition`='已通过' where `orderno` = '{0}'", Convert.ToString(mySelectedElement.Row[0]));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(UpdateSqlCommand, mycon);
                cmd.ExecuteNonQuery();
                MessageBoxX.Show("审核成功", "提示");
            }
            catch(Exception ex)
            {
                MessageBoxX.Show(ex.Message, "错误");
            }
            mycon.Close();
            chaxun1();
        }

        private void datagrid2_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            collapseall();
            grid3.Visibility = Visibility.Visible;
            string sqlstr0 = string.Format(@"select sum(price) from `order` where `condition`='已通过' and DATE_FORMAT(time,'%Y %m')=date_format(DATE_SUB(curdate(), INTERVAL 0 MONTH),'%Y %m')");
            string sqlstr1 = string.Format(@"select sum(price) from `order` where `condition`='已通过' and DATE_FORMAT(time,'%Y %m')=date_format(DATE_SUB(curdate(), INTERVAL 1 MONTH),'%Y %m')");
            string sqlstr2 = string.Format(@"select sum(price) from `order` where `condition`='已通过' and DATE_FORMAT(time,'%Y %m')=date_format(DATE_SUB(curdate(), INTERVAL 2 MONTH),'%Y %m')");
            string sqlstr3 = string.Format(@"select sum(price) from `order` where `condition`='已通过' and DATE_FORMAT(time,'%Y %m')=date_format(DATE_SUB(curdate(), INTERVAL 3 MONTH),'%Y %m')");
            MySqlCommand mycmd = new MySqlCommand();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr0;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr0 = mycmd.ExecuteReader();
            dr0.Read();
            int a, b, c, d;
            try
            {
                a = Convert.ToInt32(dr0["sum(price)"]);
            }
            catch
            {
                a = 0;
            }
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr1;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr1 = mycmd.ExecuteReader();
            dr1.Read();
            try
            {
                b = Convert.ToInt32(dr1["sum(price)"]);
            }
            catch
            {
                b = 0;
            }
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr2;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr2 = mycmd.ExecuteReader();
            dr2.Read(); try
            {
                c = Convert.ToInt32(dr2["sum(price)"]);
            }
            catch
            {
                c = 0;
            }
            
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr3;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr3 = mycmd.ExecuteReader();
            dr3.Read(); try
            {
                d = Convert.ToInt32(dr3["sum(price)"]);
            }
            catch
            {
                d = 0;
            }
            
            mycon.Close();
            SeriesCollection = new SeriesCollection
            {
                  new RowSeries
                  {
                        Title = "每月审批金额",
                        Values = new ChartValues<int> { a, b, c, d }
                  }
            };
            Labels = new[] { DateTime.Now.Month.ToString() + "月", (DateTime.Now.Month - 1).ToString() + "月", (DateTime.Now.Month - 2).ToString() + "月", (DateTime.Now.Month - 3).ToString() + "月" };
            Formatter = value => value.ToString("N");
            DataContext = this;
        }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<int, string> Formatter { get; set; }
    }
}
