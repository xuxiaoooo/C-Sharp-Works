namespace Exam
{
    partial class frmAdminStudent
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbIsTest = new System.Windows.Forms.ComboBox();
            this.txtAddUserPwd = new System.Windows.Forms.TextBox();
            this.txtAddUserZH = new System.Windows.Forms.TextBox();
            this.txtAddUserName = new System.Windows.Forms.TextBox();
            this.cbbAddUserType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddUserCancel = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbUserIsTest = new System.Windows.Forms.ComboBox();
            this.txtUserInfoPwd = new System.Windows.Forms.TextBox();
            this.txtUserInfoZH = new System.Windows.Forms.TextBox();
            this.txtUserInfoName = new System.Windows.Forms.TextBox();
            this.cbbUserType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(7, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(669, 321);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(7, 366);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(665, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本操作";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(447, 19);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "退出";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 19);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "删除用户";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 19);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "修改用户";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加用户";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(16, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 259);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(651, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 18);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbIsTest);
            this.groupBox2.Controls.Add(this.txtAddUserPwd);
            this.groupBox2.Controls.Add(this.txtAddUserZH);
            this.groupBox2.Controls.Add(this.txtAddUserName);
            this.groupBox2.Controls.Add(this.cbbAddUserType);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAddUserCancel);
            this.groupBox2.Controls.Add(this.btn_AddUser);
            this.groupBox2.Location = new System.Drawing.Point(53, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(567, 389);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加新用户";
            // 
            // cbbIsTest
            // 
            this.cbbIsTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIsTest.FormattingEnabled = true;
            this.cbbIsTest.Items.AddRange(new object[] {
            "没有参加考试",
            "已经参加考试"});
            this.cbbIsTest.Location = new System.Drawing.Point(167, 255);
            this.cbbIsTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbIsTest.Name = "cbbIsTest";
            this.cbbIsTest.Size = new System.Drawing.Size(257, 23);
            this.cbbIsTest.TabIndex = 14;
            // 
            // txtAddUserPwd
            // 
            this.txtAddUserPwd.Location = new System.Drawing.Point(168, 208);
            this.txtAddUserPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddUserPwd.Name = "txtAddUserPwd";
            this.txtAddUserPwd.Size = new System.Drawing.Size(256, 25);
            this.txtAddUserPwd.TabIndex = 13;
            // 
            // txtAddUserZH
            // 
            this.txtAddUserZH.Location = new System.Drawing.Point(168, 155);
            this.txtAddUserZH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddUserZH.Name = "txtAddUserZH";
            this.txtAddUserZH.Size = new System.Drawing.Size(256, 25);
            this.txtAddUserZH.TabIndex = 12;
            // 
            // txtAddUserName
            // 
            this.txtAddUserName.Location = new System.Drawing.Point(168, 109);
            this.txtAddUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddUserName.Name = "txtAddUserName";
            this.txtAddUserName.Size = new System.Drawing.Size(256, 25);
            this.txtAddUserName.TabIndex = 11;
            // 
            // cbbAddUserType
            // 
            this.cbbAddUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAddUserType.FormattingEnabled = true;
            this.cbbAddUserType.Items.AddRange(new object[] {
            "学生",
            "管理员"});
            this.cbbAddUserType.Location = new System.Drawing.Point(168, 64);
            this.cbbAddUserType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbAddUserType.Name = "cbbAddUserType";
            this.cbbAddUserType.Size = new System.Drawing.Size(256, 23);
            this.cbbAddUserType.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "账号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "是否已考试：";
            // 
            // btnAddUserCancel
            // 
            this.btnAddUserCancel.Location = new System.Drawing.Point(317, 315);
            this.btnAddUserCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddUserCancel.Name = "btnAddUserCancel";
            this.btnAddUserCancel.Size = new System.Drawing.Size(100, 29);
            this.btnAddUserCancel.TabIndex = 1;
            this.btnAddUserCancel.Text = "取消";
            this.btnAddUserCancel.UseVisualStyleBackColor = true;
            this.btnAddUserCancel.Click += new System.EventHandler(this.btnAddUserCancel_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(181, 315);
            this.btn_AddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(100, 29);
            this.btn_AddUser.TabIndex = 0;
            this.btn_AddUser.Text = "确定";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(5, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 418);
            this.panel3.TabIndex = 4;
            this.panel3.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbUserIsTest);
            this.groupBox3.Controls.Add(this.txtUserInfoPwd);
            this.groupBox3.Controls.Add(this.txtUserInfoZH);
            this.groupBox3.Controls.Add(this.txtUserInfoName);
            this.groupBox3.Controls.Add(this.cbbUserType);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnUserCancel);
            this.groupBox3.Controls.Add(this.btnUserInfo);
            this.groupBox3.Location = new System.Drawing.Point(45, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(567, 389);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "修改用户信息";
            // 
            // cbbUserIsTest
            // 
            this.cbbUserIsTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserIsTest.FormattingEnabled = true;
            this.cbbUserIsTest.Items.AddRange(new object[] {
            "没有参加考试",
            "已经参加考试"});
            this.cbbUserIsTest.Location = new System.Drawing.Point(167, 255);
            this.cbbUserIsTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbUserIsTest.Name = "cbbUserIsTest";
            this.cbbUserIsTest.Size = new System.Drawing.Size(257, 23);
            this.cbbUserIsTest.TabIndex = 14;
            // 
            // txtUserInfoPwd
            // 
            this.txtUserInfoPwd.Location = new System.Drawing.Point(168, 208);
            this.txtUserInfoPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserInfoPwd.Name = "txtUserInfoPwd";
            this.txtUserInfoPwd.Size = new System.Drawing.Size(256, 25);
            this.txtUserInfoPwd.TabIndex = 13;
            // 
            // txtUserInfoZH
            // 
            this.txtUserInfoZH.Location = new System.Drawing.Point(168, 155);
            this.txtUserInfoZH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserInfoZH.Name = "txtUserInfoZH";
            this.txtUserInfoZH.Size = new System.Drawing.Size(256, 25);
            this.txtUserInfoZH.TabIndex = 12;
            // 
            // txtUserInfoName
            // 
            this.txtUserInfoName.Location = new System.Drawing.Point(168, 109);
            this.txtUserInfoName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserInfoName.Name = "txtUserInfoName";
            this.txtUserInfoName.Size = new System.Drawing.Size(256, 25);
            this.txtUserInfoName.TabIndex = 11;
            // 
            // cbbUserType
            // 
            this.cbbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserType.FormattingEnabled = true;
            this.cbbUserType.Items.AddRange(new object[] {
            "学生",
            "教师"});
            this.cbbUserType.Location = new System.Drawing.Point(168, 64);
            this.cbbUserType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbUserType.Name = "cbbUserType";
            this.cbbUserType.Size = new System.Drawing.Size(256, 23);
            this.cbbUserType.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "类型：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "账号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "姓名：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 208);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "密码：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 259);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "是否已考试：";
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.Location = new System.Drawing.Point(317, 315);
            this.btnUserCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.Size = new System.Drawing.Size(100, 29);
            this.btnUserCancel.TabIndex = 1;
            this.btnUserCancel.Text = "取消";
            this.btnUserCancel.UseVisualStyleBackColor = true;
            this.btnUserCancel.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Location = new System.Drawing.Point(181, 315);
            this.btnUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(100, 29);
            this.btnUserInfo.TabIndex = 0;
            this.btnUserInfo.Text = "修改";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // frmAdminStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 434);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Activated += new System.EventHandler(this.frmAdminStudent_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminStudent_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddUserCancel;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.ComboBox cbbIsTest;
        private System.Windows.Forms.TextBox txtAddUserPwd;
        private System.Windows.Forms.TextBox txtAddUserZH;
        private System.Windows.Forms.TextBox txtAddUserName;
        private System.Windows.Forms.ComboBox cbbAddUserType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbUserIsTest;
        private System.Windows.Forms.TextBox txtUserInfoPwd;
        private System.Windows.Forms.TextBox txtUserInfoZH;
        private System.Windows.Forms.TextBox txtUserInfoName;
        private System.Windows.Forms.ComboBox cbbUserType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUserCancel;
        private System.Windows.Forms.Button btnUserInfo;
    }
}