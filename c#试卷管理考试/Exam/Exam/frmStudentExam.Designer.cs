namespace Exam
{
    partial class frmStudentExam
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始考试SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始考试SToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.选项XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询分数SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考试历史ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SToolStripMenuItem,
            this.选项XToolStripMenuItem,
            this.考试历史ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1155, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SToolStripMenuItem
            // 
            this.SToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始考试SToolStripMenuItem,
            this.退出系统OToolStripMenuItem,
            this.开始考试SToolStripMenuItem1});
            this.SToolStripMenuItem.Name = "SToolStripMenuItem";
            this.SToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.SToolStripMenuItem.Text = "学生考试(&S)";
            this.SToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SToolStripMenuItem.Click += new System.EventHandler(this.文件FToolStripMenuItem_Click);
            // 
            // 开始考试SToolStripMenuItem
            // 
            this.开始考试SToolStripMenuItem.Name = "开始考试SToolStripMenuItem";
            this.开始考试SToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.开始考试SToolStripMenuItem.Text = "开始考试(&S)";
            this.开始考试SToolStripMenuItem.Click += new System.EventHandler(this.开始考试SToolStripMenuItem1_Click);
            // 
            // 退出系统OToolStripMenuItem
            // 
            this.退出系统OToolStripMenuItem.Name = "退出系统OToolStripMenuItem";
            this.退出系统OToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.退出系统OToolStripMenuItem.Text = "退出系统(&Q)";
            this.退出系统OToolStripMenuItem.Click += new System.EventHandler(this.退出系统OToolStripMenuItem_Click);
            // 
            // 开始考试SToolStripMenuItem1
            // 
            this.开始考试SToolStripMenuItem1.Name = "开始考试SToolStripMenuItem1";
            this.开始考试SToolStripMenuItem1.Size = new System.Drawing.Size(160, 24);
            this.开始考试SToolStripMenuItem1.Text = "开始考试(S)";
            this.开始考试SToolStripMenuItem1.Click += new System.EventHandler(this.开始考试SToolStripMenuItem1_Click);
            // 
            // 选项XToolStripMenuItem
            // 
            this.选项XToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码CToolStripMenuItem,
            this.查询分数SToolStripMenuItem});
            this.选项XToolStripMenuItem.Name = "选项XToolStripMenuItem";
            this.选项XToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.选项XToolStripMenuItem.Text = "信息管理(&X)";
            // 
            // 修改密码CToolStripMenuItem
            // 
            this.修改密码CToolStripMenuItem.Name = "修改密码CToolStripMenuItem";
            this.修改密码CToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.修改密码CToolStripMenuItem.Text = "修改密码(&P)";
            this.修改密码CToolStripMenuItem.Click += new System.EventHandler(this.修改密码CToolStripMenuItem_Click);
            // 
            // 查询分数SToolStripMenuItem
            // 
            this.查询分数SToolStripMenuItem.Name = "查询分数SToolStripMenuItem";
            this.查询分数SToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.查询分数SToolStripMenuItem.Text = "查询分数(&S)";
            this.查询分数SToolStripMenuItem.Click += new System.EventHandler(this.查询分数SToolStripMenuItem_Click);
            // 
            // 考试历史ToolStripMenuItem
            // 
            this.考试历史ToolStripMenuItem.Name = "考试历史ToolStripMenuItem";
            this.考试历史ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.考试历史ToolStripMenuItem.Text = "考试历史";
            this.考试历史ToolStripMenuItem.Click += new System.EventHandler(this.考试历史ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统信息ToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 系统信息ToolStripMenuItem
            // 
            this.系统信息ToolStripMenuItem.Name = "系统信息ToolStripMenuItem";
            this.系统信息ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.系统信息ToolStripMenuItem.Text = "系统信息";
            this.系统信息ToolStripMenuItem.Click += new System.EventHandler(this.系统信息ToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 667);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1155, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Exam.Properties.Resources.学生登录成功窗体;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1155, 639);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmStudentExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 689);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试系统";
            this.Activated += new System.EventHandler(this.frmStudentExam_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStudentExam_FormClosed);
            this.Load += new System.EventHandler(this.frmStudentExam_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出系统OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询分数SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统信息ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 开始考试SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考试历史ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始考试SToolStripMenuItem1;
       
    }
}