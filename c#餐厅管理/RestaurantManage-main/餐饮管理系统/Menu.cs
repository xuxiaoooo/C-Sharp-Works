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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("热菜");
            comboBox1.Items.Add("凉菜");
            comboBox1.Items.Add("主食");
            comboBox1.Items.Add("饮品");
            comboBox1.Text = "热菜";
            show_ListView();
            //菜单背景
            string filepath = Application.StartupPath + "\\image\\米饭.jpg";
            this.BackgroundImage = Image.FromFile(filepath);
        }
        public int StrchangeInt(string s)
        {
            int i = 0;
            if (string.Equals("热菜", comboBox1.Text)) i = 1;
            else if (string.Equals("凉菜", comboBox1.Text)) i = 2;
            else if (string.Equals("主食", comboBox1.Text)) i = 3;
            else if (string.Equals("饮品", comboBox1.Text)) i = 4;
            return i;
        }
        public string IntchangeStr(int i)
        {
            string s;
            if (i == 1) s = "热菜";
            else if (i == 2) s = "凉菜";
            else if (i == 3) s = "主食";
            else if (i == 4) s = "饮品";
            else s = "错误";
            return s;
        }
        struct menu_list
        {
            public string num;
            public string type;
            public string name;
            public string price;
        }
        public void show_ListView()
        {
            int num = 0;
            listView1.Columns.Clear(); //清空所有列名
            listView1.Items.Clear();   //清空所有项
            //连接
            string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
            SqlConnection MyConnection = new SqlConnection(strConnection);
            MyConnection.Open();
            //查询
            string strSQL = "select count(m_no) from menu";
            SqlCommand cmd = new SqlCommand(strSQL, MyConnection);
            SqlDataReader dr1 = cmd.ExecuteReader(); //执行查询
            while (dr1.Read())
            {
                num = dr1.GetInt32(0);
            }
            dr1.Close();
            menu_list[] menu_l = new menu_list[num];
            //查询
            string strSQL2 = "select * from menu";
            SqlCommand cmd2 = new SqlCommand(strSQL2, MyConnection);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            int i; //用于结构体数组下标
            for (i = 0; dr2.Read(); i++)
            {
                menu_l[i].num = dr2.GetInt32(0).ToString();
                menu_l[i].type = IntchangeStr(dr2.GetInt32(1));
                menu_l[i].name = dr2.GetString(2);
                menu_l[i].price = dr2.GetDouble(3).ToString();
            }
            dr2.Close();
            MyConnection.Close();
            //初始化listview
            //添加列名
            ColumnHeader c1 = new ColumnHeader();
            c1.Text = "编号";
            c1.Width = 60;
            listView1.Columns.Add(c1);
            ColumnHeader c2 = new ColumnHeader();
            c2.Text = "类型";
            c2.Width = 80;
            listView1.Columns.Add(c2);
            ColumnHeader c3 = new ColumnHeader();
            c3.Text = "名称";
            c3.Width = 120;
            listView1.Columns.Add(c3);
            ColumnHeader c4 = new ColumnHeader();
            c4.Text = "价格";
            c4.Width = 60;
            listView1.Columns.Add(c4);
            //添加行
            for (i = 0; i < num; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = menu_l[i].num;
                item.SubItems.Add(menu_l[i].type);
                item.SubItems.Add(menu_l[i].name);
                item.SubItems.Add(menu_l[i].price);
                listView1.Items.Add(item);
            }
            listView1.GridLines = true;    //显示网格
            listView1.View = View.Details; //显示列名
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int _combo = StrchangeInt(comboBox1.Text);//数据转换
                //连接
                string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
                SqlConnection MyConnection = new SqlConnection(strConnection);
                MyConnection.Open();
                //插入
                string strSQL = "insert into menu values(@m_no,@m_type,@m_name,@m_price)";
                SqlCommand cmd = new SqlCommand(strSQL, MyConnection);
                cmd.Parameters.Add("@m_no", System.Data.SqlDbType.VarChar, 3).Value = textBox1.Text;
                cmd.Parameters.Add("@m_type", System.Data.SqlDbType.Int).Value = _combo;
                cmd.Parameters.Add("@m_name", System.Data.SqlDbType.VarChar, 20).Value = textBox3.Text;
                cmd.Parameters.Add("@m_price", System.Data.SqlDbType.Float).Value = textBox4.Text;
                if (cmd.ExecuteNonQuery() > 0) //执行并返回受影响的行数
                {
                    MessageBox.Show("添加成功！");
                    show_ListView();
                }
                //断开
                MyConnection.Close();
            }
            catch
            {
                MessageBox.Show("插入失败！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //连接
            string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
            SqlConnection MyConnection = new SqlConnection(strConnection);
            MyConnection.Open();
            //删除
            string strSQL = "delete from menu where m_no=@m_no";
            SqlCommand cmd = new SqlCommand(strSQL, MyConnection);
            cmd.Parameters.Add("@m_no", System.Data.SqlDbType.VarChar, 3).Value = textBox1.Text;
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("删除成功！");
                show_ListView();
            } //执行并返回受影响的行数

            else
                MessageBox.Show("删除失败！");
            //断开
            MyConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int _combo = StrchangeInt(comboBox1.Text);
            //连接
            string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
            SqlConnection MyConnection = new SqlConnection(strConnection);
            MyConnection.Open();
            //修改
            string strSQL = "update menu set m_type=@m_type,m_name=@m_name,m_price=@m_price where m_no=@m_no";
            SqlCommand cmd = new SqlCommand(strSQL, MyConnection);
            cmd.Parameters.Add("@m_no", System.Data.SqlDbType.VarChar, 3).Value = textBox1.Text;
            cmd.Parameters.Add("@m_type", System.Data.SqlDbType.Int).Value = _combo;
            cmd.Parameters.Add("@m_name", System.Data.SqlDbType.VarChar, 20).Value = textBox3.Text;
            cmd.Parameters.Add("@m_price", System.Data.SqlDbType.Float).Value = textBox4.Text;
            if (cmd.ExecuteNonQuery() <= 0)
            {
                MessageBox.Show("修改失败！");
            } //执行并返回受影响的行数
            else
            {
                show_ListView();
                MessageBox.Show("修改成功！");
            }

            //断开
            MyConnection.Close();
        }
    }
}
