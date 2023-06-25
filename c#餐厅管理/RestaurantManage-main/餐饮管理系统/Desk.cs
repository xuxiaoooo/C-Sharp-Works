using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //数据库

namespace 餐饮管理系统
{
    public partial class Desk : Form
    {
        public Desk()
        {
            InitializeComponent();
        }
        struct MyDesk 
        {
            public string d_no;
            public int d_state;
            public int d_num;
        }
        public void showdesk()
        {
            try
            {
                int num = 0; //餐桌总数量
                listView1.Columns.Clear(); //清空所有列名
                listView1.Items.Clear();   //清空所有项
                //从数据库中读取数据到背景
                //查询用户订单分表总数量
                //连接
                string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
                SqlConnection MyConnection = new SqlConnection(strConnection);
                MyConnection.Open();
                //查询
                string strSQL1 = "select count(d_no) from desk;";
                SqlCommand cmd1 = new SqlCommand(strSQL1, MyConnection);
                SqlDataReader dr1 = cmd1.ExecuteReader(); //执行查询
                while (dr1.Read())
                {
                    num = dr1.GetInt32(0);
                }
                //断开
                dr1.Close();
                //定义结构体数组，用于从数据库中取出用户订餐数据
                MyDesk[] mydesk = new MyDesk[num];
                //查询用户订单分表到结构体
                string strSQL2 = "select * from desk;";
                SqlCommand cmd2 = new SqlCommand(strSQL2, MyConnection);
                SqlDataReader dr2 = cmd2.ExecuteReader(); //执行查询
                int j = 0; //用于结构体数组下标
                while (dr2.Read())
                {
                    mydesk[j].d_no = dr2.GetInt32(0).ToString();
                    mydesk[j].d_state = dr2.GetInt32(1);
                    mydesk[j].d_num = dr2.GetInt32(2);
                    j++;
                }
                //断开
                dr2.Close();
                MyConnection.Close();
                if (num != 0)
                {
                    //初始化listview
                    //添加列名
                    ColumnHeader c1 = new ColumnHeader();
                    c1.Text = "餐桌编号";
                    c1.Width = 112;
                    listView1.Columns.Add(c1);
                    ColumnHeader c2 = new ColumnHeader();
                    c2.Text = "餐桌状态";
                    c2.Width = 112;
                    listView1.Columns.Add(c2);
                    ColumnHeader c3 = new ColumnHeader();
                    c3.Text = "餐桌承载";
                    c3.Width = 112;
                    listView1.Columns.Add(c3);
                    //添加行
                    for (int i = 0; i < num; i++)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = mydesk[i].d_no;
                        item.SubItems.Add(mydesk[i].d_state.ToString());
                        item.SubItems.Add(mydesk[i].d_num.ToString());
                        listView1.Items.Add(item);
                    }
                    //listview属性
                    listView1.GridLines = true;    //显示网格
                    listView1.View = View.Details; //显示列名
                }
            }
            catch
            {
                MessageBox.Show("获取餐桌信息失败！");
            }
        }
        private void Desk_Load(object sender, EventArgs e)
        {
            //向combox1中添加桌号
            for (int i = 1; i <= 25; i++)
                comboBox1.Items.Add(i);
            //向combox2中添加人数
            for (int i = 1; i <= 25; i++)
                comboBox2.Items.Add(i);
            //餐桌背景
            string filepath = Application.StartupPath + "\\image\\餐桌预定背景.jpg";
            this.BackgroundImage = Image.FromFile(filepath);
            //从数据库中读取数据到背景
            showdesk();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string dno, dnum;
            dno = comboBox1.Text;
            dnum = comboBox2.Text;
            if (comboBox1.Text == "")
            {
                MessageBox.Show("        请输入餐桌编号！", "提示");
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("        请输入可就餐人数！", "提示"); 
            }
            else
            {
                string myconn = @"Data Source=.;Initial Catalog=restaurant;Integrated Security=SSPI";  //数据库实例连接字符串，使用Windows身份验证的方式
                SqlConnection sqlConnection = new SqlConnection(myconn);  //新建数据库连接实例
                sqlConnection.Open();  //打开数据库连接            
                string sql = "select * from desk where d_no='" + dno + "'";  //SQL语句实现表数据的读取
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    MessageBox.Show("        此编号已存在！", "提示");
                    comboBox1.Text = "";
                    comboBox2.Text = "";          
                }
                else
                {
                    sqlConnection.Close();
                    string myconn1 = @"Data Source=.;Initial Catalog=restaurant;Integrated Security=SSPI";  //数据库实例连接字符串，使用Windows身份验证的方式
                    SqlConnection sqlConnection1 = new SqlConnection(myconn1);  //新建数据库连接实例
                    sqlConnection1.Open();  //打开数据库连接            
                    string sql1 = "insert into desk values('" + dno + "','" + 0 + "','" + dnum + "')";  //SQL语句实现表数据的读取
                    SqlCommand sqlCommand1 = new SqlCommand(sql1, sqlConnection1);
                    sqlCommand1.ExecuteNonQuery();
                    MessageBox.Show("        添加餐桌成功！", "提示");
                    sqlConnection1.Close();
                    showdesk();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string dno, dnum;
            dno = comboBox1.Text;
            dnum = comboBox2.Text;
            if (comboBox1.Text == "")
            {
                MessageBox.Show("        请输入餐桌编号！", "提示");
                comboBox1.Focus();
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("        请输入可就餐人数！", "提示");
                comboBox2.Focus();
            }
            else
            {
                string myconn = @"Data Source=.;Initial Catalog=restaurant;Integrated Security=SSPI";  //数据库实例连接字符串，使用Windows身份验证的方式
                SqlConnection sqlConnection = new SqlConnection(myconn);  //新建数据库连接实例
                sqlConnection.Open();  //打开数据库连接            
                string sql = "select * from desk where d_no='" + dno + "'";  //SQL语句实现表数据的读取
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    string str = "";
                    str = Convert.ToString(sqlDataReader.GetInt32(1));
                    sqlConnection.Close();
                    if (str == "1")
                    {
                        MessageBox.Show("        此桌已有顾客在就餐,不能修改！", "提示");
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                        comboBox1.Focus();
                    }
                    else
                    {
                        string myconn1 = @"Data Source=.;Initial Catalog=restaurant;Integrated Security=SSPI";  //数据库实例连接字符串，使用Windows身份验证的方式
                        SqlConnection sqlConnection1 = new SqlConnection(myconn1);  //新建数据库连接实例
                        sqlConnection1.Open();  //打开数据库连接                        
                        string sql1 = "update desk set d_no='" + dno + "',d_num='" + dnum + "' where d_no='" + dno + "'";  //SQL语句实现表数据的读取
                        SqlCommand sqlCommand1 = new SqlCommand(sql1, sqlConnection1);
                        sqlCommand1.ExecuteNonQuery();
                        MessageBox.Show("        更新信息成功！", "提示");
                        sqlConnection1.Close();
                        showdesk();
                    }
                }
                else
                {
                    MessageBox.Show("        没有此餐桌！", "更新信息失败");
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int d_state = 2; //判断餐桌状态
            if (comboBox1.Text == "")
            {
                MessageBox.Show("        请输入餐桌编号！", "提示");
            }
            else
            {
                //连接
                string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
                SqlConnection MyConnection = new SqlConnection(strConnection);
                MyConnection.Open();
                //查询
                string strSQL1 = "select d_state from desk where d_no=@d_no";
                SqlCommand cmd1 = new SqlCommand(strSQL1, MyConnection);
                cmd1.Parameters.Add("@d_no", System.Data.SqlDbType.VarChar, 10).Value = comboBox1.Text;
                SqlDataReader dr1 = cmd1.ExecuteReader(); //执行查询
                while (dr1.Read())
                {
                    d_state = dr1.GetInt32(0);
                }
                //断开
                dr1.Close();
                if(d_state==0)
                {
                    //餐桌状态为未使用
                    //删除
                    string strSQL2 = "delete from desk where d_no=@d_no";
                    SqlCommand cmd2 = new SqlCommand(strSQL2, MyConnection);
                    cmd2.Parameters.Add("@d_no", System.Data.SqlDbType.VarChar, 10).Value = comboBox1.Text;
                    if (cmd2.ExecuteNonQuery() > 0) //执行并返回受影响的行数
                        MessageBox.Show("删除成功！");
                    else
                        MessageBox.Show("删除失败！");
                    //断开
                    MyConnection.Close();
                    showdesk();
                }
                else if(d_state==1)
                {
                    //餐桌状态为使用中
                    MessageBox.Show("        此桌已有顾客在就餐,不能删除！", "提示");
                }
                else
                {
                    MessageBox.Show("        没有此餐桌！", "删除失败");
                }
            }
        }
    }
}
