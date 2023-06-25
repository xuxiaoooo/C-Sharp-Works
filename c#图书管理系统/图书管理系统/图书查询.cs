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
    public partial class 图书查询 : Form
    {
        public 图书查询()
        {
            InitializeComponent();
            DBHelper dbHelper = new DBHelper();
            string sql = string.Format(@"select * from [dbo].[book];");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "book");
            this.dataGridView2.DataSource = ds.Tables["book"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string state = "";
            if (comboBox1.SelectedIndex == 0) state = "bookname";
            else if (comboBox1.SelectedIndex == 1) state = "author";
            else if (comboBox1.SelectedIndex == 2) state = "press";
            DBHelper dbHelper = new DBHelper();
            string sql = string.Format(@"select * from [dbo].[book] where [{0}]='{1}';",state,textBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "book");
            this.dataGridView1.DataSource = ds.Tables["book"];
        }


    }
}
