using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;



namespace Course_Design
{
    public partial class manage : Sunny.UI.UIForm
    {
        string myindex, myname, mydepartment;
        public manage()
        {
            InitializeComponent();
        }

        public manage(string index, string name, string department)
        {
            InitializeComponent();
            this.myindex = index;
            this.myname = name;
            this.mydepartment = department;

            name_label.Text = myname;
        }

        public static void ThreadProc(string index, string name, string department)
        {
            Application.Run(new manage( index,  name,  department));
        }

        public void Reload()
        {
            this.manage_Load(null, null);
        }

        private void manage_Load(object sender, EventArgs e)
        {
            string sql;
            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            sql = @"SELECT 请假信息.[员工编号]
                    ,请假信息.[请假日期]
                    ,请假信息.[请假类型编号]
                    ,请假信息.[请假开始时间]
                    ,请假信息.[请假结束时间]
                    ,请假信息.[请假累计天数]
                    ,请假信息.[请假原因描述]
                    FROM 请假信息, 普通员工信息 WHERE 普通员工信息.上级员工编号 = '{0}' AND 请假信息.确认标志 = 0 AND 普通员工信息.员工编号 = 请假信息.员工编号 AND 请假信息.确认人 <> '驳回' ";
            sql = string.Format(sql, myindex);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //通过申请
        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql;
            int result;
            SqlCommand cmd; 

            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();


            sql = "UPDATE 请假信息 SET 确认标志 = 1,确认人 = '{0}' WHERE 员工编号 = '{1}' and 请假日期 = '{2}' and 请假类型编号 = '{3}' and 请假开始时间 = '{4}' and 请假结束时间 = '{5}'";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                sql = string.Format(sql, myname, row.Cells[0].Value,
                                           row.Cells[1].Value,
                                           row.Cells[2].Value,
                                           row.Cells[3].Value,
                                           row.Cells[4].Value);
                cmd = new SqlCommand(sql, conn);
                result = cmd.ExecuteNonQuery();
                Reload();
            }
            conn.Close();

        }

        //驳回申请
        private void button3_Click(object sender, EventArgs e)
        {
            string sql;
            int result;
            SqlCommand cmd;

            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();


            sql = @"UPDATE 请假信息 SET 确认人 = '驳回'  WHERE 员工编号 = '{1}' and 请假日期 = '{2}' and 请假类型编号 = '{3}' and 请假开始时间 = '{4}' and 请假结束时间 = '{5}'";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                sql = string.Format(sql, myname, row.Cells[0].Value,
                                           row.Cells[1].Value,
                                           row.Cells[2].Value,
                                           row.Cells[3].Value,
                                           row.Cells[4].Value);
                cmd = new SqlCommand(sql, conn);
                result = cmd.ExecuteNonQuery();
                Reload();
            }
            conn.Close();
        }

        private void 员工请假记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff_vacation 员工请假记录 = new staff_vacation();
            员工请假记录.Show();
        }

        private void 普通员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display 普通员工信息 = new display("select * from 普通员工信息", "普通员工信息");
            普通员工信息.Show();
        }

        private void 请假信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display 请假信息 = new display("select * from 请假信息", "请假信息");
            请假信息.Show();
        }

        private void 请假审批ToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            System.Threading.Thread t = new System.Threading.Thread(() => ThreadProc(myindex, myname, mydepartment));
            t.Start();
            this.Close();
        }

        private void 员工信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff_information 员工信息查询 = new staff_information();
            员工信息查询.Show();
        }

        private void 数据备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql;
            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            sql = @"EXEC master..xp_cmdshell 'bcp ""SELECT * FROM 课程设计.dbo.普通员工信息"" queryout ""D:\123\data1.xls"" -c -S""localhost"" -U""sa"" -P""123456"" '";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
            sql = @"EXEC master..xp_cmdshell 'bcp ""SELECT * FROM 课程设计.dbo.部门负责人信息"" queryout ""D:\123\data2.xls"" -c -S""localhost"" -U""sa"" -P""123456"" '";
            cmd = new SqlCommand(sql, conn);
            result = cmd.ExecuteNonQuery();
            sql = @"EXEC master..xp_cmdshell 'bcp ""SELECT * FROM 课程设计.dbo.请假信息"" queryout ""D:\123\data3.xls"" -c -S""localhost"" -U""sa"" -P""123456"" '";
            cmd = new SqlCommand(sql, conn);
            result = cmd.ExecuteNonQuery();

            MessageBox.Show("备份已备份至D:/123/中。");
            conn.Close();
        }

        private void 删除员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                staff_del 删除员工信息 = new staff_del();
                删除员工信息.Show();

        }

        private void 修改员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff_update 修改员工信息 = new staff_update();
            修改员工信息.Show();
        }

        private void 添加新员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff_new 添加新员工 = new staff_new();
            添加新员工.Show();
        }

        private void 员工信息增删ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff_select 员工信息增删 = new staff_select();
            员工信息增删.Show();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sunny.UI.UIMessageBox.ShowInfo("");
        }

        private void 部门请假记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            department_vacation 部门请假记录 = new department_vacation();
            部门请假记录.Show();
        }

        private void 部门负责人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display 部门负责人信息 = new display("select * from 部门负责人信息", "部门负责人信息");
            部门负责人信息.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
