using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//数据库
namespace 餐饮管理系统
{
    public partial class Pay : Form
    {
        public int state = 2; //表示订单状态，0：已失效，1：使用中，2：不存在
        public Pay()
        {
            InitializeComponent();
        }
        struct User_order_add
        {
            public string m_no;     //菜品编号
            public string m_name;   //菜品名称
            public string m_price;  //菜品单价
            public string uoa_num;  //菜品数量
        }
        public void show_user_order_add()
        {
            try
            {
                int num = 0; //用户订单分表总数量
                //清空listview
                listView1.Columns.Clear(); //清空所有列名
                listView1.Items.Clear();   //清空所有项
                //查询用户订单分表总数量
                //连接
                string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
                SqlConnection MyConnection = new SqlConnection(strConnection);
                MyConnection.Open();
                //查询
                string strSQL1 = "select count(m_no) from user_order_add where uoa_no=@uoa_no";
                SqlCommand cmd1 = new SqlCommand(strSQL1, MyConnection);
                cmd1.Parameters.Add("@uoa_no", System.Data.SqlDbType.VarChar, 10).Value = comboBox1.Text;
                SqlDataReader dr1 = cmd1.ExecuteReader(); //执行查询
                while (dr1.Read())
                {
                    num = dr1.GetInt32(0);
                }
                //断开
                dr1.Close();
                //定义结构体数组，用于从数据库中取出用户订餐数据
                User_order_add[] user_order_add = new User_order_add[num];
                //查询用户订单分表到结构体
                string strSQL2 = "select user_order_add.m_no,menu.m_name,menu.m_price,user_order_add.uoa_num from user_order_add,menu where user_order_add.uoa_no=@uoa_no and user_order_add.m_no=menu.m_no";
                SqlCommand cmd2 = new SqlCommand(strSQL2, MyConnection);
                cmd2.Parameters.Add("@uoa_no", System.Data.SqlDbType.VarChar, 10).Value = comboBox1.Text;
                SqlDataReader dr2 = cmd2.ExecuteReader(); //执行查询
                int j = 0; //用于结构体数组下标
                while (dr2.Read())
                {
                    user_order_add[j].m_no = dr2.GetInt32(0).ToString();
                    user_order_add[j].m_name = dr2.GetString(1);
                    user_order_add[j].m_price = dr2.GetDouble(2).ToString();
                    user_order_add[j].uoa_num = dr2.GetInt32(3).ToString();
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
                    c1.Text = "菜品编号";
                    c1.Width = 90;
                    listView1.Columns.Add(c1);
                    ColumnHeader c2 = new ColumnHeader();
                    c2.Text = "菜品名称";
                    c2.Width = 90;
                    listView1.Columns.Add(c2);
                    ColumnHeader c3 = new ColumnHeader();
                    c3.Text = "菜品单价";
                    c3.Width = 90;
                    listView1.Columns.Add(c3);
                    ColumnHeader c4 = new ColumnHeader();
                    c4.Text = "菜品数量";
                    c4.Width = 90;
                    listView1.Columns.Add(c4);
                    //添加行
                    for (int i = 0; i < num; i++)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = user_order_add[i].m_no;
                        item.SubItems.Add(user_order_add[i].m_name);
                        item.SubItems.Add(user_order_add[i].m_price);
                        item.SubItems.Add(user_order_add[i].uoa_num);
                        listView1.Items.Add(item);
                    }
                    //listview属性
                    listView1.GridLines = true;    //显示网格
                    listView1.View = View.Details; //显示列名
                }
            }
            catch
            {
                MessageBox.Show("获取用户订单详细信息失败！！！");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string flag = ""; //用于判断订单是否已有菜品
            //连接
            string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
            SqlConnection MyConnection = new SqlConnection(strConnection);
            MyConnection.Open();
            //判断订单是否已经失效，若失效则提示失效
            string strSQL1 = "select uo_state from user_order where uo_no=@uo_no";
            SqlCommand cmd1 = new SqlCommand(strSQL1, MyConnection);
            cmd1.Parameters.Add("@uo_no", System.Data.SqlDbType.VarChar, 10).Value = comboBox1.Text;
            SqlDataReader dr1 = cmd1.ExecuteReader(); //执行查询
            while (dr1.Read())
            {
                state = dr1.GetInt32(0);
            }
            dr1.Close();
            if (state == 0 || state == 1) //订单使用中或者失效
            {
                //查询
                string strSQL2 = "select * from user_order_add where uoa_no=@uoa_no";
                SqlCommand cmd2 = new SqlCommand(strSQL2, MyConnection);
                cmd2.Parameters.Add("@uoa_no", System.Data.SqlDbType.VarChar, 10).Value = comboBox1.Text;
                SqlDataReader dr2 = cmd2.ExecuteReader(); //执行查询
                while (dr2.Read())
                {
                    flag = dr2.GetInt32(0).ToString();
                }
                dr2.Close();
                if (flag != "")//此订单已经订餐
                {
                    //查询
                    string strSQL3 = "select sum(uoa_sum_price) from user_order_add where uoa_no=@uoa_no";
                    SqlCommand cmd3 = new SqlCommand(strSQL3, MyConnection);
                    cmd3.Parameters.Add("@uoa_no", System.Data.SqlDbType.VarChar, 10).Value = comboBox1.Text;
                    SqlDataReader dr3 = cmd3.ExecuteReader(); //执行查询
                    while (dr3.Read())
                    {
                        textBox2.Text = dr3.GetDouble(0).ToString();
                    }
                    //断开
                    dr3.Close();
                }
                else //此订单未订过任何餐
                {
                    textBox2.Text = "0";
                    MessageBox.Show("此订单未订购任何菜品！","提示");
                }    
            }
            else //订单不存在
            {
                MessageBox.Show("查询不到此订单的内容！！！");
            }
            MyConnection.Close();
            show_user_order_add();
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            //设置界面背景
            string filepath = Application.StartupPath + "\\image\\金钱.jpg";
            this.BackgroundImage = Image.FromFile(filepath);
            //设置选择账单方式
            comboBox2.Items.Add("正在进行");
            comboBox2.Items.Add("已失效");
            comboBox2.Items.Add("全部");
            //设置combox2默认值为显示第一个
            comboBox2.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!="")
            {
                //订单已经失效
                if(state==0)
                {
                    MessageBox.Show("此订单已经结算过了！");
                }
                //订单正在进行中
                else
                {
                    //连接
                    string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
                    SqlConnection MyConnection = new SqlConnection(strConnection);
                    MyConnection.Open();
                    //修改
                    string strSQL = "update user_order set uo_state=0 where uo_no=@uo_no";
                    SqlCommand cmd = new SqlCommand(strSQL, MyConnection);
                    cmd.Parameters.Add("@uo_no", System.Data.SqlDbType.VarChar, 10).Value = comboBox1.Text;
                    cmd.ExecuteNonQuery();
                    //断开
                    MyConnection.Close();
                    MessageBox.Show("结算成功！");
                }
            }
            else
            {
                MessageBox.Show("未查询到订单金额，不可结算！");
            }
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            //清空combox1中所有信息
            comboBox1.Items.Clear();
            //设置查询方式
            string style = "";
            //添加账单
            if (comboBox2.Text.Equals("正在进行"))
            {
                style = " where uo_state=1";
            }
            else if (comboBox2.Text.Equals("已失效"))
            {
                style = " where uo_state=0";
            }
            else
            {
                style = "";//style保持不变
            }
            //连接
            string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
            SqlConnection MyConnection = new SqlConnection(strConnection);
            MyConnection.Open();
            //查询
            string strSQL = "select uo_no from user_order" + style;
            SqlCommand cmd = new SqlCommand(strSQL, MyConnection);
            SqlDataReader dr = cmd.ExecuteReader(); //执行查询
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetInt32(0));
            }
            //断开
            dr.Close();
            MyConnection.Close();
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();//清空下combox1
        }
    }
}
