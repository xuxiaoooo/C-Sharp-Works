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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void asdFToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filepath = Application.StartupPath + "\\image\\海边夜色.jpg";
            this.BackgroundImage = Image.FromFile(filepath);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            label2.Text = currentTime.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //连接
            string strConnection = "Data source=.;Integrated Security=SSPI;Initial Catalog=restaurant";
            SqlConnection MyConnection = new SqlConnection(strConnection);
            MyConnection.Open();
            //查询
            string strSQL1 = "select count(m_no) from menu"; //菜总量
            string strSQL2 = "select count(d_no) from desk"; //桌子总量
            string strSQL3 = "select count(uo_no) from user_order"; //订单总量
            string strSQL4 = "select count(m_no) from menu where m_type=1;"; //热菜总量
            string strSQL5 = "select count(m_no) from menu where m_type=2;"; //凉菜总量
            string strSQL6 = "select count(m_no) from menu where m_type=3;"; //主食总量
            string strSQL7 = "select count(m_no) from menu where m_type=4;"; //饮品总量
            SqlCommand cmd1 = new SqlCommand(strSQL1, MyConnection);
            SqlCommand cmd2 = new SqlCommand(strSQL2, MyConnection);
            SqlCommand cmd3 = new SqlCommand(strSQL3, MyConnection);
            SqlCommand cmd4 = new SqlCommand(strSQL4, MyConnection);
            SqlCommand cmd5 = new SqlCommand(strSQL5, MyConnection);
            SqlCommand cmd6 = new SqlCommand(strSQL6, MyConnection);
            SqlCommand cmd7 = new SqlCommand(strSQL7, MyConnection);
            SqlDataReader dr1 = cmd1.ExecuteReader(); //执行查询1
            while (dr1.Read())
            {
                Information.inform_m_num = dr1.GetInt32(0);
            }
            dr1.Close();
            SqlDataReader dr2 = cmd2.ExecuteReader(); //执行查询2

            while (dr2.Read())
            {
                Information.inform_d_num = dr2.GetInt32(0);
            }
            dr2.Close();
            SqlDataReader dr3 = cmd3.ExecuteReader(); //执行查询3
            while (dr3.Read())
            {
                Information.inform_uo_num = dr3.GetInt32(0);
            }
            dr3.Close();
            SqlDataReader dr4 = cmd4.ExecuteReader(); //执行查询4
            while (dr4.Read())
            {
                Information.inform_hot_num = dr4.GetInt32(0);
            }
            dr4.Close();
            SqlDataReader dr5 = cmd5.ExecuteReader(); //执行查询5
            while (dr5.Read())
            {
                Information.inform_cold_num = dr5.GetInt32(0);
            }
            dr5.Close();
            SqlDataReader dr6 = cmd6.ExecuteReader(); //执行查询6
            while (dr6.Read())
            {
                Information.inform_staple_num = dr6.GetInt32(0);
            }
            dr6.Close();
            SqlDataReader dr7 = cmd7.ExecuteReader(); //执行查询7
            while (dr7.Read())
            {
                Information.inform_drink_num = dr7.GetInt32(0);
            }
            dr7.Close();
            MyConnection.Close();
            Order order = new Order();
            order.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk();
            desk.ShowDialog();
        }
    }
    public class Information
    {
        public static int inform_m_num; //菜总量
        public static int inform_d_num; //桌子总量
        public static int inform_uo_num; //订单总量
        public static int inform_hot_num;    //热菜总量
        public static int inform_cold_num;   //凉菜总量
        public static int inform_staple_num; //主食总量
        public static int inform_drink_num;  //饮品总量
    }
}
