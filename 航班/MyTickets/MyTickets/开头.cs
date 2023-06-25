using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MyTickets
{
    public partial class 开头 : Form
    {
        public 开头()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
            /*
             * 设置timer时间间隔1000毫秒，开始线程
             */
        }


        private void 开头_Load(object sender, EventArgs e)
        {
            TransparencyKey = BackColor;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            初始界面 f0 = new 初始界面();
            this.Hide();
            f0.ShowDialog();
            /*
             线程结束后打开登录界面
             */
        }
    }
}
