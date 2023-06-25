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
    public partial class staff_select : Sunny.UI.UIForm
    {
        public staff_select()
        {
            InitializeComponent();
        }

        private void staff_select_Load(object sender, EventArgs e)
        {

        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string change_class;

            change_class = uiComboBox1.Text;

            switch (change_class)
            {
                case "修改":
                    textBox2.ReadOnly = true;
                    textBox3.ReadOnly = false;
                    textBox4.ReadOnly = false;
                    textBox5.ReadOnly = false;
                    textBox6.ReadOnly = false;
                    textBox7.ReadOnly = false;

                    textBox2.Text = textBox1.Text;
                    break;
                case "添加":
                    textBox2.ReadOnly = false;
                    textBox3.ReadOnly = false;
                    textBox4.ReadOnly = false;
                    textBox5.ReadOnly = false;
                    textBox6.ReadOnly = false;
                    textBox7.ReadOnly = false;

                    break;
                case "删除":
                    textBox2.ReadOnly = true;
                    textBox3.ReadOnly = true;
                    textBox4.ReadOnly = true;
                    textBox5.ReadOnly = true;
                    textBox6.ReadOnly = true;
                    textBox7.ReadOnly = true;
                    break;
            }
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                SqlConnection conn = new SqlConnection(@data.s);
                conn.Open();

                sql = @"select * from 普通员工信息 where 员工编号 = '{0}'";
                sql = string.Format(sql, textBox1.Text);
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader result = cmd.ExecuteReader();

                result.Read();
                textBox2.Text = (string)result[0];
                textBox3.Text = (string)result[1];
                textBox4.Text = (string)result[2];
                textBox5.Text = (string)result[3];
                textBox6.Text = (string)result[4];
                textBox7.Text = (string)result[5];
            }
            catch
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                MessageBox.Show("未查询到结果, 请核实后重新输入!");
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string change_class, sql;
            SqlCommand cmd;
            int result;

            change_class = uiComboBox1.Text;
            SqlConnection conn = new SqlConnection(@data.s);
            conn.Open();

            switch (change_class)
            {
                case "修改":
                    sql = @"UPDATE 普通员工信息 SET 姓名 = '{0}', 上级员工编号 = '{1}', 所在部门编号 = '{2}', 账号 = '{3}', 密码 = '{4}' WHERE 员工编号 = '{5}'";
                    sql = string.Format(sql, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox1.Text);
                    cmd = new SqlCommand(sql, conn);
                    try
                    {
                        result = cmd.ExecuteNonQuery();
                        MessageBox.Show("修改成功");
                    }catch
                    {
                        MessageBox.Show("修改失败,请注意数据格式!");
                    }
                    
                    break;

                case "添加":

                    sql = @"select count(*) from 普通员工信息 where 员工编号 = '{0}'";
                    sql = string.Format(sql, textBox2.Text);
                    cmd = new SqlCommand(sql, conn);
                    string result_1 = cmd.ExecuteScalar().ToString();

                    if (result_1 == "1")
                    {
                        MessageBox.Show("该员工已存在!");
                        return;
                    }


                    sql = @"INSERT INTO 普通员工信息 VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')";
                    sql = string.Format(sql, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                    cmd = new SqlCommand(sql, conn);
                    try
                    {
                        result = cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("添加失败,请检查输入数据");
                    }
                    break;

                case "删除":
                    sql = @"DELETE FROM 普通员工信息 WHERE 员工编号 = {0}";
                    sql = string.Format(sql, textBox2.Text);
                    cmd = new SqlCommand(sql, conn);
                    try
                    {
                        result = cmd.ExecuteNonQuery();
                        MessageBox.Show("删除成功");
                    }
                    catch
                    {
                        MessageBox.Show("删除错误，请确认员工号！");
                    }
                    

                    break;
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
