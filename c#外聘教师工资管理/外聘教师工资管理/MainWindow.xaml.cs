using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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

namespace 外聘教师工资管理
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        static string constr = "server=localhost;user id=sa;pwd=xuxiao; database=outtechmanage";
        SqlConnection mycon = new SqlConnection(constr);
        SqlCommand mycmd = new SqlCommand();
        public MainWindow()
        {
            InitializeComponent();
            easycollapse();
            cal1();
            pie();
        }
        void easycollapse() 
        {
            cb11.Visibility = Visibility.Collapsed;
            cb12.Visibility = Visibility.Collapsed;
            cb13.Visibility = Visibility.Collapsed;
        }
        private void cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb1.SelectedIndex == 1)
            {
                easycollapse();
                cb11.Visibility = Visibility.Visible;
            }
            else if (cb1.SelectedIndex == 2)
            {
                easycollapse();
                cb12.Visibility = Visibility.Visible;
            }
            else if (cb1.SelectedIndex == 3)
            {
                easycollapse();
                cb13.Visibility = Visibility.Visible;
            }
            
        }
        void chaxun()
        {
            string str = "";
            if (cb1.SelectedIndex == 0)
            {
                str = string.Format("SELECT * FROM [dbo].[teacherinfo]");
            }
            else if (cb1.SelectedIndex == 1)
            {
                str = string.Format("SELECT * FROM [dbo].[teacherinfo] where [name]='{0}'", Convert.ToString(cb11.Text));
            }
            else if (cb1.SelectedIndex == 2)
            {
                str = string.Format("SELECT * FROM [dbo].[teacherinfo] where [faculty]='{0}'", cb12.Text.ToString());
            }
            else if (cb1.SelectedIndex == 3)
            {
                str = string.Format("SELECT * FROM [dbo].[teacherinfo] where [degree]='{0}'", Convert.ToString(cb13.Text));
            }
            mycon.Open();

            SqlDataAdapter adapter = null;
            System.Data.DataSet ds = null;
            System.Data.DataTable dt = null;

            if (adapter == null)
            {
                adapter = new SqlDataAdapter(str, mycon);

            }
            if (ds == null)
            {
                ds = new System.Data.DataSet();
            }
            ds.Clear();
            adapter.Fill(ds, "teacherinfo");
            if (dt == null)
            {
                dt = ds.Tables["teacherinfo"];
            }
            datagrid1.ItemsSource = dt.DefaultView;
            mycon.Close();
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            chaxun();
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid1.SelectedItem;
                string UpdateSqlCommand = string.Format("insert into [dbo].[teacherinfo] ([name],[faculty],[coursenum],[degree]) values('{0}','{1}',{2}, '{3}')", Convert.ToString(mySelectedElement.Row[1]), Convert.ToString(mySelectedElement.Row[2]), Convert.ToInt32(mySelectedElement.Row[3]), (mySelectedElement.Row[4]).ToString());
                SqlCommand cmd = new SqlCommand(UpdateSqlCommand, mycon);
                cmd.ExecuteNonQuery();
                MessageBoxX.Show("增加成功", "提示");
            }
            catch
            {
                MessageBoxX.Show("请选择最后一行空白行进行增加操作！", "错误");
            }
            mycon.Close();
            chaxun();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid1.SelectedItem;
                string DeleteSqlCommand = string.Format("delete from [dbo].[teacherinfo] where [id] = '{0}'", Convert.ToInt32(mySelectedElement.Row[0]));
                SqlCommand cmd = new SqlCommand(DeleteSqlCommand, mycon);
                cmd.ExecuteNonQuery();
                MessageBoxX.Show("删除成功", "提示");
                mySelectedElement.Delete();
            }
            catch
            {
                MessageBoxX.Show("请选择要删除的行！", "错误");
            }
            mycon.Close();
            chaxun();
        }

        private void btnchange_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid1.SelectedItem;
                string UpdateSqlCommand = string.Format(@"update [dbo].[teacherinfo] set [name] = '{0}', [faculty] = '{1}', [coursenum]= {2},[degree]= '{3}' WHERE [id]={4}", Convert.ToString(mySelectedElement.Row[1]), Convert.ToString(mySelectedElement.Row[2]), Convert.ToInt32(mySelectedElement.Row[3]), (mySelectedElement.Row[4]).ToString(), Convert.ToInt32(mySelectedElement.Row[0]));
                SqlCommand cmd = new SqlCommand(UpdateSqlCommand, mycon);
                cmd.ExecuteNonQuery();
                MessageBoxX.Show("修改成功", "提示");
            }
            catch (Exception ex)
            {
                MessageBoxX.Show(ex.Message, "错误");
            }
            mycon.Close();
            chaxun();
        }

        private void datagrid1_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }
        int benke, shuoshi, boshi;
        int coursenum, deg;

        private void btnchamoney_Click(object sender, RoutedEventArgs e)
        {
            string str = string.Format("SELECT * FROM [dbo].[teacherinfo] where [name]='{0}'", Convert.ToString(txname.Text));

            mycon.Open();

            mycmd.Connection = mycon;
            mycmd.CommandText = str;
            mycmd.CommandType = CommandType.Text;
            SqlDataReader dr = mycmd.ExecuteReader();
            dr.Read();
            coursenum = Convert.ToInt32(dr["coursenum"]);
            string ss = (dr["degree"]).ToString();
            if (ss == "本科") deg = benke;
            else if (ss == "硕士") deg = shuoshi;
            else if (ss == "博士") deg = boshi;
            labelm.Content = "教师 " + txname.Text + " 的上课数量为：" + coursenum + ",学历为：" + ss + " ，工资为：" + (coursenum * deg);
            mycon.Close();
        }

        private void btnsetmoney_Click(object sender, RoutedEventArgs e)
        {
            benke = Convert.ToInt32(txb.Text);
            shuoshi = Convert.ToInt32(txs.Text);
            boshi = Convert.ToInt32(txbo.Text);
            MessageBoxX.Show("设置成功！", "提示");
        }
        public SeriesCollection SeriesCollectionpie { get; set; }
        int[] a = new int[3];
        void pie()
        {
            SeriesCollectionpie = new SeriesCollection
            {
                    new PieSeries
                    {
                        Title = "本科",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(a[0]) },
                        DataLabels = true
                    },
                    new PieSeries
                    {
                        Title = "硕士",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(a[1]) },
                        DataLabels = true
                    },
                    new PieSeries
                    {
                        Title = "博士",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(a[2]) },
                        DataLabels = true
                    }
            };
            DataContext = this;
        }
        void cal1()
        {
            string sqlstr = string.Format(@"select count(1) count1 from [dbo].[teacherinfo] where degree='本科';");
            mycon.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, constr);
            DataTable dt = new DataTable();
            myda.Fill(dt);
            a[0] = Convert.ToInt32(dt.Rows[0]["count1"]);
            mycon.Close();
            string sqlstr2 = string.Format(@"select count(2) count2 from [dbo].[teacherinfo] where degree='硕士';");
            mycon.Open();
            SqlDataAdapter myda2 = new SqlDataAdapter(sqlstr2, constr);
            DataTable dt2 = new DataTable();
            myda2.Fill(dt2);
            a[1] = Convert.ToInt32(dt2.Rows[0]["count2"]);
            mycon.Close();
            string sqlstr3 = string.Format(@"select count(3) count3 from [dbo].[teacherinfo] where degree='博士';");
            mycon.Open();
            SqlDataAdapter myda3 = new SqlDataAdapter(sqlstr3, constr);
            DataTable dt3 = new DataTable();
            myda3.Fill(dt3);
            a[2] = Convert.ToInt32(dt3.Rows[0]["count3"]);
            mycon.Close();
        }
    }
}
