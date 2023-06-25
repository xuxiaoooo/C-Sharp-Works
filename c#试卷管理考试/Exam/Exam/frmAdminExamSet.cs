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
    public partial class frmAdminExamSet : Form
    {
        public frmAdminExamSet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdminExamSet_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmAdminManage adminManage = new frmAdminManage();
            adminManage.Show();
        }

        private void frmAdminExamSet_Load(object sender, EventArgs e)
        {
            string sql = "select * from tb_ExamSet where ID=1";
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            cbbxz.Text=sdr[1].ToString();
            cbbxzfz.Text = sdr[2].ToString();
            cbbpd.Text = sdr[3].ToString();
            cbbpdfz.Text = sdr[4].ToString();
            cbbtk.Text = sdr[5].ToString();
            cbbtkfz.Text = sdr[6].ToString();
            txtTime.Text = sdr[7].ToString();
            sdr.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbpd.Text.Trim() == "" || cbbpdfz.Text.Trim() == "" || cbbtk.Text.Trim() == "" || cbbtkfz.Text.Trim() == "" || cbbxz.Text.Trim() == "" || cbbxzfz.Text.Trim() == "" || txtTime.Text.Trim() == "")
            {
                BaseClass.Message("提示：请设置试题的比例和分值！", "警告");
            }
            else
            {
                if ((Convert.ToInt32(cbbpd.Text.Trim()) + Convert.ToInt32(cbbxz.Text.Trim()) + Convert.ToInt32(cbbtk.Text.Trim())) != 100)
                {
                    BaseClass.Message("提示：三种类型试题的比例之和必须为100！", "警告");
                }
                else
                {
                    string xz = cbbxz.Text.Trim();
                    string xzf = cbbxzfz.Text.Trim();
                    string pd = cbbpd.Text.Trim();
                    string pdf = cbbpdfz.Text.Trim();
                    string tk = cbbtk.Text.Trim();
                    string tkf = cbbtkfz.Text.Trim();
                    string etime = txtTime.Text.Trim();
                    string sql = "update tb_ExamSet set xz='" + xz + "',xzscale='"+xzf+"',pd='"+pd+"',pdscale='"+pdf+"',tk='"+tk+"',tkscale='"+tkf+"',examtime='"+etime+"' where ID=1";
                    BaseClass.UpdateData(sql);
                    this.Close();
                }
            }
        }

        private void cbbxz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbxz.Text.Trim() == "100")
            {
                cbbxzfz.Enabled = true;
                cbbpd.Enabled = false;
                cbbpdfz.Enabled = false;
                cbbtk.Enabled = false;
                cbbtkfz.Enabled = false;

                cbbpd.Text = "0";
                cbbpdfz.Text = "1";
                cbbtk.Text = "0";
                cbbtkfz.Text = "1";
            }
            else
            {
                cbbxzfz.Enabled = true;
                cbbpd.Enabled = true;
                cbbpdfz.Enabled = true;
                cbbpd.Items.Clear();
                for (int i = 0; i <= 100 - Convert.ToInt32(cbbxz.Text.Trim()); i=i + 10)
                {
                    cbbpd.Items.Add(i);
                }
            }
        }

        private void cbbpd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k=100 - Convert.ToInt32(cbbxz.Text.Trim());
            if (cbbpd.Text.Trim() == k.ToString())
            {
                cbbtk.Enabled = false;
                cbbtkfz.Enabled = false;
                cbbtk.Text = "0";
                cbbtkfz.Text = "1";
            }
            else
            {
                cbbtk.Items.Clear();
                cbbtk.Enabled = true;
                cbbtkfz.Enabled = true;
                for (int i = 0; i <= 100 - Convert.ToInt32(cbbxz.Text.Trim())-Convert.ToInt32(cbbpd.Text.Trim()); i = i + 10)
                {
                    this.cbbtk.Items.Add(i);
                }
            }
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\r' && e.KeyChar != '\b')
            {
                e.Handled = true;   //处理KeyPress事件
            }
        }

        private void txtTime_KeyDown(object sender, KeyEventArgs e)
        {
            string a = txtTime.Text.Trim();
            if (a.Length > 0)
            {
                if (a.Substring(0, 1) == "0")
                {
                    txtTime.Text = "";
                }
            }
        }
    }
}