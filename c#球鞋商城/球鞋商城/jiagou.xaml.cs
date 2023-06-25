using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
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

namespace 球鞋商城
{
    /// <summary>
    /// jiagou.xaml 的交互逻辑
    /// </summary>
    public partial class jiagou : Window
    {
        SqlConnection mycon = new SqlConnection(global.con);
        public jiagou()
        {
            InitializeComponent();
            if (global.b == 1)
            {
                ima.Source = new BitmapImage(new Uri("../x1.jpg", uriKind: UriKind.Relative));
                price.Content = "价格是：799";
                global.c = 799;
                name = "NIKO奥利奥限定";
            }
            else if (global.b == 2)
            {
                ima.Source = new BitmapImage(new Uri("../x2.jpg", uriKind: UriKind.Relative));
                price.Content = "价格是：699";
                global.c = 699;
                name = "NIKO绿钩足球鞋";
            }
            else if (global.b == 3)
            {
                ima.Source = new BitmapImage(new Uri("../x3.jpg", uriKind: UriKind.Relative));
                price.Content = "价格是：499";
                global.c = 499;
                name = "匡威兔八哥限定";
            }
            else if (global.b == 4)
            {
                ima.Source = new BitmapImage(new Uri("../x4.jpg", uriKind: UriKind.Relative));
                price.Content = "价格是：999";
                global.c = 999;
                name = "Abibas关羽限定";
            }
        }
        string name;
        private void btnjiagou_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            string UpdateSqlCommand = string.Format(@"insert into [dbo].[car]([name],[size],[price],[userid]) values('{0}',{1},{2},'{3}')",name,Convert.ToInt32( cbsize.Text),global.c, global.a);
            SqlCommand cmd = new SqlCommand(UpdateSqlCommand, mycon);
            cmd.ExecuteNonQuery();
            MessageBoxX.Show("加入购物车成功", "提示");
            mycon.Close();
        }
    }
}
