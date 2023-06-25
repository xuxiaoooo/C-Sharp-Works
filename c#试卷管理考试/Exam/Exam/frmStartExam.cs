using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
namespace Exam
{
    public partial class frmStartExam : Form
    {
        public frmStartExam()
        {
            InitializeComponent();
        }
        public string studentNumber = "";
        public string studentName = "";
        //链接数据库
        SqlConnection conn = BaseClass.DBCon();
        SqlCommand cmd;
        Label[] lbl=new Label[10];
        RadioButton[] rb=new RadioButton[100];

        public static ArrayList al = new ArrayList();
        public static ArrayList al1 = new ArrayList();
        public static ArrayList al2 = new ArrayList();

        int i = 0;
        int j = 0;
        int k = 0;

        public static string RightAns = "";
        //public static string StudentAns = "";
        public static string[] StudentAns;

        public static string RightAns1 = "";
        //public static string StudentAns1 = "";
        public static string[] StudentAns1;

        public static string[] RightAns2;
        //public static string StudentAns2 = "";
        public static string[] StudentAns2;

        int examTime;//考试总时间
        int xzNum;//选择题比例
        int xzFz;//选择题分值

        int pdNum;//判断题比例
        int pdFz;//判断题分值

        int tkNum;//填空题比例
        int tkFz;//填空题分值


        int xzflag;
        int pdflag;
        int tkflag;
        private void frmStartExam_Load(object sender, EventArgs e)
        {
            //获取基本信息
           /* conn.Open();
            cmd = new SqlCommand("select UserName from tb_User where UserName='" + studentNumber + "'", conn);
            tslStudentNum.Text = studentNumber;
            cmd = new SqlCommand("select UserCH from tb_User where UserCH='" + studentName + "'", conn);
            tslStudentName.Text = cmd.ExecuteScalar().ToString();
            conn.Close();
            */
            //获取考试总时间及相关信息
            conn.Open();
            SqlCommand cd = new SqlCommand("select *  from tb_ExamSet", conn);
            SqlDataReader sr = cd.ExecuteReader();
            sr.Read();
            examTime = Convert.ToInt32(sr[7].ToString());
            xzNum = Convert.ToInt32(sr[1].ToString());
            xzFz = Convert.ToInt32(sr[2].ToString());

            pdNum = Convert.ToInt32(sr[3].ToString());
            pdFz = Convert.ToInt32(sr[4].ToString());

            tkNum = Convert.ToInt32(sr[5].ToString());
            tkFz = Convert.ToInt32(sr[6].ToString());
            sr.Close();
            conn.Close();

            tsslExamTime.Text = examTime.ToString();
            tsslExamResultTime.Text = examTime.ToString();

            //随即产生选择题
            xzflag = xzNum / xzFz;
            conn.Open();
            string strSQL1 = "select count(*) from tb_Test where TypeID=1";// 获取数据库中选择题数量
            SqlCommand cmdx = new SqlCommand(strSQL1,conn);
            int jj =Convert.ToInt32(cmdx.ExecuteScalar());
            conn.Close();
            if (xzflag > jj)
            {
                BaseClass.Message("提示：抽取试题数量大于数据库中选择题的数量，请联系管理员向数据库中添加选择题后再来答卷！", "警告");
                this.Close();
            }
            else
            {
                StudentAns = new string[xzflag];
                for (int kk = 0; kk < StudentAns.Length; kk++)
                {
                    StudentAns[kk] = "F";
                }
                if (xzNum == 0)
                {
                    toolStripLabel17.Text = "没有抽取试题！";
                    toolStripButton8.Enabled = false;
                    toolStripButton3.Enabled = false;
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("select top " + xzflag + " * from tb_Test where TypeID=1 order by newid()", conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        al.Add(sdr[0].ToString());
                        RightAns += sdr[3].ToString().Trim();
                    }
                    sdr.Close();
                    string sql = "select * from tb_Test where ID=" + Convert.ToInt32(al[0]);
                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    SqlDataReader sdr1 = cmd1.ExecuteReader();
                    sdr1.Read();
                    txtTiMu.Text = sdr1[2].ToString();
                    txtA.Text = sdr1[4].ToString();
                    txtB.Text = sdr1[5].ToString();
                    txtC.Text = sdr1[6].ToString();
                    txtD.Text = sdr1[7].ToString();
                    conn.Close();
                    toolStripLabel17.Text = "[共有" + al.Count.ToString() + "道试题]";
                }
            }
            //随即产生判断题
            pdflag = pdNum / pdFz;
            conn.Open();
            string strSQL2 = "select count(*) from tb_Test where TypeID=2";// 获取数据库中判断题数量
            SqlCommand cmdm = new SqlCommand(strSQL2, conn);
            int dd = Convert.ToInt32(cmdm.ExecuteScalar());
            conn.Close();
            if (pdflag > dd)
            {
                BaseClass.Message("提示：抽取试题数量大于数据库中判断题的数量，请联系管理员向数据库中添加判断题后再来答卷！", "警告");
                this.Close();
            }
            else
            {
                StudentAns1 = new string[pdflag];
                for (int mm = 0; mm < StudentAns1.Length; mm++)
                {
                    StudentAns1[mm] = "F";
                }
                if (pdNum == 0)
                {
                    toolStripLabel18.Text = "没有抽取试题！";
                    toolStripButton5.Enabled = false;
                    toolStripButton9.Enabled = false;
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("select top " + pdflag + " * from tb_Test where TypeID=2 order by newid()", conn);
                    SqlDataReader sdr2 = cmd2.ExecuteReader();
                    while (sdr2.Read())
                    {
                        al1.Add(sdr2[0].ToString());
                        RightAns1 += sdr2[3].ToString().Trim();
                    }
                    sdr2.Close();
                    string sql1 = "select * from tb_Test where ID=" + Convert.ToInt32(al1[0]);
                    SqlCommand cmd3 = new SqlCommand(sql1, conn);
                    SqlDataReader sdr3 = cmd3.ExecuteReader();
                    sdr3.Read();
                    txtJudgeTimu.Text = sdr3[2].ToString();
                    conn.Close();
                    toolStripLabel18.Text = "[共有" + al1.Count.ToString() + "道试题]";
                }
            }
            //随即产生填空题
            tkflag = tkNum / tkFz;
            conn.Open();
            string strSQL3 = "select count(*) from tb_Test where TypeID=3";// 获取数据库中判断题数量
            SqlCommand cmdpp = new SqlCommand(strSQL3, conn);
            int pp= Convert.ToInt32(cmdpp.ExecuteScalar());
            conn.Close();
            if (tkflag > pp)
            {
                BaseClass.Message("提示：抽取试题数量大于数据库中填空题的数量，请联系管理员向数据库中添加填空题后再来答卷！", "警告");
                this.Close();
            }
            else
            {
                StudentAns2 = new string[tkflag];
                RightAns2 = new string[tkflag];
                for (int nn = 0; nn < StudentAns2.Length; nn++)
                {
                    StudentAns2[nn] = "F";
                }
                if (tkNum == 0)
                {
                    toolStripLabel19.Text = "没有抽取试题！";
                    toolStripButton10.Enabled = false;
                    toolStripButton7.Enabled = false;
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd4 = new SqlCommand("select top " + tkflag + " * from tb_Test where TypeID=3 order by newid()", conn);
                    SqlDataReader sdr4 = cmd4.ExecuteReader();
                    int uu = 0;
                    while (sdr4.Read())
                    {
                        al2.Add(sdr4[0].ToString());
                        RightAns2[uu] = sdr4[3].ToString().Trim();
                        uu++;
                    }
                    sdr4.Close();
                    string sql2 = "select * from tb_Test where ID=" + Convert.ToInt32(al2[0]);
                    SqlCommand cmd5 = new SqlCommand(sql2, conn);
                    SqlDataReader sdr5 = cmd5.ExecuteReader();
                    sdr5.Read();
                    txtFillTimu.Text = sdr5[2].ToString();
                    conn.Close();
                    toolStripLabel19.Text = "[共有" + al2.Count.ToString() + "道试题]";
                }
            }
        }

        #region 试题上下页按钮
        private void toolStripButton3_Click(object sender, EventArgs e)//选择题下一页
        {
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;

            i++;
            if (i == xzflag-1)
                toolStripButton3.Enabled = false;
            if (i <= al.Count - 1)
            {
                toolStripButton2.Enabled = true;
                tslNowExam.Text = Convert.ToString(i + 1);
                conn.Open();
                string sql = "select * from tb_Test where ID=" + Convert.ToInt32(al[i]);
                SqlCommand cmd1 = new SqlCommand(sql, conn);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                sdr1.Read();
                txtTiMu.Text = sdr1[2].ToString();
                txtA.Text = sdr1[4].ToString();
                txtB.Text = sdr1[5].ToString();
                txtC.Text = sdr1[6].ToString();
                txtD.Text = sdr1[7].ToString();
                sdr1.Close();
                conn.Close();
            }
            else
            {
                toolStripButton3.Enabled = false;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//选择题上一页
        {
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;
            i--;
            if (i == 0)
                toolStripButton2.Enabled = false;
            if (i >= 0)
            {
                toolStripButton3.Enabled = true;
                tslNowExam.Text = Convert.ToString(i + 1);
                conn.Open();
                string sql = "select * from tb_Test where ID=" + Convert.ToInt32(al[i]);
                SqlCommand cmd1 = new SqlCommand(sql, conn);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                sdr1.Read();
                txtTiMu.Text = sdr1[2].ToString();
                txtA.Text = sdr1[4].ToString();
                txtB.Text = sdr1[5].ToString();
                txtC.Text = sdr1[6].ToString();
                txtD.Text = sdr1[7].ToString();
                sdr1.Close();
                conn.Close();
            }
            else
            {
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = true;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)//判断题下一页
        {
            rbTrue.Checked = false;
            rbFalse.Checked = false;
            j++;
            if (j == pdflag-1)
                toolStripButton5.Enabled = false;//下一页按钮
            if (j <= al1.Count - 1)
            {
                toolStripButton4.Enabled = true;//上一页按钮
                toolStripLabel11.Text = Convert.ToString(j + 1);
                conn.Open();
                string sql = "select * from tb_Test where ID=" + Convert.ToInt32(al1[j]);
                SqlCommand cmd1 = new SqlCommand(sql, conn);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                sdr1.Read();
                txtJudgeTimu.Text = sdr1[2].ToString();
                sdr1.Close();
                conn.Close();
            }
            else
            {
                toolStripButton5.Enabled = false;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)//判断题上一页
        {
            j--;
            if (j == 0)
                toolStripButton4.Enabled = false;
            if (j >= 0)
            {
                toolStripButton5.Enabled = true;
                toolStripLabel11.Text = Convert.ToString(j + 1);
                conn.Open();
                string sql = "select * from tb_Test where ID=" + Convert.ToInt32(al1[j]);
                SqlCommand cmd1 = new SqlCommand(sql, conn);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                sdr1.Read();
                this.txtJudgeTimu.Text = sdr1[2].ToString();
                sdr1.Close();
                conn.Close();
            }
            else
            {
                toolStripButton4.Enabled = false;
                toolStripButton5.Enabled = true;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)//填空题下一页
        {
            txtFillDaAn.Text = "";
            k++;
            if (k == tkflag-1)
                toolStripButton7.Enabled = false;//下一页按钮
            if (k <= al2.Count - 1)
            {
                toolStripButton6.Enabled = true;//上一页按钮
                toolStripLabel15.Text = Convert.ToString(k + 1);
                conn.Open();
                string sql = "select * from tb_Test where ID=" + Convert.ToInt32(al2[k]);
                SqlCommand cmd1 = new SqlCommand(sql, conn);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                sdr1.Read();
                txtFillTimu.Text = sdr1[2].ToString();
                sdr1.Close();
                conn.Close();
            }
            else
            {
                toolStripButton7.Enabled = false;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)//填空题上一页
        {
            k--;
            if (k == 0)
                toolStripButton6.Enabled = false;
            if (k >= 0)
            {
                toolStripButton7.Enabled = true;
                toolStripLabel15.Text = Convert.ToString(k + 1);
                conn.Open();
                string sql = "select * from tb_Test where ID=" + Convert.ToInt32(al2[k]);
                SqlCommand cmd1 = new SqlCommand(sql, conn);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                sdr1.Read();
                txtFillTimu.Text = sdr1[2].ToString();
                sdr1.Close();
                conn.Close();
            }
            else
            {
                toolStripButton6.Enabled = false;
                toolStripButton7.Enabled = true;
            }
        }
        #endregion

        int flag = 1;
        int nowTime = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslExamNowTime.Text = flag.ToString();
            if (flag%60==0)
            {

                tsslExamPassTime.Text = nowTime.ToString();
                tsslExamResultTime.Text = Convert.ToString(Convert.ToInt32(tsslExamTime.Text.Trim()) - Convert.ToInt32(tsslExamPassTime.Text.Trim()));
                flag = 0;
                nowTime++;
            }
            if (tsslExamResultTime.Text.Trim() == "0")
            {
                timer1.Stop();
                toolStripButton1_Click(sender,e);
            }
            flag++;
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int bb=1;
            string sql = "update tb_User set IsTest=1 where UserName='" + studentNumber + "'";
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            if (tsslExamResultTime.Text.Trim() == "0")//如果剩余时间是0则说明是考试时间结束强制提交考卷
            {
                timer1.Stop();
                toolStripButton8_Click(sender, e);//选择题提交按钮
                toolStripButton9_Click(sender, e);//判断题提交按钮
                toolStripButton10_Click(sender, e);//填空题提交按钮
            }
            else                                     //否则，说明是考生自己提交考卷
            {
                if (MessageBox.Show("提示：您真的要提交考卷吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    timer1.Stop();
                    toolStripButton8_Click(sender, e);//选择题提交按钮
                    toolStripButton9_Click(sender, e);//判断题提交按钮
                    toolStripButton10_Click(sender, e);//填空题提交按钮
                }
                else
                {
                    bb =2;
                }
            }
            if (bb == 1)
            {
                int allscore = StuScore1 + StuScore2 + StuScore;
                string sql1 = "update tb_ExamResult set exampoint='" + allscore + "' where UserID='" + studentNumber + "'";
                cmd = new SqlCommand(sql1, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }

        }
        string stuAns = "";
        int StuScore = 0;//将考试成绩初始化为0
        private void toolStripButton8_Click(object sender, EventArgs e)//选择题提交按钮
        {
            for (int aa = 0; aa < StudentAns.Length; aa++)
            {
                stuAns+=StudentAns[aa].ToString();
            }
            
            for (int i = 0; i < xzflag; i++)
            {
                if (RightAns.Substring(i, 1).Equals(this.stuAns.Substring(i, 1)))//将考生答案与正确答案做比较
                {
                    StuScore += xzFz;//如果答案正确加2分
                }
            }
            string sql1 = "select * from tb_ExamResult where UserID='" + studentNumber + "'";
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql1,conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)
            {
                sdr.Close();
                cmd = new SqlCommand("update tb_ExamResult set selectexam='" + StuScore + "' where UserID='" + studentNumber + "'", conn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                sdr.Close();
                cmd = new SqlCommand("insert into tb_ExamResult(UserID,selectexam) values('" + studentNumber + "','" + StuScore + "')", conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            //MessageBox.Show(StuScore.ToString());
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            if (rbA.Checked == true)
            {
                StudentAns[i] = "A";
            }
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            if (rbB.Checked == true)
            {
                StudentAns[i] = "B";
            }
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbC.Checked == true)
            {
                StudentAns[i] = "C";
            }
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbD.Checked == true)
            {
                StudentAns[i] = "D";
            }
        }

        private void rbTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrue.Checked == true)
            {
                StudentAns1[j] = "1";
            }
        }

        private void rbFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFalse.Checked == true)
            {
                StudentAns1[j] = "0";
            }
        }

        string pdstuAns = "";
        int StuScore1 = 0;//将考试成绩初始化为0
        private void toolStripButton9_Click(object sender, EventArgs e)//判断题提交按钮
        {
            for (int aa = 0; aa <StudentAns1.Length; aa++)
            {
                pdstuAns += StudentAns1[aa].ToString();
            }
            
            for (int i = 0; i < pdflag; i++)
            {
                if (RightAns1.Substring(i, 1).Equals(pdstuAns.Substring(i, 1)))//将考生答案与正确答案做比较
                {
                    StuScore1 +=pdFz;//如果答案正确加分
                }
            }
            string sql1 = "select * from tb_ExamResult where UserID='" + studentNumber + "'";
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql1, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)
            {
                sdr.Close();
                cmd = new SqlCommand("update tb_ExamResult set judgeexam='" + StuScore1 + "' where UserID='" + studentNumber + "'", conn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                sdr.Close();
                cmd = new SqlCommand("insert into tb_ExamResult(UserID,judgeexam) values('" + studentNumber + "','" + StuScore1 + "')", conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        int StuScore2 = 0;//将考试成绩初始化为0
        private void toolStripButton10_Click(object sender, EventArgs e)//填空题提交按钮
        {
            
            for (int i = 0; i < tkflag; i++)
            {
                if (RightAns2[i]==StudentAns2[i])//将考生答案与正确答案做比较
                {
                    StuScore2 += tkflag;//如果答案正确加2分
                }
            }
            string sql1 = "select * from tb_ExamResult where UserID='" + studentNumber + "'";
            SqlConnection conn = BaseClass.DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql1, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)
            {
                sdr.Close();
                cmd = new SqlCommand("update tb_ExamResult set Fileexam='" + StuScore2 + "' where UserID='" + studentNumber + "'", conn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                sdr.Close();
                cmd = new SqlCommand("insert into tb_ExamResult(UserID,Fileexam) values('" + studentNumber + "','" + StuScore2 + "')", conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        private void frmStartExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmStudentExam studentexam = new frmStudentExam();
            studentexam.Username = studentNumber;
            studentexam.Show();
        }

        private void txtFillDaAn_TextChanged(object sender, EventArgs e)
        {
            StudentAns2[k] = txtFillDaAn.Text.Trim();
        }

    }
}