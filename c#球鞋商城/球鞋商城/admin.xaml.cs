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
    /// admin.xaml 的交互逻辑
    /// </summary>
    public partial class admin : Window
    {
        SqlConnection mycon = new SqlConnection(global.con);
        public admin()
        {
            InitializeComponent();
            dingdan();
            chaxun();
            shouhou();
        }
        void dingdan()
        {
            mycon.Open();
            string str = string.Format("SELECT * FROM [dbo].[car]");
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
        void chaxun()
        {
            mycon.Open();
            string str = string.Format("SELECT * FROM [dbo].[store]");
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
            adapter.Fill(ds, "store");
            if (dt == null)
            {
                dt = ds.Tables["store"];
            }
            datagrid2.ItemsSource = dt.DefaultView;
            mycon.Close();
        }

        private void btnxiugai_Click(object sender, RoutedEventArgs e)
        {
            mycon.Open();
            try
            {
                DataRowView mySelectedElement = (DataRowView)datagrid2.SelectedItem;
                string UpdateSqlCommand = string.Format(@"UPDATE [dbo].[store] SET [id] = {0}, [name] = '{1}', [num] = {2} WHERE [id] = {3}", Convert.ToInt32(mySelectedElement.Row[0]), Convert.ToString(mySelectedElement.Row[1]), Convert.ToInt32(mySelectedElement.Row[2]), Convert.ToInt32(mySelectedElement.Row[0]));
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
                DataRowView mySelectedElement = (DataRowView)datagrid2.SelectedItem;
                string UpdateSqlCommand = string.Format("insert into [dbo].[store] ([id],[name],[num]) values ({0},'{1}',{2})", Convert.ToInt32(mySelectedElement.Row[0]), Convert.ToString(mySelectedElement.Row[1]), Convert.ToInt32(mySelectedElement.Row[2]));
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
                DataRowView mySelectedElement = (DataRowView)datagrid2.SelectedItem;
                string DeleteSqlCommand = string.Format("delete from [dbo].[store] where id = {0}", Convert.ToInt32(mySelectedElement.Row[0]));
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

        private void datagrid2_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }
        void shouhou()
        {
            mycon.Open();
            string str = string.Format("SELECT * FROM [dbo].[shouhou]");
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
            adapter.Fill(ds, "shouhou");
            if (dt == null)
            {
                dt = ds.Tables["shouhou"];
            }
            datagrid3.ItemsSource = dt.DefaultView;
            mycon.Close();
        }
    }
}
