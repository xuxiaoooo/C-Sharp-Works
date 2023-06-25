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
    public partial class frmAdminStudent : Form
    {
        public frmAdminStudent()
        {
            InitializeComponent();
        }
        SqlConnection conn = BaseClass.DBCon();
        private void getUserInfo()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select ID as '编号',UserFlag as '用户身份',UserCH as '用户姓名',UserName as '登录账号',UserPwd as '用户密码',IsTest as '是否考试' from tb_User", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            panel1.Dock = DockStyle.Fill;
        }

        private void frmAdminStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmAdminManage adminmanage = new frmAdminManage();
            adminmanage.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUserCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void btn_AddUser_Click(object sender, EventArgs e)//添加新用户
        {
            if (txtAddUserName.Text.Trim() == "" || txtAddUserPwd.Text.Trim() == "" || txtAddUserZH.Text.Trim() == "")
            {
                BaseClass.Message("提示：请将信息填写完整！", "警告");
            }
            else
            {
                int flag1;
                int flag2;
                if (cbbAddUserType.Text.Trim() == "学生")
                    flag1 = 0;
                else
                    flag1 = 1;
                if (cbbIsTest.Text.Trim() == "没有参加考试")
                    flag2 = 0;
                else
                    flag2 = 1;
                string sql="insert into tb_User(UserFlag,UserCH,UserName,UserPwd,IsTest) values('"+flag1+"','"+txtAddUserName.Text.Trim()+"','"+txtAddUserZH.Text.Trim()+"','"+txtAddUserPwd.Text.Trim()+"','"+flag2+"')";
                BaseClass.InsertData(sql);
                txtAddUserName.Text = "";
                txtAddUserPwd.Text = "";
                txtAddUserZH.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;
            cbbAddUserType.SelectedIndex = 0;
            cbbIsTest.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                BaseClass.Message("提示：请选择要删除的用户信息！", "警告");
            }
            else
            {
                int Mid = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                string sql = "delete from tb_User where ID='"+Mid+"'";
                BaseClass.DeleteData(sql);
                getUserInfo();
            }
        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;
        }
        int MMid;
        private void button2_Click(object sender, EventArgs e)//修改信息
        {
            MMid = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel3.Dock = DockStyle.Fill;

            string sql = "select * from tb_User where ID='" + MMid + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            string a = sdr["UserFlag"].ToString();
            if (a == "0")
                cbbUserType.SelectedIndex = 0;
            else
                cbbUserType.SelectedIndex = 1;
            txtUserInfoName.Text = sdr["UserCH"].ToString();
            txtUserInfoZH.Text = sdr["UserName"].ToString();
            txtUserInfoPwd.Text = sdr["UserPwd"].ToString();
            string b=sdr["IsTest"].ToString();
            if (b == "0")
                cbbUserIsTest.SelectedIndex = 0;
            else
                cbbUserIsTest.SelectedIndex = 1;
            conn.Close();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            int flag1;
            int flag2;
            if (cbbUserType.Text.Trim()== "学生")
                flag1 = 0;
            else
                flag1 = 1;
            if (cbbUserIsTest.Text.Trim()== "没有参加考试")
                flag2 = 0;
            else
                flag2 = 1;
            string sql="update tb_User set UserFlag='"+flag1+"',UserCH='"+txtUserInfoName.Text.Trim()+"',UserName='"+txtUserInfoZH.Text.Trim()+"',UserPwd='"+txtUserInfoPwd.Text.Trim()+"',IsTest='"+flag2+"' where ID='"+MMid+"'";
            BaseClass.UpdateData(sql);
            btnUserCancel_Click(sender,e);
        }

        private void frmAdminStudent_Activated(object sender, EventArgs e)
        {
            getUserInfo();
        }

        private void frmAdminStudent_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button2_Click(sender, e);
        }
    }
}