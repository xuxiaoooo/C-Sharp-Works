using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Exam
{
    public partial class frmStudentExam : Form
    {
        public frmStudentExam()
        {
            InitializeComponent();
        }
        public string Username = "";
        public string Userpwd = "";
        SqlConnection conn = BaseClass.DBCon();

        private void checkIsTest()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Username from tb_User where UserName='"+Username+"'", conn);
            string flag = cmd.ExecuteScalar().ToString();
            if (flag == "0")
            {
                开始考试SToolStripMenuItem.Enabled = true;
                查询分数SToolStripMenuItem.Enabled = false;
            }
            else
            {
                开始考试SToolStripMenuItem.Enabled = false;
                查询分数SToolStripMenuItem.Enabled = true;
            }
            conn.Close();
        }

        private void 退出系统OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 修改密码CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePwd changepwd = new frmChangePwd();
            changepwd.username = Username;
            changepwd.ShowDialog();
        }

        private void 开始考试SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStartExam startexam = new frmStartExam();
            startexam.studentNumber = Username;
            startexam.Show();
        }
       
     
        private void frmStudentExam_Activated(object sender, EventArgs e)
        {
            checkIsTest();
        }

        private void 查询分数SToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string sql = "select * from tb_ExamResult where UserID='"+Username+"'";
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();

            string xz = sdr[2].ToString();
            string pd = sdr[3].ToString();
            string tk = sdr[4].ToString();
            string all = sdr[5].ToString();

            string mess = Username + "你好，您的考分如下：\n"+"选择题得分："+xz+"\n"+"判断题得分："+pd+"\n"+"填空题得分："+tk+"\n"+"最后总分为："+all;

            MessageBox.Show(mess,"考试成绩查询");
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void 系统信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MSINFO32.EXE");
        }

        private void frmStudentExam_Load(object sender, EventArgs e)
        {

        }

        private void frmStudentExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 文件FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 考试历史ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmTestHistory testhistory = new frmTestHistory();
            testhistory.Show();
        }

        private void 开始考试SToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStartExam startexam = new frmStartExam();
            startexam.studentNumber = Username;
            startexam.Show();
        }

      

       

        
    }
}