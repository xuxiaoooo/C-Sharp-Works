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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HIS
{
    /// <summary>
    /// main.xaml 的交互逻辑
    /// </summary>
    public partial class main : Window
    {
        public main()
        {
            InitializeComponent();
            guahao.Visibility = Visibility.Collapsed;
            退号.Visibility = Visibility.Collapsed;
            shoufeigrid.Visibility = Visibility.Collapsed;
            chaxun1grid.Visibility = Visibility.Collapsed;
            chaxun2grid.Visibility = Visibility.Collapsed;
            chaxun3grid.Visibility = Visibility.Collapsed;
            系统维护grid.Visibility = Visibility.Collapsed;
        }
        static string constr = "server=localhost;user id=sa;pwd=xuxiao; database=his;";
        SqlConnection mycon = new SqlConnection(constr);
        SqlCommand mycmd = new SqlCommand();
        

        #region 挂号
        private void guahaobtn_Click(object sender, RoutedEventArgs e)
        {
            riqi.Content = "今天是 " + DateTime.Today.ToString();
            guahao.Visibility = Visibility.Visible;
            退号.Visibility = Visibility.Collapsed;
            shoufeigrid.Visibility = Visibility.Collapsed;
            chaxun1grid.Visibility = Visibility.Collapsed;
            chaxun2grid.Visibility = Visibility.Collapsed;
            chaxun3grid.Visibility = Visibility.Collapsed;
            系统维护grid.Visibility = Visibility.Collapsed;
        }
        #region MyRegion

        
        public void Choice(String keshi)
        {
            string sqlstr = string.Format(@"select [DEPART_ID] from [dbo].[depart] where [DEPART_NAME]='{0}'", keshi);
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr;
            mycmd.CommandType = CommandType.Text;
            SqlDataReader dr = mycmd.ExecuteReader();
            dr.Read();
            String a = dr["DEPART_ID"].ToString();
            mycon.Close();
            next(a);
        }
        public void next(string a)
        {
            SqlDataAdapter adapter = null;
            System.Data.DataSet ds = null;
            System.Data.DataTable dt = null;
            mycon.Open();
            if (adapter == null)
            {
                string sqlstr = string.Format(@"select [DNAME],[DLEVEL],[DSEX] from [dbo].[doctor] where [DEPART_ID]='{0}'", a);
                adapter = new SqlDataAdapter(sqlstr, mycon);
            }
            if (ds == null)
            {
                ds = new System.Data.DataSet();
            }
            ds.Clear();
            adapter.Fill(ds, "his.doctor");
            if (dt == null)
            {
                dt = ds.Tables["his.doctor"];
            }
            datagrid.ItemsSource = dt.DefaultView;
            mycon.Close();
        }
        #endregion
        private void datagridview_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        #region MyRegion
        private void yanke_Click(object sender, RoutedEventArgs e)
        {
            Choice("眼科");
        }

        private void erbihouke_Click(object sender, RoutedEventArgs e)
        {
            Choice("耳鼻喉科");
        }

        private void guwaike_Click(object sender, RoutedEventArgs e)
        {
            Choice("骨外科");
        }

        private void shenjingwaike_Click(object sender, RoutedEventArgs e)
        {
            Choice("神经外科");
        }

        private void xinxiongwaike_Click(object sender, RoutedEventArgs e)
        {
            Choice("心胸外科");
        }

        private void huxineike_Click(object sender, RoutedEventArgs e)
        {
            Choice("呼吸内科");
        }

        private void xiaohuaneike_Click(object sender, RoutedEventArgs e)
        {
            Choice("消化内科");
        }

        private void xinxueguanneike_Click(object sender, RoutedEventArgs e)
        {
            Choice("心血管内科");
        }

        private void chanke_Click(object sender, RoutedEventArgs e)
        {
            Choice("产科");
        }
        #endregion
        String pnum = Application.Current.Properties["a"].ToString();

        private void guahaodirectbtn_Click(object sender, RoutedEventArgs e)
        {
            
            mycon.Open();
            string sqlstr = string.Format(@"INSERT INTO [dbo].[sheet] ([SHEET_ID], [TIME], [DNO], [RNO], [REMARK], [PNO]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", sheetid.Text.ToString(), datetimepicker.SelectedDateTime, result1,pnum,beizhu.Text.ToString(),pno.Text.ToString());
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr;
            mycmd.CommandType = CommandType.Text;
            int result = mycmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("挂号成功");
            }
            else
            { MessageBox.Show("挂号失败"); }
            mycon.Close();
        }
        string result = null;
        string result1 = null;
        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView mySelectedElement = (DataRowView)datagrid.SelectedItem;
            result = mySelectedElement.Row[0].ToString();
            string sqlstr1 = string.Format(@"select [DNO] from [dbo].[doctor] where [DNAME]='{0}'", result);
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr1;
            mycmd.CommandType = CommandType.Text;
            SqlDataReader dr = mycmd.ExecuteReader();
            dr.Read();
            String result1 = dr["DNO"].ToString();
            mycon.Close();
        }

        #endregion
        #region 退号
        private void tuihao_Click(object sender, RoutedEventArgs e)
        {
            退号.Visibility = Visibility.Visible;
            guahao.Visibility = Visibility.Collapsed;
            shoufeigrid.Visibility = Visibility.Collapsed;
            chaxun1grid.Visibility = Visibility.Collapsed;
            chaxun2grid.Visibility = Visibility.Collapsed;
            chaxun3grid.Visibility = Visibility.Collapsed;
            系统维护grid.Visibility = Visibility.Collapsed;
        }

        private void tuihaobtn_Click(object sender, RoutedEventArgs e)
        {
            if (guahaobianhao.Text.Equals(""))
            {
                MessageBox.Show("请填写需要退号的挂号编号！");
            }
            else
            {
                string sqlstr = string.Format(@"INSERT INTO [dbo].[return] ( [SHEET_ID], [R_TIME]) VALUES ('{0}', '{1}')", guahaobianhao.Text.ToString(), DateTime.Now);
                mycon.Open();
                mycmd.Connection = mycon;
                mycmd.CommandText = sqlstr;
                mycmd.CommandType = CommandType.Text;
                int result = mycmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("退号成功！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    if (MessageBox.Show("退号失败！", "提示", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        guahaobianhao.Text = "";
                    }
                }
                mycon.Close();
            }
        }

        #endregion
        #region 收费
        private void shoufei_Click(object sender, RoutedEventArgs e)
        {
            shoufeigrid.Visibility = Visibility.Visible;
            guahao.Visibility = Visibility.Collapsed;
            退号.Visibility = Visibility.Collapsed;
            chaxun1grid.Visibility = Visibility.Collapsed;
            chaxun2grid.Visibility = Visibility.Collapsed;
            chaxun3grid.Visibility = Visibility.Collapsed;
            系统维护grid.Visibility = Visibility.Collapsed;
        }
        string payway = null;
        private void shoufeibtn_Click(object sender, RoutedEventArgs e)
        {
            string a = chufanghao.Text.ToString();
            string b = bingrenbianhao.Text.ToString();
            string c = yishengbianhao.Text.ToString();
            double d = Convert.ToDouble(yaopinhuafei.Text.ToString());
            double ee = Convert.ToDouble(wenzhenfeiyong.Text.ToString());
            double f = d+ee;
            string sqlstr = string.Format(@"INSERT INTO [dbo].[pay_cost] ( [P_NO], [PNO],[DNO],[DRUG_COST],[CHECK_COST],[PAY_WAY],[TOTAL_COST]) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}')", a,b,c,d,ee,payway,f);
            mycon.Open();
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr;
            mycmd.CommandType = CommandType.Text;
            int result = mycmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("支付成功！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                chufanghao.Text = "";
                bingrenbianhao.Text = "";
                yishengbianhao.Text = "";
                yaopinhuafei.Text = "";
                wenzhenfeiyong.Text = "";
                zhifufangshi.SelectedIndex = -1;
            }
            else
            {
                if (MessageBox.Show("支付失败！", "提示", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    chufanghao.Text = "";
                    bingrenbianhao.Text = "";
                    yishengbianhao.Text = "";
                    yaopinhuafei.Text = "";
                    wenzhenfeiyong.Text = "";
                    zhifufangshi.SelectedIndex = -1;
                }
            }
            mycon.Close();

        }
        private void zhifubao_Click(object sender, RoutedEventArgs e)
        {
            payway = "支付宝";
            zhifufangshi.SelectedIndex = 0;
        }

        private void weixin_Click(object sender, RoutedEventArgs e)
        {
            payway = "微信支付";
            zhifufangshi.SelectedIndex = 1;
        }

        private void yinhangka_Click(object sender, RoutedEventArgs e)
        {
            payway = "银行卡支付";
            zhifufangshi.SelectedIndex = 2;
        }
        private void wenzhenfeiyong_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!yaopinhuafei.Text.Equals("") && !wenzhenfeiyong.Text.Equals(""))
            {
                总费用.Content = "总费用：  " + (Convert.ToDouble(yaopinhuafei.Text.ToString()) + Convert.ToDouble(wenzhenfeiyong.Text.ToString())).ToString("0.00");
            }
            else
                总费用.Content = "";
        }
        #endregion

        #region 统计查询
        private void chaxun1_Click(object sender, RoutedEventArgs e)
        {
            chaxun1grid.Visibility = Visibility.Visible;
            chaxun3grid.Visibility = Visibility.Collapsed;
            chaxun2grid.Visibility = Visibility.Collapsed;
            guahao.Visibility = Visibility.Collapsed;
            退号.Visibility = Visibility.Collapsed;
            shoufeigrid.Visibility = Visibility.Collapsed;
            系统维护grid.Visibility = Visibility.Collapsed;
            SqlDataAdapter adapter = null;
            System.Data.DataSet ds = null;
            System.Data.DataTable dt = null;
            mycon.Open();
            if (adapter == null)
            {
                adapter = new SqlDataAdapter("SELECT [PNO],[ID_NO],[PNAME],[PAGE],[PSEX],[PHONE],[ADDRESS] FROM [dbo].[patient];", mycon);
            }
            if (ds == null)
            {
                ds = new System.Data.DataSet();
            }
            ds.Clear();
            adapter.Fill(ds, "patient");
            if (dt == null)
            {
                dt = ds.Tables["patient"];
            }
            bingrendatagrid.ItemsSource = dt.DefaultView;
            mycon.Close();
        }

        private void chaxun2_Click(object sender, RoutedEventArgs e)
        {
            chaxun2grid.Visibility = Visibility.Visible;
            chaxun1grid.Visibility = Visibility.Collapsed;
            chaxun3grid.Visibility = Visibility.Collapsed;
            guahao.Visibility = Visibility.Collapsed;
            退号.Visibility = Visibility.Collapsed;
            shoufeigrid.Visibility = Visibility.Collapsed;
            系统维护grid.Visibility = Visibility.Collapsed;
            SqlDataAdapter adapter =null;
            System.Data.DataSet ds = null;
            System.Data.DataTable dt = null;
            mycon.Open();
            if (adapter == null)
            {
                adapter = new SqlDataAdapter("SELECT [DNO],[DNAME],[DAGE],[DSEX],[DEPART_ID],[DLEVEL] FROM [dbo].[doctor];", mycon);
            }
            if (ds == null)
            {
                ds = new System.Data.DataSet();
            }
            ds.Clear();
            adapter.Fill(ds, "doctor");
            if (dt == null)
            {
                dt = ds.Tables["doctor"];
            }
            yishengdatagrid.ItemsSource = dt.DefaultView;
            mycon.Close();
        }

        public SeriesCollection SeriesCollection { get; set; }
        public SeriesCollection SeriesCollection1 { get; set; }
        private void chaxun3_Click(object sender, RoutedEventArgs e)
        {
            chaxun3grid.Visibility = Visibility.Visible;
            chaxun1grid.Visibility = Visibility.Collapsed;
            chaxun2grid.Visibility = Visibility.Collapsed;
            guahao.Visibility = Visibility.Collapsed;
            退号.Visibility = Visibility.Collapsed;
            shoufeigrid.Visibility = Visibility.Collapsed;
            系统维护grid.Visibility = Visibility.Collapsed;
            mycon.Open();
            string sqlstr = string.Format(@"SELECT sum([DRUG_COST]) as DRUG_COST,sum([CHECK_COST]) as CHECK_COST FROM [dbo].[pay_cost] where [PAY_WAY]='支付宝';");
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr;
            mycmd.CommandType = CommandType.Text;
            SqlDataReader dr = mycmd.ExecuteReader();
            dr.Read();
            double z1 = Convert.ToDouble(dr["DRUG_COST"]);
            double z2= Convert.ToDouble(dr["CHECK_COST"]);
            mycon.Close();
            mycon.Open();
            string sqlstr1 = string.Format(@"SELECT sum([DRUG_COST]) as DRUG_COST,sum([CHECK_COST]) as CHECK_COST FROM [dbo].[pay_cost] where [PAY_WAY]='微信支付';");
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr1;
            mycmd.CommandType = CommandType.Text;
            SqlDataReader dr1 = mycmd.ExecuteReader();
            dr1.Read();
            double w1 = Convert.ToDouble(dr1["DRUG_COST"]);
            double w2 = Convert.ToDouble(dr1["CHECK_COST"]);
            mycon.Close();
            mycon.Open();
            string sqlstr2 = string.Format(@"SELECT sum([DRUG_COST]) as DRUG_COST,sum([CHECK_COST]) as CHECK_COST FROM [dbo].[pay_cost] where [PAY_WAY]='银行卡';");
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr2;
            mycmd.CommandType = CommandType.Text;
            SqlDataReader dr2 = mycmd.ExecuteReader();
            dr2.Read();
            double y1 = Convert.ToDouble(dr2["DRUG_COST"]);
            double y2 = Convert.ToDouble(dr2["CHECK_COST"]);
            mycon.Close();
            SeriesCollection = new SeriesCollection
            {
                    new PieSeries
                    {
                        Title = "支付宝",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(z1) },
                        DataLabels = true
                    },
                    new PieSeries
                    {
                        Title = "微信支付",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(w1) },
                        DataLabels = true
                    },
                    new PieSeries
                    {
                        Title = "银行卡",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(y1) },
                        DataLabels = true
                    }
            };
            SeriesCollection1 = new SeriesCollection
            {
                    new PieSeries
                    {
                        Title = "支付宝",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(z2) },
                        DataLabels = true
                    },
                    new PieSeries
                    {
                        Title = "微信支付",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(w2) },
                        DataLabels = true
                    },
                    new PieSeries
                    {
                        Title = "银行卡",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(y2) },
                        DataLabels = true
                    }
            };
            DataContext = this;
        }
        #endregion
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            guahao.Visibility = Visibility.Collapsed;
            退号.Visibility = Visibility.Collapsed;
            shoufeigrid.Visibility = Visibility.Collapsed;
            chaxun1grid.Visibility = Visibility.Collapsed;
            chaxun2grid.Visibility = Visibility.Collapsed;
            chaxun3grid.Visibility = Visibility.Collapsed;
            系统维护grid.Visibility = Visibility.Collapsed;
            foreach (var item in tree.Items)
            {
                DependencyObject dObject = tree.ItemContainerGenerator.ContainerFromItem(item);
                CollapseTreeviewItems(((TreeViewItem)dObject));
            }
        }
        private void CollapseTreeviewItems(TreeViewItem Item)
        {
            Item.IsExpanded = false;

            foreach (var item in Item.Items)
            {
                DependencyObject dObject = tree.ItemContainerGenerator.ContainerFromItem(item);

                if (dObject != null)
                {
                    ((TreeViewItem)dObject).IsExpanded = false;

                    if (((TreeViewItem)dObject).HasItems)
                    {
                        CollapseTreeviewItems(((TreeViewItem)dObject));
                    }
                }
            }
        }
        #region 系统维护

        private void xitongweihu_Click(object sender, RoutedEventArgs e)
        {
            系统维护grid.Visibility = Visibility.Visible;
            guahao.Visibility = Visibility.Collapsed;
            退号.Visibility = Visibility.Collapsed;
            shoufeigrid.Visibility = Visibility.Collapsed;
            chaxun1grid.Visibility = Visibility.Collapsed;
            chaxun2grid.Visibility = Visibility.Collapsed;
            chaxun3grid.Visibility = Visibility.Collapsed;

        }

        private void fankuibtn_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            string sqlstr = string.Format(@"INSERT INTO [dbo].[fankui] ([fankui_content]) VALUES ('{0}');", textbox.Text.ToString());
            mycmd.Connection = mycon;
            mycmd.CommandText = sqlstr;
            mycmd.CommandType = CommandType.Text;
            int result = mycmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("反馈成功");
            }
            else
            { MessageBox.Show("反馈失败"); }
            mycon.Close();
        }

        #endregion
    }
}
