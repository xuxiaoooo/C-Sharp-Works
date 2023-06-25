using LiveCharts;
using LiveCharts.Wpf;
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

namespace techmanagesys
{
    /// <summary>
    /// mainfun.xaml 的交互逻辑
    /// </summary>
    public partial class mainfun : Window
    {
        #region 数据库连接
        static string constr = "server=49.232.138.196;port=3306;user=techmanage;password=M2en6LFNTYwxLSWt; database=techmanage";
        MySqlConnection mycon = new MySqlConnection(constr);
        MySqlCommand mycmd = new MySqlCommand();
        #endregion
        public mainfun()
        {
            InitializeComponent();
        }
        #region 模块一
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            教师教学.Visibility = Visibility.Visible;
            科研信息.Visibility = Visibility.Collapsed;
            绩效.Visibility = Visibility.Collapsed;
        }
        void easycollapse()
        {
            cb11.Visibility = Visibility.Collapsed;
            cb12.Visibility = Visibility.Collapsed;
            cb13.Visibility = Visibility.Collapsed;
            cb14.Visibility = Visibility.Collapsed;
            cb15.Visibility = Visibility.Collapsed;
            cb16.Visibility = Visibility.Collapsed;
            cb17.Visibility = Visibility.Collapsed;
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
            else if (cb1.SelectedIndex == 4)
            {
                easycollapse();
                cb14.Visibility = Visibility.Visible;
            }
            else if (cb1.SelectedIndex == 5)
            {
                easycollapse();
                cb15.Visibility = Visibility.Visible;
            }
            else if (cb1.SelectedIndex == 6)
            {
                easycollapse();
                cb16.Visibility = Visibility.Visible;
            }
            else if (cb1.SelectedIndex == 7)
            {
                easycollapse();
                cb17.Visibility = Visibility.Visible;
            }
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            chaxun();
        }
        void chaxun()
        {
            string str = "";
            if (cb1.SelectedIndex == 0)
            {
                str = string.Format("SELECT * FROM teacherinfo");
            }
            else if (cb1.SelectedIndex == 1)
            {
                str = string.Format("SELECT * FROM teacherinfo where teacherid='{0}'", Convert.ToInt32(cb11.Text));
            }
            else if (cb1.SelectedIndex == 2)
            {
                str = string.Format("SELECT * FROM teacherinfo where teachname='{0}'", cb12.Text.ToString());
            }
            else if (cb1.SelectedIndex == 3)
            {
                str = string.Format("SELECT * FROM teacherinfo where courseid='{0}'", Convert.ToInt32(cb13.Text));
            }
            else if (cb1.SelectedIndex == 4)
            {
                str = string.Format("SELECT * FROM teacherinfo where coursename='{0}'", cb14.Text.ToString());
            }
            else if (cb1.SelectedIndex == 5)
            {
                str = string.Format("SELECT * FROM teacherinfo where coursetime='{0}'", Convert.ToInt32(cb15.Text));
            }
            else if (cb1.SelectedIndex == 6)
            {
                str = string.Format("SELECT * FROM teacherinfo where credithour='{0}'", Convert.ToInt32(cb16.Text));
            }
            else if (cb1.SelectedIndex == 7)
            {
                str = string.Format("SELECT * FROM teacherinfo where character='{0}'", cb17.Text.ToString());
            }
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
            adapter.Fill(ds, "teacherinfo");
            if (dt == null)
            {
                dt = ds.Tables["teacherinfo"];
            }
            datagrid1.ItemsSource = dt.DefaultView;
            mycon.Close();
        }
        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid1.SelectedItem;
                string UpdateSqlCommand = string.Format("insert into teacherinfo (teacherid,teachname,courseid,coursename,coursetime,credithour,`character`) values('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}')", Convert.ToInt32(mySelectedElement.Row[1]), Convert.ToString(mySelectedElement.Row[2]), Convert.ToInt32(mySelectedElement.Row[3]), (mySelectedElement.Row[4]).ToString(), Convert.ToInt32(mySelectedElement.Row[5]), Convert.ToInt32(mySelectedElement.Row[6]), (mySelectedElement.Row[7]).ToString());
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(UpdateSqlCommand, mycon);
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
                string DeleteSqlCommand = string.Format("delete from teacherinfo where id = '{0}'", Convert.ToInt32(mySelectedElement.Row[0]));
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
            chaxun();
        }

        private void btnchange_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid1.SelectedItem;
                string UpdateSqlCommand = string.Format(@"update teacherinfo set teacherid = {0}, teachname = '{1}', courseid = {2}, coursename= '{3}',coursetime= {4}, credithour= {5},`character` = '{6}' WHERE `id`={7}", Convert.ToInt32(mySelectedElement.Row[1]),Convert.ToString(mySelectedElement.Row[2]), Convert.ToInt32(mySelectedElement.Row[3]), (mySelectedElement.Row[4]).ToString(), Convert.ToInt32(mySelectedElement.Row[5]), Convert.ToInt32(mySelectedElement.Row[6]), (mySelectedElement.Row[7]).ToString(), Convert.ToInt32(mySelectedElement.Row[0]));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(UpdateSqlCommand, mycon);
                cmd.ExecuteNonQuery();
                MessageBoxX.Show("修改成功", "提示");
            }
            catch(Exception ex)
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
        #endregion
        #region 模块二
        void easycollapse1()
        {
            cb21.Visibility = Visibility.Collapsed;
            cb22.Visibility = Visibility.Collapsed;
            cb23.Visibility = Visibility.Collapsed;
        }

        

        private void cb2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb2.SelectedIndex == 1)
            {
                easycollapse1();
                cb21.Visibility = Visibility.Visible;
            }
            else if (cb2.SelectedIndex == 2)
            {
                easycollapse1();
                cb22.Visibility = Visibility.Visible;
            }
            else if (cb2.SelectedIndex == 3)
            {
                easycollapse1();
                cb23.Visibility = Visibility.Visible;
            }
        }
        void chaxun1()
        {
            string str = "";
            if (cb2.SelectedIndex == 0)
            {
                str = string.Format("SELECT * FROM studycondition");
            }
            else if (cb2.SelectedIndex == 1)
            {
                str = string.Format("SELECT * FROM studycondition where teacherid='{0}'", Convert.ToInt32(cb21.Text));
            }
            else if (cb2.SelectedIndex == 2)
            {
                str = string.Format("SELECT * FROM studycondition where direction='{0}'", cb22.Text.ToString());
            }
            else if (cb2.SelectedIndex == 3)
            {
                str = string.Format("SELECT * FROM studycondition where condition='{0}'", cb23.Text.ToString());
            }
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
            adapter.Fill(ds, "studycondition");
            if (dt == null)
            {
                dt = ds.Tables["studycondition"];
            }
            datagrid2.ItemsSource = dt.DefaultView;
            mycon.Close();
        }
        private void btnsearch1_Click(object sender, RoutedEventArgs e)
        {
            chaxun1();
        }

        private void btnadd1_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid2.SelectedItem;
                string UpdateSqlCommand = string.Format("insert into studycondition (`teacherid`,`direction`,`condition`,`patent`,`paper`) values('{0}','{1}','{2}', '{3}', '{4}')", Convert.ToInt32(mySelectedElement.Row[1]), Convert.ToString(mySelectedElement.Row[2]), Convert.ToString(mySelectedElement.Row[3]), (mySelectedElement.Row[4]).ToString(), Convert.ToString(mySelectedElement.Row[5]));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(UpdateSqlCommand, mycon);
                cmd.ExecuteNonQuery();
                MessageBoxX.Show("增加成功", "提示");
            }
            catch
            {
                MessageBoxX.Show("请选择最后一行空白行进行增加操作！", "错误");
            }
            mycon.Close();
            chaxun1();
        }

        private void btndelete1_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid2.SelectedItem;
                string DeleteSqlCommand = string.Format("delete from studycondition where id = '{0}'", Convert.ToInt32(mySelectedElement.Row[0]));
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
            chaxun1();
        }

        private void btnchange1_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid2.SelectedItem;
                string UpdateSqlCommand = string.Format(@"update studycondition set `teacherid` = {0}, `direction` = '{1}', `condition` = '{2}', `patent`= '{3}',`paper`= '{4}' WHERE `id`={5}", Convert.ToInt32(mySelectedElement.Row[1]), Convert.ToString(mySelectedElement.Row[2]), Convert.ToString(mySelectedElement.Row[3]), (mySelectedElement.Row[4]).ToString(), Convert.ToString(mySelectedElement.Row[5]), Convert.ToInt32(mySelectedElement.Row[0]));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(UpdateSqlCommand, mycon);
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

        private void datagrid2_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            教师教学.Visibility = Visibility.Collapsed;
            科研信息.Visibility = Visibility.Visible;
            绩效.Visibility = Visibility.Collapsed;
        }
        #endregion
        #region 模块三
        public Func<double, string> FormatterT { get; set; }
        public Func<double, string> FormatterS { get; set; }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }

        
        List<string> names = new List<string>() { "占皓月", "伊忆远", "阳飞兰", "素书白", "玄悦", "殷千秋", "天春雪", "仝从珊", "本秋柔", "戴泽民" };
        List<double> temperature = new List<double>();

        ColumnSeries sizeseries = new ColumnSeries();
        ColumnSeries templeseries = new ColumnSeries();
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            教师教学.Visibility = Visibility.Collapsed;
            科研信息.Visibility = Visibility.Collapsed;
            绩效.Visibility = Visibility.Visible;
            string sqlstr1 = string.Format(@"select count(*) from teacherinfo where teacherid=1001");
            string sqlstr2 = string.Format(@"select count(*) from teacherinfo where teacherid=1002");
            string sqlstr3 = string.Format(@"select count(*) from teacherinfo where teacherid=1003");
            string sqlstr4 = string.Format(@"select count(*) from teacherinfo where teacherid=1004");
            string sqlstr5 = string.Format(@"select count(*) from teacherinfo where teacherid=1005");
            string sqlstr6 = string.Format(@"select count(*) from teacherinfo where teacherid=1006");
            string sqlstr7 = string.Format(@"select count(*) from teacherinfo where teacherid=1007");
            string sqlstr8 = string.Format(@"select count(*) from teacherinfo where teacherid=1008");
            string sqlstr9 = string.Format(@"select count(*) from teacherinfo where teacherid=1009");
            string sqlstr10 = string.Format(@"select count(*) from teacherinfo where teacherid=1010");
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr1;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr1 = mycmd.ExecuteReader();
            dr1.Read();
            int a1 = Convert.ToInt32(dr1["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr2;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr2 = mycmd.ExecuteReader();
            dr2.Read();
            int a2 = Convert.ToInt32(dr2["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr3;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr3 = mycmd.ExecuteReader();
            dr3.Read();
            int a3 = Convert.ToInt32(dr3["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr4;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr4 = mycmd.ExecuteReader();
            dr4.Read();
            int a4 = Convert.ToInt32(dr4["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr5;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr5 = mycmd.ExecuteReader();
            dr5.Read();
            int a5 = Convert.ToInt32(dr5["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr6;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr6 = mycmd.ExecuteReader();
            dr6.Read();
            int a6 = Convert.ToInt32(dr6["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr7;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr7 = mycmd.ExecuteReader();
            dr7.Read();
            int a7 = Convert.ToInt32(dr7["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr8;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr8 = mycmd.ExecuteReader();
            dr8.Read();
            int a8 = Convert.ToInt32(dr8["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr9;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr9 = mycmd.ExecuteReader();
            dr9.Read();
            int a9 = Convert.ToInt32(dr9["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr10;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr10 = mycmd.ExecuteReader();
            dr10.Read();
            int a10 = Convert.ToInt32(dr10["count(*)"]);
            mycon.Close();
            List<double> countteach = new List<double> { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 };
            string sqlstr11 = string.Format(@"select count(*) from studycondition where teacherid=1001");
            string sqlstr21 = string.Format(@"select count(*) from studycondition where teacherid=1002");
            string sqlstr31 = string.Format(@"select count(*) from studycondition where teacherid=1003");
            string sqlstr41 = string.Format(@"select count(*) from studycondition where teacherid=1004");
            string sqlstr51 = string.Format(@"select count(*) from studycondition where teacherid=1005");
            string sqlstr61 = string.Format(@"select count(*) from studycondition where teacherid=1006");
            string sqlstr71 = string.Format(@"select count(*) from studycondition where teacherid=1007");
            string sqlstr81 = string.Format(@"select count(*) from studycondition where teacherid=1008");
            string sqlstr91 = string.Format(@"select count(*) from studycondition where teacherid=1009");
            string sqlstr101 = string.Format(@"select count(*) from studycondition where teacherid=1010");
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr11;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr11 = mycmd.ExecuteReader();
            dr11.Read();
            int a11 = Convert.ToInt32(dr11["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr21;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr21 = mycmd.ExecuteReader();
            dr21.Read();
            int a21 = Convert.ToInt32(dr21["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr31;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr31 = mycmd.ExecuteReader();
            dr31.Read();
            int a31 = Convert.ToInt32(dr31["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr41;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr41= mycmd.ExecuteReader();
            dr41.Read();
            int a41 = Convert.ToInt32(dr41["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr51;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr51 = mycmd.ExecuteReader();
            dr51.Read();
            int a51 = Convert.ToInt32(dr51["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr61;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr61 = mycmd.ExecuteReader();
            dr61.Read();
            int a61 = Convert.ToInt32(dr61["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr71;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr71 = mycmd.ExecuteReader();
            dr71.Read();
            int a71 = Convert.ToInt32(dr71["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr81;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr81 = mycmd.ExecuteReader();
            dr81.Read();
            int a81 = Convert.ToInt32(dr81["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr91;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr91 = mycmd.ExecuteReader();
            dr91.Read();
            int a91 = Convert.ToInt32(dr91["count(*)"]);
            mycon.Close();
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr101;
            mycmd.CommandType = CommandType.Text;
            MySqlDataReader dr101 = mycmd.ExecuteReader();
            dr101.Read();
            int a101 = Convert.ToInt32(dr101["count(*)"]);
            mycon.Close();
            List<double> countsearch = new List<double> { a11, a21, a31, a41, a51, a61, a71, a81, a91, a101 };
            FormatterT = value => value + "门";
            FormatterS = value => value + "个";
            Labels = names.ToArray();

            templeseries.Title = "教学";
            templeseries.ScalesYAt = 0;
            axisT.Title = "教学科目/门°";

            sizeseries.Title = "科研";
            sizeseries.ScalesYAt = 1;
            axisS.Title = "科研成果/个";

            SeriesCollection = new SeriesCollection { };
            SeriesCollection.Add(templeseries);
            SeriesCollection.Add(sizeseries);
            templeseries.Values = new ChartValues<double>(countteach);
            sizeseries.Values = new ChartValues<double>(countsearch);
            DataContext = this;
            List<object> aList = new List<object>();
            GrourpValue ps1 = new GrourpValue();
            GrourpValue ps2 = new GrourpValue();
            GrourpValue ps3 = new GrourpValue();
            GrourpValue ps4 = new GrourpValue();
            GrourpValue ps5 = new GrourpValue();
            GrourpValue ps6 = new GrourpValue();
            GrourpValue ps7 = new GrourpValue();
            GrourpValue ps8 = new GrourpValue();
            GrourpValue ps9 = new GrourpValue();
            GrourpValue ps10 = new GrourpValue();
            ps1.teacherid = "1001";
            ps1.teachname = "占皓月";
            ps1.coursecount = a1.ToString();
            ps1.papercount = a11.ToString();
            ps1.score = (a1 * 0.4 + a11 * 0.6).ToString();
            ps2.teacherid = "1002";
            ps2.teachname = "伊忆远";
            ps2.coursecount = a2.ToString();
            ps2.papercount = a21.ToString();
            ps2.score = (a2 * 0.4 + a21 * 0.6).ToString();
            ps3.teacherid = "1003";
            ps3.teachname = "阳飞兰";
            ps3.coursecount = a31.ToString();
            ps3.papercount = a31.ToString();
            ps3.score = (a3 * 0.4 + a31 * 0.6).ToString();
            ps4.teacherid = "1004";
            ps4.teachname = "素书白";
            ps4.coursecount = a4.ToString();
            ps4.papercount = a41.ToString();
            ps4.score = (a4 * 0.4 + a41 * 0.6).ToString(); 
            ps5.teacherid = "1005";
            ps5.teachname = "玄悦";
            ps5.coursecount = a5.ToString();
            ps5.papercount = a51.ToString();
            ps5.score = (a5 * 0.4 + a51 * 0.6).ToString(); 
            ps6.teacherid = "1006";
            ps6.teachname = "殷千秋";
            ps6.coursecount = a6.ToString();
            ps6.papercount = a61.ToString();
            ps6.score = (a6 * 0.4 + a61 * 0.6).ToString(); 
            ps7.teacherid = "1007";
            ps7.teachname = "天春雪";
            ps7.coursecount = a7.ToString();
            ps7.papercount = a71.ToString();
            ps7.score = (a7 * 0.4 + a71 * 0.6).ToString(); 
            ps8.teacherid = "1008";
            ps8.teachname = "仝从珊";
            ps8.coursecount = a8.ToString();
            ps8.papercount = a81.ToString();
            ps8.score = (a8 * 0.4 + a81 * 0.6).ToString(); 
            ps9.teacherid = "1009";
            ps9.teachname = "本秋柔";
            ps9.coursecount = a9.ToString();
            ps9.papercount = a91.ToString();
            ps9.score = (a9 * 0.4 + a91 * 0.6).ToString(); 
            ps10.teacherid = "1010";
            ps10.teachname = "戴泽民";
            ps10.coursecount = a10.ToString();
            ps10.papercount = a101.ToString();
            ps10.score = (a10 * 0.4 + a101 * 0.6).ToString();
            aList.Add(ps1);
            aList.Add(ps2);
            aList.Add(ps3);
            aList.Add(ps4);
            aList.Add(ps5); 
            aList.Add(ps6);
            aList.Add(ps7);
            aList.Add(ps8);
            aList.Add(ps9);
            aList.Add(ps10);
            datagrid3.ItemsSource = aList;
        }
        public struct GrourpValue
        {
            public string teacherid { get; set; }
            public string teachname { get; set; }
            public string coursecount { get; set; }
            public string papercount { get; set; }
            public string score { get; set; }
        }

        #endregion

        
    }

        
    }
