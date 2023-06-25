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
    /// stu.xaml 的交互逻辑
    /// </summary>
    public partial class stu : Window
    {
        static string con = "Server=localhost;Database=stuscorepublish;user id=sa;pwd=xuxiao";
        SqlConnection mycon = new SqlConnection(con);
        public stu()
        {
            InitializeComponent();
        }

        private void btncha_Click(object sender, RoutedEventArgs e)
        {
            string sqlstr = string.Format(@"select * from [dbo].[score] WHERE id={0};", global.a);
            mycon.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, con);
            DataTable dt = new DataTable();
            myda.Fill(dt);
            int yuwen =Convert.ToInt32( dt.Rows[0]["yuwen"]);
            int shuxue = Convert.ToInt32(dt.Rows[0]["shuxue"]);
            int yingyu = Convert.ToInt32(dt.Rows[0]["yingyu"]);
            labels.Content = "学号为：" + global.a + "的同学，成绩如下：\n\t语文：" + yuwen + "分\t数学：" + shuxue + "分\t英语：" + yingyu+"分";
            mycon.Close();
        }

        private void btnxiugai_Click(object sender, RoutedEventArgs e)
        {
            string sqlstr = string.Format(@"select password from [dbo].[user] WHERE id={0};", global.a);
            mycon.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, con);
            DataTable dt = new DataTable();
            myda.Fill(dt);
            string password = (dt.Rows[0]["password"]).ToString();
            mycon.Close();
            if (password == global.b)
            {
                if (ps2.Password == ps3.Password)
                {
                    string sqlstr1 = string.Format(@"UPDATE [dbo].[user] SET [password] = '{0}' WHERE [id] ={1};", ps2.Password.ToString(), global.a);
                    mycon.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = mycon;
                    cmd.CommandText = sqlstr1;
                    cmd.ExecuteNonQuery();
                    MessageBoxX.Show("修改成功", "提示");
                }
                else
                    MessageBoxX.Show("两次新密码输入不同", "错误");
            }
            else
                MessageBoxX.Show("原密码不正确","错误");
        }
    }
}
