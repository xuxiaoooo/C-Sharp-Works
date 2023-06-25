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

namespace 球鞋商城
{
    /// <summary>
    /// main.xaml 的交互逻辑
    /// </summary>
    public partial class main : Window
    {
        SqlConnection mycon = new SqlConnection(global.con);
        public main()
        {
            InitializeComponent();
            headimagefun();
            idlabel.Content = global.a;
        }
        void headimagefun()
        {
            string sqlstr = string.Format(@"select * from [dbo].[info] where [id]='{0}'",global.a);
            mycon.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, global.con);
            DataTable dt = new DataTable();
            myda.Fill(dt);
            string isnew = Convert.ToString(dt.Rows[0]["isnew"]);
            string image = Convert.ToString(dt.Rows[0]["image"]);
            global.d = Convert.ToInt32(dt.Rows[0]["minusmoney"]);
            headimage.Source = new BitmapImage(new Uri(image, UriKind.Relative));
            if (isnew == "1")
            {
                btnyouhui.Visibility = Visibility.Visible;
            }
            else if (isnew == "0")
            {
                btnyouhui.Visibility = Visibility.Collapsed;
            }
            mycon.Close();
        }

        private void btnyouhui_Click(object sender, RoutedEventArgs e)
        {
            btnyouhui.Visibility = Visibility.Collapsed;
            mycon.Open();
            string UpdateSqlCommand = string.Format(@"UPDATE [dbo].[info] SET [isnew] = '0',[minusmoney]=50 WHERE [id] = {0}",global.a);
            SqlCommand cmd = new SqlCommand(UpdateSqlCommand, mycon);
            cmd.ExecuteNonQuery();
            MessageBoxX.Show("领取成功", "提示");
            mycon.Close();
        }

        private void btngouwuche_Click(object sender, RoutedEventArgs e)
        {
            gouwuche g = new gouwuche();
            g.Show();
        }

        private void btngoumai_Click(object sender, RoutedEventArgs e)
        {
            goumai gm = new goumai();
            gm.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            shouhou sh = new shouhou();
            sh.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dingdan dd = new dingdan();
            dd.Show();
        }
    }
}
