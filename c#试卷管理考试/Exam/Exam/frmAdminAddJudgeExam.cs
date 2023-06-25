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
    public partial class frmAdminAddJudgeExam : Form
    {
        public frmAdminAddJudgeExam()
        {
            InitializeComponent();
        }
        SqlConnection conn = BaseClass.DBCon();
        public int flag = 0;
        private void frmAdminAddJudgeExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmAdminManage adminManage = new frmAdminManage();
            adminManage.Show();
        }

        private void frmAdminAddJudgeExam_Load(object sender, EventArgs e)
        {
            if (flag > 0)
            {
                conn.Open();
                string sql = "select * from tb_Test where ID='" + flag + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                txtJudgeTimu.Text=sdr["subject"].ToString();
                int pp =Convert.ToInt32(sdr["rightkey"].ToString());
                if (pp == 1)
                    cbbJudge.SelectedIndex = 1;
                else
                    cbbJudge.SelectedIndex = 2;
                conn.Close();
            }
            else
            {
                cbbJudge.SelectedIndex = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtJudgeTimu.Text.Trim() == "" || cbbJudge.Text.Trim() == "选择答案")
            {
                BaseClass.Message("提示：请将信息填写完整！", "警告");
            }
            else
            {
                if (flag > 0)
                {
                    string result = "";
                    if (cbbJudge.Text.Trim() == "正确")
                        result = "1";
                    else
                        result = "0";
                    string sql = "update tb_Test set subject='" +txtJudgeTimu.Text.Trim() + "',rightkey='" + result + "' where ID="+flag;
                    BaseClass.UpdateData(sql);
                    this.Close();
                }
                else
                {
                    string result = "";
                    if (cbbJudge.Text.Trim() == "正确")
                        result = "1";
                    else
                        result = "0";
                    string sql = "insert into tb_Test(TypeID,subject,rightkey) values(2,'" + txtJudgeTimu.Text.Trim()+ "','" + result + "')";
                    BaseClass.InsertData(sql);
                    txtJudgeTimu.Text = "";
                    cbbJudge.SelectedIndex = 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}