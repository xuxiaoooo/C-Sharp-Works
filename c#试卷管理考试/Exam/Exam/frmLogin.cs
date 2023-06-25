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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = BaseClass.DBCon();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cbbType.SelectedIndex = 0;
        }

        //判断登录的身份是学生身份还是老师身份
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cbbType.Text.Trim() == "请选择登录身份")
            {
                BaseClass.Message("提示：请选择登录身份！", "警告");
            }
            else
            {
                if (txtUser.Text.Trim() == "" || txtPwd.Text.Trim() == "")
                {
                    BaseClass.Message("提示：请输入登录用户名和密码！", "警告");
                }
                else
                {
                    if (cbbType.Text.Trim() == "学生")
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("select * from tb_User where UserName='" +
                            txtUser.Text.Trim() + "'and UserPwd='" + txtPwd.Text.Trim() + "'", conn);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        sdr.Read();
                        if (sdr.HasRows)
                        {
                            this.Hide();
                            frmStudentExam studentexam = new frmStudentExam();
                            studentexam.Username = txtUser.Text.Trim();
                            studentexam.Userpwd = txtPwd.Text.Trim();
                            studentexam.Show();
                        }
                        else
                        {
                            BaseClass.Message("提示：学生用户名或密码错误！", "警告");
                        }
                        conn.Close();
                    }
                    else
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("select * from tb_User where UserName='" + 
                            txtUser.Text.Trim() + "'and UserPwd='" + txtPwd.Text.Trim() + "'", conn);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        sdr.Read();
                        if (sdr.HasRows)
                        {
                            this.Hide();
                            frmAdminManage adminmanage = new frmAdminManage();
                            adminmanage.username = txtUser.Text.Trim();
                            adminmanage.Show();
                        }
                        else
                        {
                            BaseClass.Message("提示：老师用户名或密码错误！", "警告");
                        }
                        conn.Close();
                    }

                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtPwd.Text = "";
            txtUser.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}