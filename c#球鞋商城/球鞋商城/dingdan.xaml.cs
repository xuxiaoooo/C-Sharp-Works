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
    /// dingdan.xaml 的交互逻辑
    /// </summary>
    public partial class dingdan : Window
    {
        SqlConnection mycon = new SqlConnection(global.con);
        public dingdan()
        {
            InitializeComponent();
            headimagefun();
            idlabel.Content = global.a;
            chaxun();
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
        void chaxun()
        {
            string str = string.Format("SELECT * FROM [dbo].[car] where [userid]='{0}' and [ispay]=1", global.a);
            SqlDataAdapter adapter = null;
            DataSet ds = null;
            DataTable dt = null;
            if (adapter == null)
            {
                adapter = new SqlDataAdapter(str, mycon);

            }
            if (ds == null)
            {
                ds = new System.Data.DataSet();
            }
            ds.Clear();
            adapter.Fill(ds, "car");
            if (dt == null)
            {
                dt = ds.Tables["car"];
            }
            datagrid1.ItemsSource = dt.DefaultView;
            mycon.Close();
        }
    }
}
