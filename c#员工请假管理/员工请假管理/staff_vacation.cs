using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Design
{
    public partial class staff_vacation : Sunny.UI.UIForm
    {
        public staff_vacation()
        {
            InitializeComponent();
        }

        public static void ThreadProc(string sql, string txt)
        {
            Application.Run(new display(sql, txt));
        }

        private void staff_vacation_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql, txt;
            sql = "select * from 请假信息 where 员工编号 = '{0}'";
            sql = string.Format(sql, textBox1.Text);
            txt = textBox1.Text + "号员工的请假信息";

            System.Threading.Thread t = new System.Threading.Thread(() => ThreadProc(sql, txt));
            t.Start();
            this.Close();
        }
    }
}
