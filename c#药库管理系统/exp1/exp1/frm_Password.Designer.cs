
namespace exp1
{
    partial class frm_Password
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_old = new System.Windows.Forms.TextBox();
            this.txb_new = new System.Windows.Forms.TextBox();
            this.txb_check = new System.Windows.Forms.TextBox();
            this.btn_modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            // 
            // txb_old
            // 
            this.txb_old.Location = new System.Drawing.Point(316, 51);
            this.txb_old.Name = "txb_old";
            this.txb_old.Size = new System.Drawing.Size(165, 25);
            this.txb_old.TabIndex = 3;
            // 
            // txb_new
            // 
            this.txb_new.Location = new System.Drawing.Point(316, 123);
            this.txb_new.Name = "txb_new";
            this.txb_new.Size = new System.Drawing.Size(165, 25);
            this.txb_new.TabIndex = 4;
            // 
            // txb_check
            // 
            this.txb_check.Location = new System.Drawing.Point(316, 181);
            this.txb_check.Name = "txb_check";
            this.txb_check.Size = new System.Drawing.Size(165, 25);
            this.txb_check.TabIndex = 5;
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(294, 252);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(117, 35);
            this.btn_modify.TabIndex = 6;
            this.btn_modify.Text = "修改";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // frm_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(718, 331);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.txb_check);
            this.Controls.Add(this.txb_new);
            this.Controls.Add(this.txb_old);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码维护";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_old;
        private System.Windows.Forms.TextBox txb_new;
        private System.Windows.Forms.TextBox txb_check;
        private System.Windows.Forms.Button btn_modify;
    }
}