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
    public partial class frmChangePwd : Form
    {
        public frmChangePwd()
        {
            InitializeComponent();
        }
        public string username = "";
        SqlConnection conn = BaseClass.DBCon();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOldPwd.Text.Trim() == "")
            {
                BaseClass.Message("提示：输入旧密码！", "警告");
            }
            else
            {
                if (txtNewPwd.Text.Trim() == "")
                {
                    BaseClass.Message("提示：输入新密码！", "警告");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from tb_User where UserFlag=0 and UserName='" + username + "'and UserPwd='" + txtOldPwd.Text.Trim() + "'", conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    if (sdr.HasRows)
                    {
                        sdr.Close();
                        cmd = new SqlCommand("update tb_User set UserPwd='" + txtNewPwd.Text.Trim() + "' where UserFlag=0 and UserName='" + username + "'", conn);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            if (txtConfirmPwd.Text == txtNewPwd.Text)
                            {
                                BaseClass.Message("提示：密码修改成功！", "提示");
                            }
                            else
                            {
                                BaseClass.Message("提示：两次输入的密码不一致！", "提示");
                            }
                            this.Close();
                        }
                    }
                    else
                    {
                        BaseClass.Message("提示：旧密码错误！", "警告");
                    }
                    conn.Close();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}