using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace exp1
{
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = this.btn_Submit;
            txb_Account.Text = "3190707001";
            txb_Password.Text = "123456";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();          //数据库链接工具实例化
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;    //将app.data中保存的链接字符串赋值给链接语句字符串
            sqlConnection.Open();                                       //打开数据库链接
            SqlCommand sqlCommand = sqlConnection.CreateCommand();      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.CommandText = $@"SELECT COUNT(1)
                                    FROM dbo.tb_User                    
                                    WHERE Account = @Account AND Password = HASHBYTES('MD5', @Password)";//指定SQL命令的命令文本；命令文本包含参数；
            #region Sql参数用法1
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@Account";
            sqlParameter.Value = this.txb_Account.Text.Trim();
            sqlParameter.SqlDbType = SqlDbType.Char;
            sqlParameter.Size = 10;
            sqlCommand.Parameters.Add(sqlParameter);
            #endregion
            #region Sql参数用法2
            sqlCommand.Parameters.AddWithValue("@Password", this.txb_Password.Text.Trim());
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            #endregion
            int Count = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (Count != 0)
            {
                global.a = txb_Account.Text;
                global.b = txb_Password.Text;
                MessageBox.Show("登陆成功！");
                frm_Menu frm_Menu = new frm_Menu(txb_Account.Text);
                frm_Menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("登陆失败!");
                this.txb_Password.Focus();                                  //密码文本框获得焦点；
                this.txb_Password.SelectAll();
            }
        }

        private void lkb_Resign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_Signup frm_Signup = new frm_Signup();
            frm_Signup.ShowDialog();
            this.Show();
        }
    }
}
