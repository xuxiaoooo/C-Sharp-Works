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
    public partial class frmAdminAddSelectExam : Form
    {
        public frmAdminAddSelectExam()
        {
            InitializeComponent();
        }
        SqlConnection conn = BaseClass.DBCon();
        public int flag=0;
        private void frmAdminAddSelectExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmAdminManage adminManage = new frmAdminManage();
            adminManage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDaAnA.Text.Trim() == "" || txtDaAnB.Text.Trim() == "" || txtDaAnC.Text.Trim() == "" || txtDaAnD.Text.Trim() == "" || txtRightDaAn.Text.Trim() == "" || txtTimu.Text.Trim() == "")
            {
                BaseClass.Message("提示：将信息填写完整！", "警告");
            }
            else
            {
                if (flag > 0)
                {
                    string sql = "update tb_Test set subject='" + txtTimu.Text.Trim() + "',rightkey='" + txtRightDaAn.Text.Trim().ToUpper() + "',A='" + txtDaAnA.Text.Trim() + "',B='" + txtDaAnB.Text.Trim() + "',C='" + txtDaAnC.Text.Trim() + "',D='" + txtDaAnD.Text.Trim() + "' where ID="+flag;
                    BaseClass.UpdateData(sql);
                    this.Close();
                }
                else
                {
                    string sql = "insert into tb_Test(TypeID,subject,rightkey,A,B,C,D) values(1,'" + txtTimu.Text.Trim() + "','" + txtRightDaAn.Text.Trim().ToUpper() + "','" + txtDaAnA.Text.Trim() + "','" + txtDaAnB.Text.Trim() + "','" + txtDaAnC.Text.Trim() + "','" + txtDaAnD.Text.Trim() + "')";
                    BaseClass.InsertData(sql);
                    txtDaAnA.Text = "";
                    txtDaAnB.Text = "";
                    txtDaAnC.Text = "";
                    txtDaAnD.Text = "";
                    txtRightDaAn.Text = "";
                    txtTimu.Text = "";
                }
            }
        }

        private void frmAdminAddSelectExam_Load(object sender, EventArgs e)
        {
            if (flag > 0)
            {
                conn.Open();
                string sql = "select * from tb_Test where ID='"+flag+"'";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                txtTimu.Text = sdr["subject"].ToString();
                txtDaAnA.Text = sdr["A"].ToString();
                txtDaAnB.Text = sdr["B"].ToString();
                txtDaAnC.Text = sdr["C"].ToString();
                txtDaAnD.Text = sdr["D"].ToString();
                txtRightDaAn.Text = sdr["rightkey"].ToString();
                conn.Close();
            }
        }

        private void txtRightDaAn_KeyDown(object sender, KeyEventArgs e)
        {
             

        }

        private void txtRightDaAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= 'D' && e.KeyChar >= 'A' || e.KeyChar <= 'd' && e.KeyChar >= 'a') && e.KeyChar != '\r' && e.KeyChar != '\b')
            {
                e.Handled = true;   //处理KeyPress事件
            }
        }
    }
}