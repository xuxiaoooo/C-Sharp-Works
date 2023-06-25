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
    public partial class 用户修改与删除 : Form
    {
        public 用户修改与删除()
        {
            InitializeComponent();
            chaxun();
        }
        void chaxun()
        {
            DBHelper dbHelper = new DBHelper();
            string sql = string.Format(@"select * from [dbo].[operator] ");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "operator");
            this.dataGridView1.DataSource = ds.Tables["operator"];
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                label9.Text = dataGridView1.CurrentRow.Cells["no"].Value.ToString();
                this.textBox1.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                this.textBox2.Text = dataGridView1.CurrentRow.Cells["age"].Value.ToString();
                this.textBox3.Text = dataGridView1.CurrentRow.Cells["phone"].Value.ToString();
                this.textBox4.Text = dataGridView1.CurrentRow.Cells["idcard"].Value.ToString();
                this.textBox5.Text = dataGridView1.CurrentRow.Cells["code"].Value.ToString();
                this.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["workdate"].Value);
                if (dataGridView1.CurrentRow.Cells["sex"].Value.ToString() == "男") comboBox1.SelectedIndex = 0;
                else if (dataGridView1.CurrentRow.Cells["sex"].Value.ToString() == "女") comboBox1.SelectedIndex = 1;
                if (dataGridView1.CurrentRow.Cells["isadmin"].Value.ToString() == "1") comboBox2.SelectedIndex = 0;
                else if (dataGridView1.CurrentRow.Cells["isadmin"].Value.ToString() == "0") comboBox2.SelectedIndex = 1;
            }
            catch
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (comboBox1.SelectedIndex == 0) sex = "男";
            else if (comboBox1.SelectedIndex == 1) sex = "女";
            string isadmin = "";
            if (comboBox2.SelectedIndex == 0) isadmin = "1";
            else if (comboBox2.SelectedIndex == 1) isadmin = "0";
            string sql = string.Format(@"update [dbo].[operator] set [name]='{0}',[sex]='{1}',[age]='{2}',[phone]='{3}',[idcard]='{4}',[isadmin]='{5}',[workdate]='{6}',[code]='{7}' where [no]='{8}';", textBox1.Text,sex,Convert.ToInt32( textBox2.Text), textBox3.Text, textBox4.Text,isadmin, dateTimePicker1.Value, textBox5.Text, label9.Text);
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
            chaxun();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"delete from [dbo].[operator] where [no]='{0}';", label9.Text);
            DBHelper dbHelper = new DBHelper();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                dbHelper.OpenConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功");
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
