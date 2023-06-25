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

namespace 大学生课程学习管理与成绩评价系统
{
    public partial class 教师系统 : Form
    {
        public 教师系统()
        {
            InitializeComponent();
            panel1.Visible = false;//初始化隐藏两个panel控件内容
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)//学生信息管理按钮
        {
            panel1.Visible = true;
            panel2.Visible = false;//对应panel可见
            search();//调用查询学生信息函数
        }
        void search()
        {
            DBHelper dbHelper = new DBHelper();
            string sql = string.Format(@"select * from [dbo].[Student];");//查询所有学生的信息
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Student");
            this.dataGridView1.DataSource = ds.Tables["Student"];
        }

        private void dataGridView1_Click(object sender, EventArgs e)//改变选中学生信息选中行，会将信息更新到下面的对应的控件中
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//学号信息
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();//姓名信息
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "男") comboBox1.SelectedIndex = 0;
            else if(dataGridView1.CurrentRow.Cells[2].Value.ToString() == "女") comboBox1.SelectedIndex = 1;//性别信息
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);//生日信息
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();//密码信息
        }

        private void button2_Click(object sender, EventArgs e)//新增学生信息
        {
            if (textBox2.Text == "" || textBox3.Text == "")//判断输入框是否为空
                MessageBox.Show("输入为空");
            else if(comboBox1.SelectedIndex==-1) MessageBox.Show("未选择性别");
            else
            {
                //插入语句，插入一个新的学生信息
                string sql = string.Format(@"insert into [dbo].[Student] ([SName],[SSex],[SBorn],[SPassword]) values ('{0}','{1}','{2}','{3}');",textBox2.Text,comboBox1.SelectedItem.ToString(),Convert.ToDateTime(dateTimePicker1.Value),textBox3.Text);
                DBHelper dbHelper = new DBHelper();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                    dbHelper.OpenConnection();//打开连接
                    cmd.ExecuteNonQuery();//执行sql语句
                    MessageBox.Show("添加成功");
                    dbHelper.CloseConnection();//关闭连接
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                search();//重新刷新表格信息
            }
        }

        private void button3_Click(object sender, EventArgs e)//更新学生信息
        {
            if (textBox2.Text == "" || textBox3.Text == "")//输入框判空
                MessageBox.Show("输入为空");
            else if (comboBox1.SelectedIndex == -1) MessageBox.Show("未选择性别");
            else
            {
                //根据学号，更新学生信息
                string sql = string.Format(@"update [dbo].[Student] set [SName]='{1}',[SSex]='{2}',[SBorn]='{3}',[SPassword]='{4}' where [SNO]='{0}';", Convert.ToInt32(textBox1.Text), textBox2.Text, comboBox1.SelectedItem.ToString(), Convert.ToDateTime(dateTimePicker1.Value), textBox3.Text);
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
                search();//更新显示信息
            }
        }

        private void button4_Click(object sender, EventArgs e)//删除学生信息函数
        {
            //根据学号删除学生信息
            string sql = string.Format(@"delete from [dbo].[Student] where [SNO]='{0}';",Convert.ToInt32( textBox1.Text));
            DBHelper dbHelper = new DBHelper();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                dbHelper.OpenConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.SelectedIndex = -1;//清空输入框，并且还原combobox
                dbHelper.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            search();
        }

        private void button5_Click(object sender, EventArgs e)//学生成绩管理函数
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
        void scoreshow()//查询分数函数
        {
            try
            {
                DBHelper dbHelper = new DBHelper();
                //多表联合查询，查询学号、学生姓名、课程号、课程名、成绩
                string sql = string.Format(@"select [Student].[SNO],[SName],[Course].[CNO],[CName],[Grade] from [SelectCourse] inner join [Course] on [SelectCourse].[CNO] = [Course].[CNO] inner join [Student] on [Student].[SNO]=[SelectCourse].[SNO] where [SelectCourse].[SNO]='{0}';", Convert.ToInt32(textBox4.Text));
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Student");
                this.dataGridView2.DataSource = ds.Tables["Student"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)//根据学号查询成绩按钮
        {
            if (textBox4.Text == "") MessageBox.Show("未填写学号");
            else
                scoreshow();//调用查询分数函数
        }

        private void dataGridView2_Click(object sender, EventArgs e)//获取所选行的内容，并更新到下面控件中
        {
            textBox5.Text= dataGridView2.CurrentRow.Cells[0].Value.ToString();//学号
            textBox6.Text= dataGridView2.CurrentRow.Cells[2].Value.ToString();//课程号
            textBox7.Text= dataGridView2.CurrentRow.Cells[4].Value.ToString();//成绩
        }

        private void button7_Click(object sender, EventArgs e)//插入新的成绩信息
        {
            if (textBox6.Text == "" || textBox7.Text == "")
                MessageBox.Show("输入为空");
            else
            {
                //成绩添加语句，根据唯一索引的（SNO，CNO）
                string sql = string.Format(@"insert into [dbo].[SelectCourse] ([SNO],[CNO],[Grade]) values ('{0}','{1}','{2}');",Convert.ToInt32( textBox5.Text), Convert.ToInt32(textBox6.Text), textBox7.Text);
                DBHelper dbHelper = new DBHelper();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                    dbHelper.OpenConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加成功");
                    dbHelper.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            scoreshow();//更新列表
        }

        private void button8_Click(object sender, EventArgs e)//更新成绩信息
        {
            if (textBox6.Text == "" || textBox7.Text == "")
                MessageBox.Show("输入为空");
            else
            {
                //成绩更新语句，根据唯一索引的（SNO，CNO）
                string sql = string.Format(@"update [dbo].[SelectCourse] set [Grade]='{0}' where [SNO]='{1}' and [CNO]='{2}';",textBox7.Text, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text) );
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
            scoreshow();//更新列表
        }
    }
}
