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
    public partial class 学生系统 : Form
    {
        public 学生系统()
        {
            InitializeComponent();//初始化
            infoload();//调用读取学生基本信息函数
            courseload();//调用选课信息表函数
            gradeload();//调用成绩信息函数
            calcugrade();//调用计算绩点函数
        }
        void infoload()
        {
            string sql = string.Format(@"select * from [dbo].[Student] where [SNO]='{0}';",Convert.ToInt32( DBHelper.a));//查询所有学号为当前登录学号的所有信息属性
            DBHelper dbHelper = new DBHelper();//声明数据库函数对象
            try//防止null值传递报错
            {
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                dbHelper.OpenConnection();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())//如果读取到内容
                {
                    lbno.Text = dr["SNO"].ToString();//学号信息填写到标识为lbno的label控件
                    lbname.Text = dr["SName"].ToString();//姓名信息填写到标识为lbname的label控件
                    lbsex.Text = dr["SSex"].ToString();//性别信息填写到标识为lbsex的label控件
                    dateTimePicker1.Value = Convert.ToDateTime(dr["SBorn"]);//生日信息填写到标识为dateTimePicker1的dateTimePicker控件
                }
                else
                {
                    MessageBox.Show("查询失败，请重试！");
                }
                dbHelper.CloseConnection();//关闭连接
            }
            catch (Exception ex)//报错
            {
                MessageBox.Show("发生错误，请联系管理员,错误原因是：" + ex.Message);//提示错误原因
            }
        }

        void courseload()
        {
            DBHelper dbHelper = new DBHelper();
            string sql = string.Format(@"select * from [dbo].[Course];");//查询所有的可选课程信息
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Course");//将读取到的内容填写到ds
            this.dataGridView1.DataSource = ds.Tables["Course"];//将ds的内容再转为datatable填写到dataGridView1表格控件
        }
        int CNO = 0;//声明全局变量课程号CNO方便选中某一行课程后得到其CNO值
        private void dataGridView1_Click(object sender, EventArgs e)//点击选课列表的某一行的函数
        {
            CNO= Convert.ToInt32(dataGridView1.CurrentRow.Cells["编号"].Value);//获取课程编号
        }

        private void button1_Click(object sender, EventArgs e)//确认选课按钮函数
        {
            if (CNO == 0)//未点击某一行课程
            {
                MessageBox.Show("未选择课程");
            }
            else
            {
                if(Convert.ToInt32(dataGridView1.CurrentRow.Cells["人数额度"].Value) <= 0)//判断是否有剩余课程人数额度
                {
                    MessageBox.Show("人数已满");
                }
                else
                {
                    //更新所选课程剩余额度减一，插入数据库选课信息表选课信息
                    string sql = string.Format(@"update [dbo].[Course] set [CTotalCount]=[CTotalCount]-1 where [CNO]='{0}';insert into [dbo].[SelectCourse] ([SNO],[CNO]) values ('{1}','{2}');", CNO,Convert.ToInt32(DBHelper.a),CNO);
                    DBHelper dbHelper = new DBHelper();
                    try
                    {
                        SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                        dbHelper.OpenConnection();
                        cmd.ExecuteNonQuery();//cmd执行sql语句
                        MessageBox.Show("选课成功");
                        dbHelper.CloseConnection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        void gradeload()
        {
            DBHelper dbHelper = new DBHelper();
            //联合查询语句，双表联合查询课程名、类别、学分、成绩内容
            string sql = string.Format(@"select [CName],[CType],[CCredit],[Grade] from [SelectCourse] inner join [Course] on [SelectCourse].[CNO] = [Course].[CNO] where [SNO]='{0}';",Convert.ToInt32( DBHelper.a));
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Grade");
            this.dataGridView2.DataSource = ds.Tables["Grade"];//将信息填入dataGridView2
        }

        void calcugrade()
        {
            try
            {
                double count = 0;//初始化课程学分绩点
                string msg = "";//初始化空string信息
                double fenzi = 0;//计算分子的值
                double fenmu = 0;//计算分母的值
                int row = dataGridView2.Rows.Count;//得到总行数       
                for (int i = 0; i < row; i++)//得到总行数并在之内循环    
                {
                    double t = 0;//初始化每一门的课程学分绩点
                    if (dataGridView2.Rows[i].Cells[1].Value.ToString() == "基础必修")
                        t = 1.2 * calcupoint(Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value));
                    else if (dataGridView2.Rows[i].Cells[1].Value.ToString() == "专业必修")
                        t = 1.1 * calcupoint(Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value));
                    else if (dataGridView2.Rows[i].Cells[1].Value.ToString() == "选修")
                        t = 1 * calcupoint(Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value));//根据课程类别来计算绩点
                    count += t;//将每一门的绩点加到总绩点
                    msg += dataGridView2.Rows[i].Cells[0].Value.ToString() + "的课程学分绩点： " + t.ToString("0.0") + "\n";//提示信息
                    fenzi += Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value) * t;
                    fenmu += Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);
                }
                double total = fenzi / fenmu;//计算学生平均绩点
                msg += "学生平均绩点: " + total.ToString("0.0");
                label7.Text = msg;//输入成绩信息
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        double calcupoint(int grade)//根据word的绩点计算表，提供成绩参数，得到绩点返回值
        {
            double point = 0;
            if (grade >= 90 && grade <= 100) point = 4;
            else if (grade >= 85 && grade <= 89) point = 3.7;
            else if (grade >= 82 && grade <= 84) point = 3.3;
            else if (grade >= 78 && grade <= 81) point = 3.0;
            else if (grade >= 75 && grade <= 77) point = 2.7;
            else if (grade >= 71 && grade <= 74) point = 2.3;
            else if (grade >= 66 && grade <= 70) point = 2.0;
            else if (grade >= 62 && grade <= 65) point = 1.7;
            else if (grade >= 60 && grade <= 61) point = 1.3;
            else if (grade < 60) point = 0;
            return point;
        }

    }
    
}
