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
    public partial class frmAdminManage : Form
    {
        public frmAdminManage()
        {
            InitializeComponent();
        }
        public string username = "";
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAdminManage_Load(object sender, EventArgs e)
        {



        }


        private void 添加选择题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminAddSelectExam addselectexam = new frmAdminAddSelectExam();
            addselectexam.Show();
        }

        private void 添加判断题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminAddJudgeExam addjudgeExam = new frmAdminAddJudgeExam();
            addjudgeExam.Show();
        }

        private void 添加填空题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminFillExam fillexam = new frmAdminFillExam();
            fillexam.Show();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)//删除选择题
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                contextMenuStrip1.Enabled = false;
            }
            else
            {
                int MMid = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                string sql = "delete from tb_Test where ID='" + MMid + "'";
                BaseClass.DeleteData(sql);
            }
        }

        private void frmAdminManage_Activated(object sender, EventArgs e)
        {
            tsslAdmin.Text = "当前登录用户：" + username + "  用户身份：管理员";
            //检索所有的选择题
            string sql = "select ID as '系统编号',subject as '选择题题目',A as '选项A',B as '选项B',C as '选项C',D as '选项D',rightkey as '正确选项' from tb_Test where TypeID=1";
            BaseClass.DataGridViewBind(dataGridView1, sql);

            //检索所有的判断题
            string sql1 = "select ID as '系统编号',subject as '判断题题目',rightkey as '正确判断' from tb_Test where TypeID=2";
            BaseClass.DataGridViewBind(dataGridView2, sql1);
            //检索所有的填空题
            string sql2 = "select ID as '系统编号',subject as '填空题题目',rightkey as '正确答案' from tb_Test where TypeID=3";
            BaseClass.DataGridViewBind(dataGridView3, sql2);
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)//修改选择题
        {
            int MMid = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            this.Hide();
            frmAdminAddSelectExam selectexam = new frmAdminAddSelectExam();
            selectexam.flag = MMid;
            selectexam.Text = "考试管理-修改选择题";
            selectexam.button1.Text = "修改";
            selectexam.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//双击选择题的某一行弹出修改窗体
        {
            修改ToolStripMenuItem_Click(sender,e);
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)//删除判断题
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                contextMenuStrip2.Enabled = false;
            }
            else
            {
                int MMid = Convert.ToInt32(dataGridView2.SelectedCells[0].Value);
                string sql = "delete from tb_Test where ID='" + MMid + "'";
                BaseClass.DeleteData(sql);
            }
        }

        private void 修改ToolStripMenuItem1_Click(object sender, EventArgs e)//修改判断题
        {
            int MMid = Convert.ToInt32(dataGridView2.SelectedCells[0].Value);
            this.Hide();
            frmAdminAddJudgeExam judgeexam = new frmAdminAddJudgeExam();
            judgeexam.flag = MMid;
            judgeexam.Text = "考试管理-修改判断题";
            judgeexam.button1.Text = "修改";
            judgeexam.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//双击判断题的某一行弹出修改判断题窗体
        {
            修改ToolStripMenuItem1_Click(sender,e);
        }

        private void 删除ToolStripMenuItem2_Click(object sender, EventArgs e)//删除填空题
        {
            if (dataGridView3.SelectedRows.Count == 0)
            {
                contextMenuStrip3.Enabled = false;
            }
            else
            {
                int MMid = Convert.ToInt32(dataGridView3.SelectedCells[0].Value);
                string sql = "delete from tb_Test where ID='" + MMid + "'";
                BaseClass.DeleteData(sql);
            }
        }

        private void 修改ToolStripMenuItem2_Click(object sender, EventArgs e)//修改填空题
        {
            int MMid = Convert.ToInt32(dataGridView3.SelectedCells[0].Value);
            this.Hide();
            frmAdminFillExam fillexam = new frmAdminFillExam();
            fillexam.flag = MMid;
            fillexam.Text = "考试管理-修改填空题";
            fillexam.button1.Text = "修改";
            fillexam.Show();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//双击填空题的某一行弹出修改窗体
        {
            修改ToolStripMenuItem2_Click(sender,e);
        }

        private void 考试设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminExamSet adminexamset = new frmAdminExamSet();
            adminexamset.Show();
        }

        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MSINFO32.EXE");
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminFindScore findscore = new frmAdminFindScore();
            findscore.Show();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminStudent student = new frmAdminStudent();
            student.Show();
        }

        private void frmAdminManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}