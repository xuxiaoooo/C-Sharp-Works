using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;    //动态数组
using System.Data.SqlClient; //数据库
namespace 餐饮管理系统
{
    public partial class Order : Form
    {
        public Order()
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
        public string sub_str(string str)
        {
            //将(桌号+承载量)转化为(桌号)
            //注意：模板必须为(5 承载量：10),中间务必加空格
            string numstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]!=' ')
                {
                    if (str[i] <= '9' & str[i] >= '0')
                        numstr += str[i];
                }
                else
                {
                    break;
                }
            }
            return numstr;
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
                cmd1.Parameters.Add("@uoa_no", System.Data.SqlDbType.VarChar, 10).Value = textBox8.Text;
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
                cmd2.Parameters.Add("@uoa_no", System.Data.SqlDbType.VarChar, 10).Value = textBox8.Text;
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
                if(num!=0)
                {
                    //初始化listview
                    //添加列名
                    ColumnHeader c1 = new ColumnHeader();
                    c1.Text = "菜品编号";
                    c1.Width = 108;
                    listView1.Columns.Add(c1);
                    ColumnHeader c2 = new ColumnHeader();
                    c2.Text = "菜品名称";
                    c2.Width = 108;
                    listView1.Columns.Add(c2);
                    ColumnHeader c3 = new ColumnHeader();
                    c3.Text = "菜品单价";
                    c3.Width = 108;
                    listView1.Columns.Add(c3);
                    ColumnHeader c4 = new ColumnHeader();
                    c4.Text = "菜品数量";
                    c4.Width = 108;
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
        private void Order_Load(object sender, EventArgs e)
        {
            //订餐背景
            string filepath = Application.StartupPath + "\\image\\美食.jpg";
            this.BackgroundImage = Image.FromFile(filepath);
            //向combox1中添加桌号
            for (int i = 1; i <= 25; i++)
                comboBox2.Items.Add(i);
            ArrayList hot = new ArrayList();    //存放热菜名称
            ArrayList cold = new ArrayList();   //存放凉菜名称
            ArrayList staple = new ArrayList(); //存放主食名称
            ArrayList drink = new ArrayList();  //存放饮料名称
            //连接
            string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
            SqlConnection MyConnection = new SqlConnection(strConnection);
            MyConnection.Open();
            //查询
            string strSQL1 = "select m_name from menu where m_type=1";
            string strSQL2 = "select m_name from menu where m_type=2";
            string strSQL3 = "select m_name from menu where m_type=3";
            string strSQL4 = "select m_name from menu where m_type=4";
            SqlCommand cmd1 = new SqlCommand(strSQL1, MyConnection);
            SqlDataReader dr1 = cmd1.ExecuteReader(); //执行查询
            while (dr1.Read())
            {
                hot.Add(dr1.GetString(0));
            }
            //断开
            dr1.Close();
            SqlCommand cmd2 = new SqlCommand(strSQL2, MyConnection);
            SqlDataReader dr2 = cmd2.ExecuteReader(); //执行查询
            while (dr2.Read())
            {
                cold.Add(dr2.GetString(0));
            }
            //断开
            dr2.Close();
            SqlCommand cmd3 = new SqlCommand(strSQL3, MyConnection);
            SqlDataReader dr3 = cmd3.ExecuteReader(); //执行查询
            while (dr3.Read())
            {
                staple.Add(dr3.GetString(0));
            }
            //断开
            dr3.Close();
            SqlCommand cmd4 = new SqlCommand(strSQL4, MyConnection);
            SqlDataReader dr4 = cmd4.ExecuteReader(); //执行查询
            while (dr4.Read())
            {
                drink.Add(dr4.GetString(0));
            }
            //断开
            dr4.Close();
            MyConnection.Close();
            //添加订单号
            textBox7.Text = (Information.inform_uo_num + 1).ToString();
            //根节点1
            TreeNode node1 = new TreeNode("热菜");
            treeView1.Nodes.Add(node1);
            //添加hot
            for(int i=0;i<Information.inform_hot_num;i++)
            {
                node1.Nodes.Add(new TreeNode(hot[i].ToString()));
            }
            //根节点2
            TreeNode node2 = new TreeNode("凉菜");
            treeView1.Nodes.Add(node2);
            //添加cold
            for (int i = 0; i < Information.inform_cold_num; i++)
            {
                node2.Nodes.Add(new TreeNode(cold[i].ToString()));
            }
            //根节点3
            TreeNode node3 = new TreeNode("主食");
            treeView1.Nodes.Add(node3);
            //添加staple
            for (int i = 0; i < Information.inform_staple_num; i++)
            {
                node3.Nodes.Add(new TreeNode(staple[i].ToString()));
            }
            //根节点4
            TreeNode node4 = new TreeNode("饮品");
            treeView1.Nodes.Add(node4);
            //添加drink
            for (int i = 0; i < Information.inform_drink_num; i++)
            {
                node4.Nodes.Add(new TreeNode(drink[i].ToString()));
            }
            treeView1.ExpandAll(); //展开所有节点
            //当前订单号，用于插入订单
            textBox8.Text = textBox7.Text;
            //combox3初始化
            for (int i = 1; i <= 25;i++ )
                comboBox3.Items.Add(i);
            //初始化combox3为一份
            comboBox3.SelectedIndex = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    //连接
                    string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
                    SqlConnection MyConnection = new SqlConnection(strConnection);
                    MyConnection.Open();
                    //插入
                    string strSQL = "insert into user_order values(@uo_no,@d_no,@uo_num,CURRENT_TIMESTAMP,null,1)";
                    SqlCommand cmd = new SqlCommand(strSQL, MyConnection);
                    cmd.Parameters.Add("@uo_no", System.Data.SqlDbType.VarChar, 3).Value = Information.inform_uo_num + 1;
                    cmd.Parameters.Add("@d_no", System.Data.SqlDbType.VarChar, 3).Value = sub_str(comboBox1.Text); //裁剪combox1为当前订单的桌号
                    cmd.Parameters.Add("@uo_num", System.Data.SqlDbType.VarChar, 3).Value = comboBox2.Text;
                    if (cmd.ExecuteNonQuery() > 0) //执行并返回受影响的行数
                        MessageBox.Show("插入成功！");
                    //断开
                    MyConnection.Close();
                }
                else
                {
                    MessageBox.Show("请选择桌号！");
                }
            }
            catch
            {
                MessageBox.Show("订单创建失败，此订单已创建过！");
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            if (comboBox2.Text != "")
            {
                //连接
                string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
                SqlConnection MyConnection = new SqlConnection(strConnection);
                MyConnection.Open();
                //查询
                string strSQL = "select d_no,d_num from desk where d_state=0 and d_num>=@d_num";
                SqlCommand cmd = new SqlCommand(strSQL, MyConnection);
                cmd.Parameters.Add("@d_num", System.Data.SqlDbType.VarChar, 3).Value = comboBox2.Text;
                SqlDataReader dr = cmd.ExecuteReader(); //执行查询
                while (dr.Read())
                {
                    //获得桌号信息
                    comboBox1.Items.Add(dr.GetInt32(0)+" (承载量："+dr.GetInt32(1).ToString()+")"); //格式不可变(必须有一空格)，否则引起另一函数错误
                }
                dr.Close();
                MyConnection.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Text = null;
            comboBox1.Items.Clear();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox3.Text=treeView1.SelectedNode.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //连接
            string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
            SqlConnection MyConnection = new SqlConnection(strConnection);
            MyConnection.Open();
            //查询
            string strSQL = "select m_no,m_price from menu where m_name=@m_name";
            SqlCommand cmd = new SqlCommand(strSQL, MyConnection);
            cmd.Parameters.Add("@m_name", System.Data.SqlDbType.VarChar, 10).Value = textBox3.Text;
            SqlDataReader dr = cmd.ExecuteReader(); //执行查询
            while (dr.Read())
            {
                textBox2.Text = dr.GetInt32(0).ToString();
                textBox4.Text = dr.GetDouble(1).ToString();
            }
            //断开
            dr.Close();
            MyConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text != "")
                {
                    if(textBox2.Text!="")
                    {
                        int flag = 2; //判断菜单是否有效
                        //连接
                        string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
                        SqlConnection MyConnection = new SqlConnection(strConnection);
                        MyConnection.Open();
                        //插入
                        string strSQL1 = "select uo_state from user_order where uo_no=@uo_no";
                        SqlCommand cmd1 = new SqlCommand(strSQL1, MyConnection);
                        cmd1.Parameters.Add("@uo_no", System.Data.SqlDbType.Int).Value = textBox8.Text;
                        SqlDataReader dr1 = cmd1.ExecuteReader(); //执行查询
                        while (dr1.Read())
                        {
                            flag = dr1.GetInt32(0);
                        }
                        //断开
                        dr1.Close();
                        if (flag == 1)
                        {
                            string strSQL2 = "insert into user_order_add values(@uoa_no,@m_no,@uoa_num,@uoa_sum_price)";
                            SqlCommand cmd2 = new SqlCommand(strSQL2, MyConnection);
                            cmd2.Parameters.Add("@uoa_no", System.Data.SqlDbType.VarChar, 10).Value = textBox8.Text;
                            cmd2.Parameters.Add("@m_no", System.Data.SqlDbType.VarChar, 10).Value = textBox2.Text;
                            cmd2.Parameters.Add("@uoa_num", System.Data.SqlDbType.VarChar, 10).Value = comboBox3.Text;
                            cmd2.Parameters.Add("@uoa_sum_price", System.Data.SqlDbType.VarChar, 10).Value = textBox6.Text;
                            cmd2.ExecuteNonQuery(); //执行插入命令
                            //断开
                            MyConnection.Close();
                            show_user_order_add();
                        }
                        else if (flag == 0)
                        {
                            MessageBox.Show("此订单已结算，无法再添加菜品！");
                        }
                        else
                        {
                            MessageBox.Show("查询不到此订单号！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请添加菜品！");
                    }
                }
                else
                {
                    MessageBox.Show("请输入订单号！");
                }
            }
            catch
            {
                MessageBox.Show("请不要重复添加同一菜品！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox8.Text != "")
            {
                //连接
                string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
                SqlConnection MyConnection = new SqlConnection(strConnection);
                MyConnection.Open();
                //删除
                string strSQL = "delete from user_order_add where uoa_no=@uoa_no and m_no=@m_no";
                SqlCommand cmd = new SqlCommand(strSQL, MyConnection);
                cmd.Parameters.Add("@uoa_no", System.Data.SqlDbType.VarChar, 10).Value = textBox8.Text;
                cmd.Parameters.Add("@m_no", System.Data.SqlDbType.VarChar, 10).Value = textBox2.Text;
                if (cmd.ExecuteNonQuery() <= 0) //执行并返回受影响的行数
                    MessageBox.Show("删除失败，找不到此菜品！"); 
                //断开
                MyConnection.Close();
                show_user_order_add();
            }
            else
            {
                MessageBox.Show("删除失败，请选择要删除的菜品！");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            show_user_order_add();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //菜品总价
            try
            {
                if (textBox4.Text != "" && comboBox3.Text != "")
                {
                    textBox6.Text = (Convert.ToDouble(textBox4.Text) * Convert.ToInt32(comboBox3.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("请输入正确的菜品数量！");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //总价初始为单价
            textBox6.Text = textBox4.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //更改菜品，让数量归一
            comboBox3.SelectedIndex = 0;
        }
    }
}
