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

namespace StuScorePublishSys
{
    /// <summary>
    /// teach.xaml 的交互逻辑
    /// </summary>
    public partial class teach : Window
    {
        static string con = "Server=localhost;Database=stuscorepublish;user id=sa;pwd=xuxiao";
        SqlConnection mycon = new SqlConnection(con);
        public teach()
        {
            InitializeComponent();
        }

        private void btnchaxun_Click(object sender, RoutedEventArgs e)
        {
            chaxun();
        }
        void chaxun()
        {
            string str = string.Format("SELECT * FROM [dbo].[score]");
            SqlDataAdapter adapter=null;
            DataSet ds=null;
            DataTable dt=null;
            if (adapter == null)
            {
                adapter = new SqlDataAdapter(str, mycon);

            }
            if (ds == null)
            {
                ds = new System.Data.DataSet();
            }
            ds.Clear();
            adapter.Fill(ds, "score");
            if (dt == null)
            {
                dt = ds.Tables["score"];
            }
            datagrid1.ItemsSource = dt.DefaultView;
            mycon.Close();
        }

        private void btnxiugai_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid1.SelectedItem;
                string UpdateSqlCommand = string.Format(@"UPDATE [dbo].[score] SET [yuwen] = {0}, [shuxue] = {1}, [yingyu] = {2}, [class] = '{3}' WHERE [id] = {4}", Convert.ToInt32(mySelectedElement.Row[1]), Convert.ToInt32(mySelectedElement.Row[2]), Convert.ToInt32(mySelectedElement.Row[3]), (mySelectedElement.Row[4]).ToString(), Convert.ToInt32(mySelectedElement.Row[0]));
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

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid1.SelectedItem;
                string UpdateSqlCommand = string.Format("insert into [dbo].[score] ([id],[yuwen],[shuxue],[yingyu],[class]) values ({0},{1},{2},{3},'{4}')", Convert.ToInt32(mySelectedElement.Row[0]), Convert.ToInt32(mySelectedElement.Row[1]), Convert.ToInt32(mySelectedElement.Row[2]), Convert.ToInt32(mySelectedElement.Row[3]),(mySelectedElement.Row[4]).ToString());
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
                string DeleteSqlCommand = string.Format("delete from [dbo].[score] where id = {0}", Convert.ToInt32(mySelectedElement.Row[0]));
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

        private void datagrid1_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        private void btngrid1_Click(object sender, RoutedEventArgs e)
        {
            grid1.Visibility = Visibility.Visible;
            grid2.Visibility = Visibility.Collapsed;
        }
        public SeriesCollection SeriesCollectionpie { get; set; }
        int[] a = new int[5];
        private void btngrid2_Click(object sender, RoutedEventArgs e)
        {
            grid1.Visibility = Visibility.Collapsed;
            grid2.Visibility = Visibility.Visible;
            cal3();
            SeriesCollectionpie = new SeriesCollection
            {
                    new PieSeries
                    {
                        Title = "语文",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(a[0]) },
                        DataLabels = true
                    },
                    new PieSeries
                    {
                        Title = "数学",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(a[1]) },
                        DataLabels = true
                    },
                    new PieSeries
                    {
                        Title = "英语",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(a[2]) },
                        DataLabels = true
                    }
            };
            DataContext = this;
            cal();
            cal2();
            cal4();
            cal5();
            cal6();
        }
        void cal()
        {
            string sqlstr = string.Format(@"select top 1
    id, yuwen, shuxue, yingyu, 
    (yuwen+ shuxue+ yingyu) As 总分,
    ((yuwen+ shuxue+ yingyu) /3 )As 平均分
from 
    [dbo].[score]
order by 总分 desc;");
            mycon.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, con);
            DataTable dt = new DataTable();
            myda.Fill(dt);
            int id= Convert.ToInt32(dt.Rows[0]["id"]);
            int zuigao = Convert.ToInt32(dt.Rows[0]["总分"]);
            int pingjun= Convert.ToInt32(dt.Rows[0]["平均分"]);
            labels.Content = "";
            labels.Content += "学号为：" + id + "的同学，总成绩最高为：" + zuigao + "分\t三门均分为：" + pingjun + "分\n";
            mycon.Close();
        }
        void cal2()
        {
            string sqlstr = string.Format(@"select top 1
    id, yuwen, shuxue, yingyu, 
    (yuwen+ shuxue+ yingyu) As 总分,
    ((yuwen+ shuxue+ yingyu) /3 )As 平均分
from 
    [dbo].[score]
order by 总分 asc;");
            mycon.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, con);
            DataTable dt = new DataTable();
            myda.Fill(dt);
            int id = Convert.ToInt32(dt.Rows[0]["id"]);
            int zuidi = Convert.ToInt32(dt.Rows[0]["总分"]);
            int pingjun = Convert.ToInt32(dt.Rows[0]["平均分"]);
            labels.Content += "学号为：" + id + "的同学，总成绩最低为：" + zuidi + "分\t三门均分为：" + pingjun + "分\n";
            mycon.Close();
        }
        void cal3()
        {
            string sqlstr = string.Format(@"select count(1) count1 from score where yuwen>=60;");
            mycon.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, con);
            DataTable dt = new DataTable();
            myda.Fill(dt);
            a[0] = Convert.ToInt32(dt.Rows[0]["count1"]);
            mycon.Close();
            string sqlstr2 = string.Format(@"select count(2) count2 from score where shuxue>=60;");
            mycon.Open();
            SqlDataAdapter myda2 = new SqlDataAdapter(sqlstr2, con);
            DataTable dt2 = new DataTable();
            myda2.Fill(dt2);
            a[1] = Convert.ToInt32(dt2.Rows[0]["count2"]);
            mycon.Close();
            string sqlstr3 = string.Format(@"select count(3) count3 from score where yingyu>=60;");
            mycon.Open();
            SqlDataAdapter myda3 = new SqlDataAdapter(sqlstr3, con);
            DataTable dt3 = new DataTable();
            myda3.Fill(dt3);
            a[2] = Convert.ToInt32(dt3.Rows[0]["count3"]);
            mycon.Close();
        }
        void cal4()
        {
            string sqlstr = string.Format(@"select top 1 *
from score
order by yuwen desc");
            mycon.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, con);
            DataTable dt = new DataTable();
            myda.Fill(dt);
            int id = Convert.ToInt32(dt.Rows[0]["id"]);
            int yuwen = Convert.ToInt32(dt.Rows[0]["yuwen"]);
            string classs = (dt.Rows[0]["class"]).ToString();
            labels.Content +="来自"+classs+ ",学号为：" + id + "的同学，语文成绩最高为：" + yuwen + "分\n";
            mycon.Close();
        }
        void cal5()
        {
            string sqlstr = string.Format(@"select top 1 *
from score
order by shuxue desc");
            mycon.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, con);
            DataTable dt = new DataTable();
            myda.Fill(dt);
            int id = Convert.ToInt32(dt.Rows[0]["id"]);
            int shuxue = Convert.ToInt32(dt.Rows[0]["shuxue"]);
            string classs = (dt.Rows[0]["class"]).ToString();
            labels.Content += "来自" + classs + ",学号为：" + id + "的同学，数学成绩最高为：" + shuxue + "分\n";
            mycon.Close();
        }
        void cal6()
        {
            string sqlstr = string.Format(@"select top 1 *
from score
order by yingyu desc");
            mycon.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, con);
            DataTable dt = new DataTable();
            myda.Fill(dt);
            int id = Convert.ToInt32(dt.Rows[0]["id"]);
            int yingyu = Convert.ToInt32(dt.Rows[0]["yingyu"]);
            string classs = (dt.Rows[0]["class"]).ToString();
            labels.Content += "来自" + classs + ",学号为：" + id + "的同学，英语成绩最高为：" + yingyu + "分\n";
            mycon.Close();
        }
    }
}
