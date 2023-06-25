namespace exp1
{
    partial class frm_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_UId = new System.Windows.Forms.TextBox();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_UName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbx_UPicture = new System.Windows.Forms.PictureBox();
            this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.cmb_SectionOffice = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Main = new System.Windows.Forms.Button();
            this.lbl_OpenPicture = new System.Windows.Forms.LinkLabel();
            this.btn_Query = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_UPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_UId
            // 
            this.txb_UId.Location = new System.Drawing.Point(163, 35);
            this.txb_UId.Name = "txb_UId";
            this.txb_UId.ReadOnly = true;
            this.txb_UId.Size = new System.Drawing.Size(173, 28);
            this.txb_UId.TabIndex = 0;
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Location = new System.Drawing.Point(36, 45);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(44, 18);
            this.lbl_Account.TabIndex = 1;
            this.lbl_Account.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "生日";
            // 
            // txb_UName
            // 
            this.txb_UName.Location = new System.Drawing.Point(163, 192);
            this.txb_UName.Name = "txb_UName";
            this.txb_UName.Size = new System.Drawing.Size(173, 28);
            this.txb_UName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "所属科室";
            // 
            // pbx_UPicture
            // 
            this.pbx_UPicture.Location = new System.Drawing.Point(442, 26);
            this.pbx_UPicture.Name = "pbx_UPicture";
            this.pbx_UPicture.Size = new System.Drawing.Size(213, 263);
            this.pbx_UPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_UPicture.TabIndex = 10;
            this.pbx_UPicture.TabStop = false;
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.Location = new System.Drawing.Point(163, 355);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.Size = new System.Drawing.Size(200, 28);
            this.dtp_BirthDate.TabIndex = 11;
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.Location = new System.Drawing.Point(178, 267);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(51, 22);
            this.rdb_Male.TabIndex = 12;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "男";
            this.rdb_Male.UseVisualStyleBackColor = true;
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.Location = new System.Drawing.Point(178, 306);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(51, 22);
            this.rdb_Female.TabIndex = 13;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "女";
            this.rdb_Female.UseVisualStyleBackColor = true;
            // 
            // cmb_SectionOffice
            // 
            this.cmb_SectionOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SectionOffice.FormattingEnabled = true;
            this.cmb_SectionOffice.Location = new System.Drawing.Point(163, 116);
            this.cmb_SectionOffice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_SectionOffice.Name = "cmb_SectionOffice";
            this.cmb_SectionOffice.Size = new System.Drawing.Size(163, 26);
            this.cmb_SectionOffice.TabIndex = 15;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(553, 306);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(114, 46);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Main
            // 
            this.btn_Main.Location = new System.Drawing.Point(609, 392);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(114, 46);
            this.btn_Main.TabIndex = 17;
            this.btn_Main.Text = "主菜单";
            this.btn_Main.UseVisualStyleBackColor = true;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // lbl_OpenPicture
            // 
            this.lbl_OpenPicture.AutoSize = true;
            this.lbl_OpenPicture.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_OpenPicture.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_OpenPicture.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_OpenPicture.Location = new System.Drawing.Point(493, 141);
            this.lbl_OpenPicture.Name = "lbl_OpenPicture";
            this.lbl_OpenPicture.Size = new System.Drawing.Size(108, 44);
            this.lbl_OpenPicture.TabIndex = 18;
            this.lbl_OpenPicture.TabStop = true;
            this.lbl_OpenPicture.Text = "open";
            this.lbl_OpenPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_OpenPicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_OpenPicture_LinkClicked);
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(433, 306);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(114, 46);
            this.btn_Query.TabIndex = 19;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.lbl_OpenPicture);
            this.Controls.Add(this.btn_Main);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_SectionOffice);
            this.Controls.Add(this.rdb_Female);
            this.Controls.Add(this.rdb_Male);
            this.Controls.Add(this.dtp_BirthDate);
            this.Controls.Add(this.pbx_UPicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_UName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Account);
            this.Controls.Add(this.txb_UId);
            this.Name = "frm_User";
            this.Text = "用户";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_UPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_UId;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_UName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbx_UPicture;
        private System.Windows.Forms.DateTimePicker dtp_BirthDate;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.ComboBox cmb_SectionOffice;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.LinkLabel lbl_OpenPicture;
        private System.Windows.Forms.Button btn_Query;
    }
}