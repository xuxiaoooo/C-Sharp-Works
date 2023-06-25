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
    /// shouhou.xaml 的交互逻辑
    /// </summary>
    public partial class shouhou : Window
    {
        SqlConnection mycon = new SqlConnection(global.con);
        public shouhou()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            string UpdateSqlCommand = string.Format(@"insert into [dbo].[shouhou]([userid],[content]) values('{0}','{1}')",global.a,tx.Text.ToString());
            SqlCommand cmd = new SqlCommand(UpdateSqlCommand, mycon);
            cmd.ExecuteNonQuery();
            MessageBoxX.Show("反馈成功，工作人员将在三个工作日内与您取得联系", "提示");
            mycon.Close();
        }
    }
}
