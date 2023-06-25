using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 面包销售
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            show();
            show1();
        }
        void show()
        {
            DBHelper dbHelper = new DBHelper();
            string sql = string.Format(@"select * from [dbo].[info] where [num]>0;");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "info");
            this.dgv_1.DataSource = ds.Tables["info"];
            this.dgv_2.DataSource= ds.Tables["info"];
        }
        void show1()
        {
            DBHelper dbHelper = new DBHelper();
            string sql = string.Format(@"select * from [dbo].[sale];");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "sale");
            this.dgv_3.DataSource = ds.Tables["sale"];
        }
        private void btnsell_Click(object sender, EventArgs e)
        {
            if (dgv_1.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择面包种类");
            }
            else
            {
                if (Convert.ToInt32(dgv_1.SelectedRows[0].Cells[2].Value) < Convert.ToInt32(tb.Text))
                {
                    MessageBox.Show("库存不足");
                }
                else
                {
                    Random ran = new Random();
                    string id = DBHelper.a + DateTime.Now.ToString("yyyyMMddHHmmss") + ran.Next(999);
                    string sql = string.Format(@"insert into [dbo].[sale] ([id],[name],[num],[time],[salerid],[price]) values('{0}','{1}',{2},'{3}','{4}','{5}');update [dbo].[info] set num=num-{6} where [id]='{7}';", id, dgv_1.SelectedRows[0].Cells[1].Value.ToString(), Convert.ToInt32(tb.Text), DateTime.Now, DBHelper.a,Convert.ToDecimal(dgv_1.SelectedRows[0].Cells[3].Value)*Convert.ToInt32(tb.Text), Convert.ToInt32(tb.Text), Convert.ToInt32(dgv_1.SelectedRows[0].Cells[0].Value));
                    DBHelper dbHelper = new DBHelper();
                    try
                    {
                        SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                        dbHelper.OpenConnection();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("出库成功");
                        dbHelper.CloseConnection();
                        show();
                        show1();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (dgv_2.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择面包种类");
            }
            else
            {
                if (Convert.ToInt32(tb2.Text)<1)
                {
                    MessageBox.Show("数量错误");
                }
                else
                {
                    string sql = string.Format(@"update [dbo].[info] set num=num+{0} where [id]='{1}';", Convert.ToInt32(tb2.Text), Convert.ToInt32(dgv_2.SelectedRows[0].Cells[0].Value));
                    DBHelper dbHelper = new DBHelper();
                    try
                    {
                        SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                        dbHelper.OpenConnection();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("入库成功");
                        dbHelper.CloseConnection();
                        show();
                        show1();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBHelper.b1 = dgv_3.SelectedRows[0].Cells[0].Value.ToString();
            DBHelper.b2 = dgv_3.SelectedRows[0].Cells[1].Value.ToString();
            DBHelper.b3 = dgv_3.SelectedRows[0].Cells[2].Value.ToString();
            DBHelper.b4 = dgv_3.SelectedRows[0].Cells[3].Value.ToString();
            DBHelper.b5 = dgv_3.SelectedRows[0].Cells[4].Value.ToString();
            DBHelper.b6 = dgv_3.SelectedRows[0].Cells[5].Value.ToString();
            order od = new order();
            od.Show();
        }
    }
}

