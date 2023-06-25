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

namespace 球鞋商城
{
    /// <summary>
    /// goumai.xaml 的交互逻辑
    /// </summary>
    public partial class goumai : Window
    {
        SqlConnection mycon = new SqlConnection(global.con);
        public goumai()
        {
            InitializeComponent();
            headimagefun();
            idlabel.Content = global.a;
        }
        void headimagefun()
        {
            string sqlstr = string.Format(@"select * from info where id='{0}'", global.a);
            mycon.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, global.con);
            DataTable dt = new DataTable();
            myda.Fill(dt);
            string image = Convert.ToString(dt.Rows[0]["image"]);
            headimage.Source = new BitmapImage(new Uri(image, UriKind.Relative));
            mycon.Close();
        }
        void x(int i)
        {
            global.b = i;
            jiagou jg = new jiagou();
            jg.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            x(1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            x(2);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            x(1);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            x(3);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            x(4);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            x(1);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            x(2);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            x(3);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            x(4);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            x(1);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            x(3);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            x(4);
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            x(1);
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            x(3);
        }
    }
}
