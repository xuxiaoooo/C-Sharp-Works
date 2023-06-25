using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 餐饮管理系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string account = textBox1.Text;
            string password = textBox2.Text;
            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            else if (account.Equals("123") && password.Equals("abc"))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("登录失败，请检查您的用户名和密码！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            string filepath = Application.StartupPath + "\\image\\落日余晖.jpg";
            this.BackgroundImage = Image.FromFile(filepath);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*'; //密文显示
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            label2.Text = currentTime.ToString();
        }
    }
}
