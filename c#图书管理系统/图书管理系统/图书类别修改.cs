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
    public partial class 图书类别修改 : Form
    {
        public 图书类别修改()
        {
            InitializeComponent();
            DBHelper dbHelper = new DBHelper();
            string sql = string.Format(@"select * from [dbo].[bookkind] ");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "bookkind");
            this.dataGridView1.DataSource = ds.Tables["bookkind"];
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                label4.Text= dataGridView1.CurrentRow.Cells["no"].Value.ToString();
                this.textBox1.Text = dataGridView1.CurrentRow.Cells["kindname"].Value.ToString();
                this.textBox2.Text = dataGridView1.CurrentRow.Cells["canborrowdate"].Value.ToString();
                this.textBox3.Text = dataGridView1.CurrentRow.Cells["penalty"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"update [dbo].[bookkind] set [kindname]='{0}',[canborrowdate]='{1}',[penalty]='{2}' where [no]='{3}';", textBox1.Text, textBox2.Text,Convert.ToDecimal(textBox3.Text),label4.Text);
            DBHelper dbHelper = new DBHelper();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                dbHelper.OpenConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("更新成功");
                dbHelper.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
