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
    public partial class frmTestHistory : Form
    {
        public frmTestHistory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string sql = "";
            //sql = "select ID as '系统编号',UserID as '考生考号',selectexam as '选择题',judgeexam as '判断题',Fileexam as '填空题',exampoint as '考试总分' from tb_ExamResult";
            BaseClass.DataGridViewBind(dataGridView1, sql);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
