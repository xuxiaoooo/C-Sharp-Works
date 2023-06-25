using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyTickets
{
    public partial class 订单查询 : Form
    {
        public 订单查询(string text)
        {
            InitializeComponent();
            usename.Text = text.ToString();//获取登录界面传过来的参数
        }
        #region 鼠标移动
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void 订单查询_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;

            }
        }

        private void 订单查询_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {

                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void 订单查询_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
        #endregion

        private void 订单查询_Load(object sender, EventArgs e)//查询到的订单信息到datagridview中
        {
            DBHelper dbHelper = new DBHelper();
            string sql = string.Format(@"select orderId,flightNo,leaveDate,landTime,leavePlace,landPlace from orderInfo where useId ='{0}'",usename.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "orderInfo");
            this.dataGridView1.DataSource = ds.Tables["orderInfo"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
