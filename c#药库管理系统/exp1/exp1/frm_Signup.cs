using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace exp1
{
    public partial class frm_Signup : Form
    {
        public frm_Signup()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = this.btn_SignUp;
        }

        private void txb_Account_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_Account.Text.Trim()))
            {
                MessageBox.Show("请先输入账号！");
                this.txb_Account.Focus();
            }
        }

        private void txb_Password_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_Password.Text) || txb_Account.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入密码！");
                this.txb_Account.Focus();
            }
        }

        private void txb_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_ConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("请再次输入您的密码！");
                this.txb_Account.Focus();
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Insert tb_User (Account, Password) values(@Account, HASHBYTES('MD5', @Password)); ";
            sqlCommand.Parameters.AddWithValue("@Account", this.txb_Account.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Password", txb_Password.Text.Trim());
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            try
            {
                sqlConnection.Open();
                int rowAffected = sqlCommand.ExecuteNonQuery();
                if (rowAffected == 1)
                {
                    MessageBox.Show("注册成功!");
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("该用户已经被注册!");
                    txb_Account.Clear();
                    txb_Password.Clear();
                    txb_ConfirmPassword.Clear();

                }
            }
            finally
            {
                sqlConnection.Close();

            }
        }
    }
}
