namespace exp1
{
    partial class frm_LogIn
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
            this.lkb_Resign = new System.Windows.Forms.LinkLabel();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_account = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Account = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lkb_Resign
            // 
            this.lkb_Resign.AutoSize = true;
            this.lkb_Resign.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lkb_Resign.Location = new System.Drawing.Point(153, 329);
            this.lkb_Resign.Name = "lkb_Resign";
            this.lkb_Resign.Size = new System.Drawing.Size(98, 18);
            this.lkb_Resign.TabIndex = 11;
            this.lkb_Resign.TabStop = true;
            this.lkb_Resign.Text = "新用户注册";
            this.lkb_Resign.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lkb_Resign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkb_Resign_LinkClicked);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(56, 181);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(44, 18);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "密码";
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Location = new System.Drawing.Point(56, 95);
            this.lbl_account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(44, 18);
            this.lbl_account.TabIndex = 9;
            this.lbl_account.Text = "账号";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(208, 238);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(78, 35);
            this.btn_Submit.TabIndex = 8;
            this.btn_Submit.Text = "确定";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txb_Password
            // 
            this.txb_Password.BackColor = System.Drawing.SystemColors.Menu;
            this.txb_Password.Location = new System.Drawing.Point(126, 176);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(160, 28);
            this.txb_Password.TabIndex = 7;
            // 
            // txb_Account
            // 
            this.txb_Account.BackColor = System.Drawing.SystemColors.Menu;
            this.txb_Account.Location = new System.Drawing.Point(126, 90);
            this.txb_Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Account.Name = "txb_Account";
            this.txb_Account.Size = new System.Drawing.Size(160, 28);
            this.txb_Account.TabIndex = 6;
            // 
            // frm_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(397, 368);
            this.Controls.Add(this.lkb_Resign);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Account);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_LogIn";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lkb_Resign;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Account;
    }
}