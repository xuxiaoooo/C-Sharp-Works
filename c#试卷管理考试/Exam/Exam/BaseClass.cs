using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Exam
{
    class BaseClass
    {
        public static SqlConnection DBCon()
        {
            //当换了电脑了，需要将下面的“DESKTOP-B8V7E97\\A”改成您自己的服务器名
            return new SqlConnection("Data Source=.;Initial Catalog=db_Exam;User ID=sa;password=xuxiao");//连接数据库
        }
        public static void Message(string a, string b)
        {
            MessageBox.Show(a,b,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
        public static void InsertData(string strSQL)
        {
            SqlConnection conn = DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL,conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Message("提示：添加成功！", "提示");
            }
            else
            {
                Message("提示：添加失败！","警告");
            }
            conn.Close();
        }

        public static void UpdateData(string strSQL)
        {
            SqlConnection conn = DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Message("提示：修改成功！", "提示");
            }
            else
            {
                Message("提示：修改失败！", "警告");
            }
            conn.Close();
        }

        public static void DeleteData(string strSQL)
        {
            SqlConnection conn = DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Message("提示：删除成功！", "提示");
            }
            else
            {
                Message("提示：删除失败！", "警告");
            }
            conn.Close();
        }
        public static void DataGridViewBind(DataGridView dgv,string strSQL)
        {
            SqlConnection conn = DBCon();
            SqlDataAdapter sda = new SqlDataAdapter(strSQL,conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }
    }
}
