namespace Exam
{
    partial class frmAdminExamSet
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbxz = new System.Windows.Forms.ComboBox();
            this.cbbpd = new System.Windows.Forms.ComboBox();
            this.cbbtk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbxzfz = new System.Windows.Forms.ComboBox();
            this.cbbpdfz = new System.Windows.Forms.ComboBox();
            this.cbbtkfz = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择题比例：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "判断题比例：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "填空题比例：";
            // 
            // cbbxz
            // 
            this.cbbxz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxz.FormattingEnabled = true;
            this.cbbxz.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10",
            "0"});
            this.cbbxz.Location = new System.Drawing.Point(104, 19);
            this.cbbxz.Name = "cbbxz";
            this.cbbxz.Size = new System.Drawing.Size(55, 20);
            this.cbbxz.TabIndex = 3;
            this.cbbxz.SelectedIndexChanged += new System.EventHandler(this.cbbxz_SelectedIndexChanged);
            // 
            // cbbpd
            // 
            this.cbbpd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbpd.Enabled = false;
            this.cbbpd.FormattingEnabled = true;
            this.cbbpd.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10",
            "0"});
            this.cbbpd.Location = new System.Drawing.Point(104, 51);
            this.cbbpd.Name = "cbbpd";
            this.cbbpd.Size = new System.Drawing.Size(55, 20);
            this.cbbpd.TabIndex = 4;
            this.cbbpd.SelectedIndexChanged += new System.EventHandler(this.cbbpd_SelectedIndexChanged);
            // 
            // cbbtk
            // 
            this.cbbtk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbtk.Enabled = false;
            this.cbbtk.FormattingEnabled = true;
            this.cbbtk.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10",
            "0"});
            this.cbbtk.Location = new System.Drawing.Point(104, 84);
            this.cbbtk.Name = "cbbtk";
            this.cbbtk.Size = new System.Drawing.Size(55, 20);
            this.cbbtk.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "选择题分值：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "填空题分值：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "判断题分值：";
            // 
            // cbbxzfz
            // 
            this.cbbxzfz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxzfz.Enabled = false;
            this.cbbxzfz.FormattingEnabled = true;
            this.cbbxzfz.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10"});
            this.cbbxzfz.Location = new System.Drawing.Point(259, 19);
            this.cbbxzfz.Name = "cbbxzfz";
            this.cbbxzfz.Size = new System.Drawing.Size(55, 20);
            this.cbbxzfz.TabIndex = 12;
            // 
            // cbbpdfz
            // 
            this.cbbpdfz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbpdfz.Enabled = false;
            this.cbbpdfz.FormattingEnabled = true;
            this.cbbpdfz.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10"});
            this.cbbpdfz.Location = new System.Drawing.Point(259, 50);
            this.cbbpdfz.Name = "cbbpdfz";
            this.cbbpdfz.Size = new System.Drawing.Size(55, 20);
            this.cbbpdfz.TabIndex = 13;
            // 
            // cbbtkfz
            // 
            this.cbbtkfz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbtkfz.Enabled = false;
            this.cbbtkfz.FormattingEnabled = true;
            this.cbbtkfz.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10"});
            this.cbbtkfz.Location = new System.Drawing.Point(259, 82);
            this.cbbtkfz.Name = "cbbtkfz";
            this.cbbtkfz.Size = new System.Drawing.Size(55, 20);
            this.cbbtkfz.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "考试总时间：";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(104, 121);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(175, 21);
            this.txtTime.TabIndex = 16;
            this.txtTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTime_KeyDown);
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "分钟";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAdminExamSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(345, 204);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbtkfz);
            this.Controls.Add(this.cbbpdfz);
            this.Controls.Add(this.cbbxzfz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbtk);
            this.Controls.Add(this.cbbpd);
            this.Controls.Add(this.cbbxz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminExamSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminExamSet_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminExamSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbxz;
        private System.Windows.Forms.ComboBox cbbpd;
        private System.Windows.Forms.ComboBox cbbtk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbxzfz;
        private System.Windows.Forms.ComboBox cbbpdfz;
        private System.Windows.Forms.ComboBox cbbtkfz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}