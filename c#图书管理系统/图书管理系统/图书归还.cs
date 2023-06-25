using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class 图书归还 : Form
    {
        public 图书归还()
        {
            InitializeComponent();
            chaxun();
        }
        void chaxun()
        {
            DBHelper dbHelper = new DBHelper();
            string sql = string.Format(@"select * from [dbo].[borrowinfo] where [isreturned]='0';");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "borrowinfo");
            dataGridView1.DataSource = ds.Tables["borrowinfo"];
        }
        int nono=-1;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            nono=Convert.ToInt32( dataGridView1.CurrentRow.Cells["no"].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nono == -1)
            {
                MessageBox.Show("请选择要归还的书籍");
            }
            else
            {
                string sql = string.Format(@"update [dbo].[borrowinfo] set [isreturned]='1',[returntime]='{0}' where [no]='{1}';",DateTime.Now, nono);
                DBHelper dbHelper = new DBHelper();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                    dbHelper.OpenConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("归还成功");
                    dbHelper.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                chaxun();
            }
        }
    }
}
