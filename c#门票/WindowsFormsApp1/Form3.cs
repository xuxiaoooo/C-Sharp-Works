using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        double[] money = new double[20];
        DateTime dt;
        double sum = 0;
        int num = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") MessageBox.Show("请先选择门票种类！", "提示");
            else
            {
                int month = dt.Month;
                if (month >= 5 && month <= 10)
                {
                    string a = comboBox1.Text;
                    int b = Convert.ToInt32(numericUpDown1.Value);
                    if (a == "普通")
                    {
                        money[num++] = 60 * b;
                    }
                    else
                    {
                        money[num++] = 60 * b * 0.5;
                    }
                }
                else
                {
                    string a = comboBox1.Text;
                    int b = Convert.ToInt32(numericUpDown1.Value);
                    if (a == "普通")
                    {
                        money[num++] = 60 * b * 0.8;
                    }
                    else
                    {
                        money[num++] = 60 * b * 0.3;
                    }
                }
                listBox1.Items.Add(comboBox1.Text + "票   " + numericUpDown1.Value + "张   " + money[num - 1] + "元");
                sum += money[num - 1];
            }
            label4.Text = "共计" + sum.ToString() + "元";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count<=0)
            {
                MessageBox.Show("请添加购买信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("您已购买成功！", "付款信息", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text=DateTime.Now.Month.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                int x = listBox1.SelectedIndex + 1;
                sum -= money[x];
                num--;
                for (int i = x; i < num; i++)
                    money[i] = money[i + 1];

            }
            else MessageBox.Show("请选择要删除的对象！", "提示！");
            label4.Text = sum.ToString() + "元";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                button1.Enabled = false;
                MessageBox.Show("请选择有效票数！", "提示！");
            }
            else button1.Enabled = true;
        }
    }
}
