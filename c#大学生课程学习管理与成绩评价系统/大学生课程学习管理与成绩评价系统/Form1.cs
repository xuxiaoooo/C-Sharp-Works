using System.Data.SqlClient;

namespace 大学生课程学习管理与成绩评价系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;//默认选择学生身份
        }

        private void button1_Click(object sender, EventArgs e)//登录按钮事件
        {
            if (comboBox1.SelectedIndex == -1 || textBox1.Text == "" || textBox2.Text == "")//输入框判空
            {
                MessageBox.Show("请填写正确信息！");
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)//如果是学生，则调用stu函数
                {
                    stu();
                }
                else if(comboBox1.SelectedIndex==1)//如果是教师，则调用teacher函数
                {
                    teacher();
                }
            }
        }
        void stu()//学生登录函数
        {
            string userid = this.textBox1.Text;
            string psword = this.textBox2.Text;//获取输入框的账号和密码
            if (userid.Equals("") || psword.Equals(""))//用户名或密码为空
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                string sql = string.Format(@"select * from [dbo].[Student] where [SNO] = '{0}' and [SPassword] = '{1}'", userid, psword);//查询数据库是否有满足账号密码的学生信息
                DBHelper dbHelper = new DBHelper();//声明一个数据库连接函数对象
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);//声明连接对象
                dbHelper.OpenConnection();//打开连接
                SqlDataReader sdr = cmd.ExecuteReader();//声明读取函数对象sdr

                if (sdr.Read())//如果读取函数读到内容
                {
                    DBHelper.a = userid;//给DBHelper类中的全局静态变量赋值，存储登录用户id
                    MessageBox.Show("信息验证成功");//弹窗提示
                    学生系统 s = new 学生系统();//声明新页面对象
                    s.Show();//新页面打开
                    this.Hide();//此页面隐藏
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");//弹窗提示
                }
            }
        }
        void teacher()
        {
            string userid = this.textBox1.Text;
            string psword = this.textBox2.Text;//获取输入框的账号和密码
            if (userid.Equals("") || psword.Equals(""))//用户名或密码为空
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                string sql = string.Format(@"select * from [dbo].[Teacher] where [TNO] = '{0}' and [TPassword] = '{1}'", userid, psword);//查询数据库是否有满足账号密码的教师信息
                DBHelper dbHelper = new DBHelper();//声明一个数据库连接函数对象
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);//声明连接对象
                dbHelper.OpenConnection();//打开连接
                SqlDataReader sdr = cmd.ExecuteReader();//声明读取函数对象sdr

                if (sdr.Read())//如果读取函数读到内容
                {
                    DBHelper.a = userid;//给DBHelper类中的全局静态变量赋值，存储登录用户id
                    MessageBox.Show("信息验证成功");//弹窗提示
                    教师系统 t = new 教师系统();//声明新页面对象
                    t.Show();//新页面打开
                    this.Hide();//此页面隐藏
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");//弹窗提示
                }
            }
        }
    }
}