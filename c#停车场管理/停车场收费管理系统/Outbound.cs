using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 停车场收费管理系统
{
    public partial class Outbound : Form
    {
        public Outbound()
        {
            InitializeComponent();
        }

        static String connetStr = "server=49.232.138.196;port=3306;user=parkingsystem;password=jHE6nzhrZm6fXHPw; database=parkingsystem;Allow User Variables=True";
        MySqlConnection conn = new MySqlConnection(connetStr);

        bill bill = new bill();
        float fees;
        float discount;
        float balance;

        private void Outbound_Load(object sender, EventArgs e)
        {
            //绑定
            try
            {
                conn.Open();
                string sql = "select * from now order by cardnumber";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("cardnumber"));
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            //查询折扣
            try
            {
                conn.Open();

                string sql = "select * from someinformation where flag = @para1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("para1", "here");

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    fees = reader.GetFloat("fees");
                    discount = reader.GetFloat("discount");
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //显示入库时间
            try
            {
                conn.Open();

                string sql = "select * from now where cardnumber = @para1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("para1", comboBox1.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                DateTime datetime = Convert.ToDateTime(reader.GetMySqlDateTime("intime"));
                dateTimePicker1.Value = datetime;

                bill.Cardnumber = comboBox1.Text;
                bill.Intime = datetime;

                reader.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            //显示用户类别
            try
            {
                conn.Open();

                string sql = "select * from vip where cardnumber = @para1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("para1", comboBox1.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                bill.calculation();

                if (reader.Read())
                {
                    textBox1.Text = "会员用户";
                    bill.Fees = bill.Fees * fees * discount;
                    textBox4.Text = bill.Fees.ToString(); 
                }
                else
                {
                    textBox1.Text = "临时用户";
                    bill.Fees = bill.Fees * fees;
                    textBox4.Text = bill.Fees.ToString(); 
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            //显示余额
            try
            {
                conn.Open();

                if (textBox1.Text == "会员用户")
                {
                    string sql = "select * from vip where cardnumber = @para1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("para1", comboBox1.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    balance = reader.GetFloat("money");
                    label5.Text = balance.ToString();

                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "会员用户")
            {
                if (balance < Convert.ToSingle(textBox4.Text))
                {
                    MessageBox.Show("余额不足!");
                }
                else
                {
                    try
                    {
                        conn.Open();

                        string sql = "update vip set money = money - @para1 where cardnumber = @para2";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("para1",Convert.ToSingle(textBox4.Text));
                        cmd.Parameters.AddWithValue("para2", comboBox1.Text);

                        int reader = cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                    try
                    {
                        conn.Open();

                        string sql = "delete from now where cardnumber = @para1";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("para1", comboBox1.Text);

                        int reader = cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                    MessageBox.Show("出库成功!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("请收取" + textBox4.Text + "元");

                try
                {
                    conn.Open();

                    string sql = "delete from now where cardnumber = @para1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("para1", comboBox1.Text);

                    int reader = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                MessageBox.Show("出库成功!");
                this.Close();
            }
        }
    }
}
