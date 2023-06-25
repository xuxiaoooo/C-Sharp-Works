using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Course_Design
{

    public partial class staff : Sunny.UI.UIForm
    {
        string myindex, myname, mydepartment;

        public staff()
        {
            InitializeComponent();
        }

        public staff(string index, string name, string department)
        {
            InitializeComponent();
            this.myindex = index;
            this.myname = name;
            this.mydepartment = department;

            name_label.Text = myname;
            index_label.Text = myindex;
            department_label.Text = mydepartment;
        }

        private int DateDiff(DateTime dateStart, DateTime dateEnd)
        {
            DateTime start = Convert.ToDateTime(dateStart.ToShortDateString());
            DateTime end = Convert.ToDateTime(dateEnd.ToShortDateString());
            TimeSpan sp = end.Subtract(start);
            return sp.Days;
        }

        public void load_pass()
        {
            string sql;
            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            sql = "Select * from 请假信息 where 员工编号='{0}' and 确认标志= 1";
            sql = string.Format(sql, myindex);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;

            conn.Close();
        }

        public void load_all()
        {
            string sql;
            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            sql = "Select * from 请假信息 where 员工编号='{0}'";
            sql = string.Format(sql, myindex);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;

            conn.Close();
        }

        public void load_del()
        {
            string sql;
            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            sql = "DELETE FROM 请假信息 WHERE 请假日期 = '{0}' and 请假类型编号 = '{1}' and 请假开始时间 = '{2}' and 请假结束时间 = '{3}'";
            sql = string.Format(sql, dataGridView3.Rows[0].Cells[0].Value, dataGridView3.Rows[0].Cells[1].Value, dataGridView3.Rows[0].Cells[2].Value, dataGridView3.Rows[0].Cells[3].Value);
            SqlCommand cmd = new SqlCommand(sql, conn);

            int result = cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void load_del_show()
        {
            string sql;
            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            sql = "Select 请假日期,请假类型编号 类型, 请假开始时间 开始时间,请假结束时间 结束时间 from 请假信息 where 员工编号='{0}'and 确认标志= 0";
            sql = string.Format(sql, myindex);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            //dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;


            conn.Close();
        }



        public void load_add()
        {
            string in_index, in_reason, sql;
            int in_days, in_type, in_count;
            string in_date, in_begin, in_end;

            in_index = myindex;
            in_date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            in_begin = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            in_end = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            in_type = comboBox1.SelectedIndex + 1;
            in_reason = textBox7.Text;
            in_count = int.Parse(textBox1.Text);

            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            sql = "INSERT INTO 请假信息 VALUES ('{0}', '{1}', {2}, '{3}', '{4}', {5}, '{6}', 0, '')";
            sql = string.Format(sql, in_index, in_date, in_type, in_begin, in_end, in_count, in_reason);
            SqlCommand cmd = new SqlCommand(sql, conn);

            int result = cmd.ExecuteNonQuery();
            if (result == 1 || result == 0)
            {
                MessageBox.Show("提交失败,请重新输入");
            }
            else
            {
                MessageBox.Show("成功提交" + (result/2) + "条申请");
            }
            conn.Close();
        }

        public void update_passwd()
        {
            string sql, old_pass, new_pass;

            old_pass = uiTextBox1.Text;
            new_pass = uiTextBox2.Text;

            if (uiTextBox2.Text != uiTextBox3.Text)
            {
                MessageBox.Show("两次密码不一致,请重新输入!");
                return ;
            }

            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            sql = "UPDATE 普通员工信息 SET 密码 = '{0}' WHERE 员工编号 = '{1}' AND 密码 = '{2}'";
            sql = string.Format(sql, new_pass, myindex, old_pass);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();

            if (result == 0)
            {
                MessageBox.Show("原密码错误");
            }else
            {
                MessageBox.Show("修改成功!");
            }
        }


        private void staff_Load(object sender, EventArgs e)
        {
            load_pass();
            load_all();
            load_del_show();
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            dataGridView3.ReadOnly = true;
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
            dateTimePicker3.MinDate = DateTime.Today;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker3.Value;
            textBox1.Text = DateDiff(dateTimePicker3.Value, dateTimePicker2.Value).ToString();
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = DateDiff(dateTimePicker3.Value, dateTimePicker2.Value).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_add();
            load_all();
            load_del_show();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            update_passwd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //撤销
        private void button3_Click_1(object sender, EventArgs e)
        {
            load_del();
            load_all();
            load_del_show();
        }
    }
}
