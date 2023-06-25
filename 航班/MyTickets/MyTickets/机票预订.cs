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
    public partial class 机票预订 : Form
    {
        #region 构造函数
        public 机票预订()
        {
            InitializeComponent();
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat;
        }

        public 机票预订(string text)
        {
            InitializeComponent();
            usename.Text = text;
        }
        #endregion

        #region 方法

        #region 绑定cbo
        /// <summary>
        /// 绑定cbo
        /// </summary>
        private void BindCbo()
        {
            DBHelper dbHelper = new DBHelper();
            //sql语句
            string sql = "select * from cityInfo";
            //适配器adapter
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            //数据集
            DataSet ds = new DataSet();
            //填充数据集
            adapter.FillSchema(ds, SchemaType.Source, "cityInfo");
            adapter.Fill(ds, "cityInfo");
            //新的一行
            DataRow row = ds.Tables["cityInfo"].NewRow();
            row[0] = -1;
            row[1] = "请选择";
            //插入
            ds.Tables["cityInfo"].Rows.InsertAt(row, 0);
            //获取视图
            DataView dv1 = new DataView(ds.Tables["cityInfo"]);
            DataView dv2 = new DataView(ds.Tables["cityInfo"]);
            //绑定
            this.cboDestinationCity.DataSource = dv1;
            this.cboDestinationCity.DisplayMember = "cityName";
            this.cboDestinationCity.ValueMember = "id";

            this.cboLeaveCity.DataSource = dv2;
            this.cboLeaveCity.DisplayMember = "cityName";
            this.cboLeaveCity.ValueMember = "id"; 
        }
        #endregion

        #region 绑定dgv
        /// <summary>
        /// 绑定dgv
        /// </summary>
        private void BindDgv()//把数据库内容导入到datagridview
        {
            DBHelper dbHelper = new DBHelper();
            string sql = string.Format(@"select flightNo,airways,leaveTime,landTime,price
                                        from flightInfo,airwaysInfo
                                        where flightInfo.airwaysId=airwaysInfo.id
                                        and leaveCity={0}
                                        and destinationCity={1}", cboLeaveCity.SelectedValue, cboDestinationCity.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connction);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "flightInfo");
            this.dataGridView1.DataSource = ds.Tables["flightInfo"];
        }
        #endregion

        #region 验证预订部分的用户输入
        /// <summary>
        /// 验证预订部分的用户输入
        /// </summary>
        /// <returns></returns>
        private bool ValidateInput()
        {
            if (txtFlightNo.Text == string.Empty)//选择航班验证
            {
                MessageBox.Show("请选择一个航班！");
                return false;
            }
            if (dateTimePicker1.Value < DateTime.Now)//日期选择验证
            {
                MessageBox.Show("请选择正确的出发日期！");
                dateTimePicker1.Focus();
                return false;
            }
            return true;
        } 
        #endregion

        #endregion

        #region 事件
        //加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            BindCbo();
            TransparencyKey = BackColor;

        }
        //查询事件
        private void tbnQuery_Click(object sender, EventArgs e)
        {
            if(cboLeaveCity.Text=="请选择"||cboDestinationCity.Text=="请选择")
            {
                MessageBox.Show("请选择出发地与目的地！");
                this.dataGridView1.DataSource = null;
                return;
            }
            BindDgv();
            //清空txt
            foreach (Control c in groupBox2.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }
        //单击dgv
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count>0)
            {
                this.txtFlightNo.Text = dataGridView1.CurrentRow.Cells["flightNo"].Value.ToString();
                this.txtAirways.Text = dataGridView1.CurrentRow.Cells["airways"].Value.ToString();
                this.txtFrom.Text = cboLeaveCity.Text;
                this.txtTo.Text = cboDestinationCity.Text;
                this.txtLeaveTime.Text = dataGridView1.CurrentRow.Cells["leaveTime"].Value.ToString();
                this.txtLandTime.Text = dataGridView1.CurrentRow.Cells["landTime"].Value.ToString();
                this.txtPrice.Text = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
            }
        }
        //点击关闭
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //点击预定
        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                Random random = new Random();
                int orderId= random.Next(100000, 9999999);
                string flightNo = this.txtFlightNo.Text;
                string leaveDate = this.dateTimePicker1.Value.ToShortDateString();
                string landTime = this.txtLandTime.Text;
                string price = this.txtPrice.Text;
                int num = (int)this.numNunber.Value;
                string leavePlace = this.txtFrom.Text;
                string landPlace = this.txtTo.Text;
                string usename = this.usename.Text;
                string sql = string.Format(@"insert into orderInfo(orderId,flightNo,leaveDate,landTime,price,Number,leavePlace,landPlace,useId)
                                            values({0},'{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}')", orderId, flightNo, leaveDate,landTime,price,num, leavePlace, landPlace,usename);
                DBHelper dbHelper = new DBHelper();
                try
                {
                    //执行工具
                    SqlCommand cmd = new SqlCommand(sql, dbHelper.Connction);
                    //打开数据库
                    dbHelper.OpenConnection();
                    //执行
                    int result =cmd.ExecuteNonQuery();
                    //判断
                    if(result>0)
                    {
                        MessageBox.Show("预订成功！订单编号是：" + orderId);
                    }
                    else
                    {
                        MessageBox.Show("预定失败，请重试！");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("发生错误，请联系管理员,错误原因是："+ex.Message);
                }
                finally
                {
                    dbHelper.CloseConnection();
                }
            }
        }

        #endregion

        #region 鼠标移动
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void 机票预订_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;

            }
        }

        private void 机票预订_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {

                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void 机票预订_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            所有航班 sy = new 所有航班();
            sy.Show();
        }//打开所有航班页面
    }
}
