using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Environment;


namespace exp1
{
    public partial class frm_User : Form
    {
        private string UId;
        public frm_User()
        {
            InitializeComponent();
        }
        public frm_User(string Uid) : this()
        {
            UId = Uid;
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();
            pbx_UPicture.Image.Save(memoryStream, ImageFormat.Bmp);
            byte[] PhotoBytes = new byte[memoryStream.Length];
            memoryStream.Seek(0, SeekOrigin.Begin);
            memoryStream.Read(PhotoBytes, 0, PhotoBytes.Length);

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "UPDATE dbo.tb_User SET Uname=@Uname,Gender=@Gender,BirthDate=@BirthDate,Photo=@Photo,SectionOfficeNo=@SectionOfficeNo WHERE Account = @Account";
            sqlCommand.Parameters.AddWithValue("@Uname", txb_UName.Text);
            sqlCommand.Parameters.AddWithValue("@Gender", rdb_Male.Checked);
            sqlCommand.Parameters.AddWithValue("@Account", txb_UId.Text);
            sqlCommand.Parameters.AddWithValue("@BirthDate", dtp_BirthDate.Value);
            sqlCommand.Parameters.AddWithValue("@Photo", PhotoBytes);
            sqlCommand.Parameters.AddWithValue("@SectionOfficeNo", cmb_SectionOffice.SelectedValue);
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show($"更新了{rowAffected}行。");
        }

        private void lbl_OpenPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "请打开图片",
                InitialDirectory = Environment.SpecialFolder.MyPictures.ToString(),
                Filter = "图像文件|*.jpg;*.png;*.bmp"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lbl_OpenPicture.Visible = false;
                string fileName = openFileDialog.FileName;
                this.pbx_UPicture.Image = Image.FromFile(fileName);
            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM dbo.tb_User WHERE dbo.tb_User.Account = @Account";
            sqlCommand2.CommandText = "SELECT * FROM dbo.tb_SectionOffice";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand2;
            DataTable SectionOfficeTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(SectionOfficeTable);
            this.cmb_SectionOffice.DataSource = SectionOfficeTable;
            this.cmb_SectionOffice.DisplayMember = "Name";
            this.cmb_SectionOffice.ValueMember = "No";
            sqlCommand.Parameters.AddWithValue("@Account", UId);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            byte[] photoBytes = null;
            if (sqlDataReader.Read())
            {
                txb_UId.Text = sqlDataReader["Account"].ToString();
                txb_UName.Text = sqlDataReader["UName"].ToString();
                rdb_Male.Checked = (bool)sqlDataReader["Gender"];
                rdb_Female.Checked = !rdb_Male.Checked;
                dtp_BirthDate.Value = (DateTime)sqlDataReader["BirthDate"];
                cmb_SectionOffice.SelectedValue = (int)sqlDataReader["SectionOfficeNo"];
                //Encoding encoding = Encoding.UTF8;
                photoBytes = (sqlDataReader["Photo"] == DBNull.Value ? null : (byte[])(sqlDataReader["Photo"]));
            }
            sqlDataReader.Close();
            if (photoBytes != null)
            {
                this.lbl_OpenPicture.Visible = false;
                MemoryStream memoryStream = new MemoryStream(photoBytes);
                this.pbx_UPicture.Image = Image.FromStream(memoryStream);
            }
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menu frm_Menu = new frm_Menu(UId);
            frm_Menu.ShowDialog();
        }
    }
}

