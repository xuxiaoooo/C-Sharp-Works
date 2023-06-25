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
    public partial class frmAdminFillExam : Form
    {
        public frmAdminFillExam()
        {
            InitializeComponent();
        }
        public int flag = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdminFillExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmAdminManage adminManage = new frmAdminManage();
            adminManage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDaAn.Text.Trim() == "" || txtTimu.Text.Trim() == "")
            {
                BaseClass.Message("提示：请将信息填写完整！", "警告");
            }
            else
            {
                if (flag > 0)
                {
                    string sql = "update tb_Test set subject='" + txtTimu.Text.Trim() + "',rightkey='" + txtDaAn.Text.Trim() + "' where ID=" + flag;
                    BaseClass.UpdateData(sql);
                    this.Close();
                }
                else
                {
                    string sql = "insert into tb_Test(TypeID,subject,rightkey) values(3,'" + txtTimu.Text.Trim() + "','" + txtDaAn.Text.Trim() + "')";
                    BaseClass.InsertData(sql);
                    txtDaAn.Text = "";
                    txtTimu.Text = "";
                }
            }
        }

        private void frmAdminFillExam_Load(object sender, EventArgs e)
        {
            if (flag > 0)
            {
                SqlConnection conn = BaseClass.DBCon();
                conn.Open();
                string sql = "select * from tb_Test where ID='" + flag + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                txtTimu.Text = sdr["subject"].ToString();
                txtDaAn.Text = sdr["rightkey"].ToString();
                conn.Close();
            }
        }
    }
}