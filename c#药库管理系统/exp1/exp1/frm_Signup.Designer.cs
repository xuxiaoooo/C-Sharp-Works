namespace exp1
{
    partial class frm_Signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_account = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Account = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "确认密码";
            // 
            // txb_ConfirmPassword
            // 
            this.txb_ConfirmPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.txb_ConfirmPassword.Location = new System.Drawing.Point(177, 185);
            this.txb_ConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_ConfirmPassword.Name = "txb_ConfirmPassword";
            this.txb_ConfirmPassword.Size = new System.Drawing.Size(224, 28);
            this.txb_ConfirmPassword.TabIndex = 17;
            this.txb_ConfirmPassword.TextChanged += new System.EventHandler(this.txb_ConfirmPassword_TextChanged);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(107, 112);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(44, 18);
            this.lbl_password.TabIndex = 16;
            this.lbl_password.Text = "密码";
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Location = new System.Drawing.Point(107, 36);
            this.lbl_account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(44, 18);
            this.lbl_account.TabIndex = 15;
            this.lbl_account.Text = "账号";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(306, 245);
            this.btn_SignUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(95, 35);
            this.btn_SignUp.TabIndex = 14;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // txb_Password
            // 
            this.txb_Password.BackColor = System.Drawing.SystemColors.Menu;
            this.txb_Password.Location = new System.Drawing.Point(177, 107);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(224, 28);
            this.txb_Password.TabIndex = 13;
            this.txb_Password.TextChanged += new System.EventHandler(this.txb_Password_TextChanged);
            // 
            // txb_Account
            // 
            this.txb_Account.BackColor = System.Drawing.SystemColors.Menu;
            this.txb_Account.Location = new System.Drawing.Point(177, 32);
            this.txb_Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Account.Name = "txb_Account";
            this.txb_Account.Size = new System.Drawing.Size(224, 28);
            this.txb_Account.TabIndex = 12;
            this.txb_Account.TextChanged += new System.EventHandler(this.txb_Account_TextChanged);
            // 
            // frm_Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_ConfirmPassword);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Account);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Signup";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_ConfirmPassword;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Account;
    }
}