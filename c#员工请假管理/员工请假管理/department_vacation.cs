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
    public partial class department_vacation : Sunny.UI.UIForm
    {
        public department_vacation()
        {
            InitializeComponent();
        }

        public static void ThreadProc(string sql, string txt)
        {
            Application.Run(new display(sql, txt));
        }

        private void department_vacation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql, txt;
            sql = "select 请假信息.* from 请假信息,普通员工信息 where 请假信息.员工编号 = 普通员工信息.员工编号 AND 普通员工信息.所在部门编号 = '{0}'";
            sql = string.Format(sql, textBox1.Text);
            txt = textBox1.Text + "部门的请假信息";

            System.Threading.Thread t = new System.Threading.Thread(() => ThreadProc(sql, txt));
            t.Start();
            this.Close();
        }
    }
}
