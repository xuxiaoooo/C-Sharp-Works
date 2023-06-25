using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课程表
{
    public partial class Form1 : Form
    {
        public static Form1 frm1;
        public Form1()
        {
            InitializeComponent();
            frm1 = this;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "第一节";
            dataGridView1.Rows[1].Cells[0].Value = "第二节";
            dataGridView1.Rows[2].Cells[0].Value = "第三节";
            dataGridView1.Rows[3].Cells[0].Value = "第四节";
            dataGridView1.Rows[4].Cells[0].Value = "第五节";
            dataGridView1.Rows[5].Cells[0].Value = "第六节";
            dataGridView1.Rows[6].Cells[0].Value = "第七节";
            dataGridView1.Rows[7].Cells[0].Value = "第八节";
            searchall();
        }
        void chaxun(int a,int b)
        {
            string sql = string.Format(@"select * from [dbo].[schedule] where [weekday]='{0}' and [classtime]='{1}';",a.ToString(),b.ToString());
            DBHelper dbHelper = new DBHelper();
            SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
            dbHelper.OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dataGridView1.Rows[b-1].Cells[a].Value = dr["name"].ToString();
            }
            else
            {
                dataGridView1.Rows[b-1].Cells[a].Value = "";
            }
            dbHelper.CloseConnection();
        }
        public void searchall()
        {
            chaxun(1, 1);
            chaxun(1, 2);
            chaxun(1, 3);
            chaxun(1, 4);
            chaxun(1, 5);
            chaxun(1, 6);
            chaxun(1, 7);
            chaxun(1, 8);
            chaxun(2, 1);
            chaxun(2, 2);
            chaxun(2, 3);
            chaxun(2, 4);
            chaxun(2, 5);
            chaxun(2, 6);
            chaxun(2, 7);
            chaxun(2, 8);
            chaxun(3, 1);
            chaxun(3, 2);
            chaxun(3, 3);
            chaxun(3, 4);
            chaxun(3, 5);
            chaxun(3, 6);
            chaxun(3, 7);
            chaxun(3, 8);
            chaxun(4, 1);
            chaxun(4, 2);
            chaxun(4, 3);
            chaxun(4, 4);
            chaxun(4, 5);
            chaxun(4, 6);
            chaxun(4, 7);
            chaxun(4, 8);
            chaxun(5, 1);
            chaxun(5, 2);
            chaxun(5, 3);
            chaxun(5, 4);
            chaxun(5, 5);
            chaxun(5, 6);
            chaxun(5, 7);
            chaxun(5, 8);
            chaxun(6, 1);
            chaxun(6, 2);
            chaxun(6, 3);
            chaxun(6, 4);
            chaxun(6, 5);
            chaxun(6, 6);
            chaxun(6, 7);
            chaxun(6, 8);
            chaxun(7, 1);
            chaxun(7, 2);
            chaxun(7, 3);
            chaxun(7, 4);
            chaxun(7, 5);
            chaxun(7, 6);
            chaxun(7, 7);
            chaxun(7, 8);
            paixu1();
            paixu2();
        }
        void paixu1()
        {
            string sql = string.Format(@"SELECT TOP 1 COUNT(*) as number,[name] FROM schedule GROUP BY [name];");
            DBHelper dbHelper = new DBHelper();
            SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
            dbHelper.OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label4.Text ="本周课时最多的课程为："+dr["name"].ToString()+"  共"+dr["number"].ToString()+"节";
            }
            else
            {
                
            }
            dbHelper.CloseConnection();
        }
        void paixu2()
        {
            string sql = string.Format(@"SELECT TOP 1 COUNT(*) as number,[weekday] FROM schedule GROUP BY [weekday];");
            DBHelper dbHelper = new DBHelper();
            SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
            dbHelper.OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label5.Text = "本周课时最多的那一天为星期" + dr["weekday"].ToString() + "  共" + dr["number"].ToString() + "节";
            }
            else
            {

            }
            dbHelper.CloseConnection();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex==-1)
            {
                label3.Text = "当前状态：无课程信息";
            }
            else
            {
                labeltext();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                label3.Text = "当前状态：无课程信息";
            }
            else
            {
                labeltext();
            }
        }
        public void labeltext()
        {
            string sql = string.Format(@"select * from [dbo].[schedule] where [weekday]='{0}' and [classtime]='{1}';", (comboBox1.SelectedIndex + 1).ToString(), (comboBox2.SelectedIndex + 1).ToString());
            DBHelper dbHelper = new DBHelper();
            SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
            dbHelper.OpenConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = "当前状态：" + dr["name"].ToString();
            }
            else
            {
                label3.Text = "当前状态：无课程信息";
            }
            dbHelper.CloseConnection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label3.Text == "当前状态：无课程信息")
            {
                添加 tj = new 添加();
                tj.Show();
                DBHelper.a = comboBox1.SelectedIndex + 1;
                DBHelper.b = comboBox2.SelectedIndex + 1;
            }
            else
                MessageBox.Show("当前时段已有课程！");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label3.Text == "当前状态：无课程信息")
            {
                MessageBox.Show("当前时段没有可更新课程！");
            }
            else
            {
                更新 gx = new 更新();
                gx.Show();
                DBHelper.a = comboBox1.SelectedIndex + 1;
                DBHelper.b = comboBox2.SelectedIndex + 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "当前状态：无课程信息")
            {
                MessageBox.Show("当前时段没有可删除课程！");
            }
            else
            {
                DBHelper.a = comboBox1.SelectedIndex + 1;
                DBHelper.b = comboBox2.SelectedIndex + 1;
                string sql = string.Format(@"delete from [dbo].[schedule] where [weekday]='{0}' and [classtime]='{1}';", DBHelper.a, DBHelper.b);
                DBHelper dbHelper = new DBHelper();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                    dbHelper.OpenConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除成功");
                    dbHelper.CloseConnection();
                    labeltext();
                    searchall();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
