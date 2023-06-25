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
    public partial class 图书信息修改 : Form
    {
        public 图书信息修改()
        {
            InitializeComponent();
            DBHelper dbHelper = new DBHelper();
            string sql = string.Format(@"select * from [dbo].[book] ");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "book");
            this.dataGridView1.DataSource = ds.Tables["book"];
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label1.Text = dataGridView1.CurrentRow.Cells["bno"].Value.ToString();
            this.textBox1.Text = dataGridView1.CurrentRow.Cells["kno"].Value.ToString();
            this.textBox2.Text = dataGridView1.CurrentRow.Cells["bookname"].Value.ToString();
            this.textBox3.Text = dataGridView1.CurrentRow.Cells["author"].Value.ToString();
            this.textBox4.Text = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
            this.textBox5.Text = dataGridView1.CurrentRow.Cells["press"].Value.ToString();
            this.textBox6.Text = dataGridView1.CurrentRow.Cells["translator"].Value.ToString();
            this.dateTimePicker1.Value =Convert.ToDateTime( dataGridView1.CurrentRow.Cells["publishtime"].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"update [dbo].[book] set [kno]='{0}',[bookname]='{1}',[author]='{2}',[price]='{3}',[publishtime]='{4}',[press]='{5}',[translator]='{6}' where [bno]='{7}';", textBox1.Text, textBox2.Text,textBox3.Text, Convert.ToDecimal(textBox4.Text),dateTimePicker1.Value,textBox5.Text,textBox6.Text, label1.Text);
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
