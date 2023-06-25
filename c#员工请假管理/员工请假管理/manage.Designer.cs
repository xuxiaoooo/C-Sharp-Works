
namespace Course_Design
{
    partial class manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.请假审批ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工请假记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门请假记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工信息增删ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门负责人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.普通员工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请假信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new Sunny.UI.UIDataGridView();
            this.button1 = new Sunny.UI.UIButton();
            this.button3 = new Sunny.UI.UIButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.员工管理ToolStripMenuItem,
            this.数据库管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.请假审批ToolStripMenuItem,
            this.员工请假记录ToolStripMenuItem,
            this.部门请假记录ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem1.Text = "请假管理";
            // 
            // 请假审批ToolStripMenuItem
            // 
            this.请假审批ToolStripMenuItem.Name = "请假审批ToolStripMenuItem";
            this.请假审批ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.请假审批ToolStripMenuItem.Text = "请假审批";
            this.请假审批ToolStripMenuItem.Click += new System.EventHandler(this.请假审批ToolStripMenuItem_Click);
            // 
            // 员工请假记录ToolStripMenuItem
            // 
            this.员工请假记录ToolStripMenuItem.Name = "员工请假记录ToolStripMenuItem";
            this.员工请假记录ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.员工请假记录ToolStripMenuItem.Text = "员工请假记录";
            this.员工请假记录ToolStripMenuItem.Click += new System.EventHandler(this.员工请假记录ToolStripMenuItem_Click);
            // 
            // 部门请假记录ToolStripMenuItem
            // 
            this.部门请假记录ToolStripMenuItem.Name = "部门请假记录ToolStripMenuItem";
            this.部门请假记录ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.部门请假记录ToolStripMenuItem.Text = "部门请假记录";
            this.部门请假记录ToolStripMenuItem.Click += new System.EventHandler(this.部门请假记录ToolStripMenuItem_Click);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工信息查询ToolStripMenuItem,
            this.员工信息增删ToolStripMenuItem});
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            // 
            // 员工信息查询ToolStripMenuItem
            // 
            this.员工信息查询ToolStripMenuItem.Name = "员工信息查询ToolStripMenuItem";
            this.员工信息查询ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.员工信息查询ToolStripMenuItem.Text = "员工信息查询";
            this.员工信息查询ToolStripMenuItem.Click += new System.EventHandler(this.员工信息查询ToolStripMenuItem_Click);
            // 
            // 员工信息增删ToolStripMenuItem
            // 
            this.员工信息增删ToolStripMenuItem.Name = "员工信息增删ToolStripMenuItem";
            this.员工信息增删ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.员工信息增删ToolStripMenuItem.Text = "员工信息修改";
            this.员工信息增删ToolStripMenuItem.Click += new System.EventHandler(this.员工信息增删ToolStripMenuItem_Click);
            // 
            // 数据库管理ToolStripMenuItem
            // 
            this.数据库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.部门负责人信息ToolStripMenuItem,
            this.普通员工信息ToolStripMenuItem,
            this.请假信息ToolStripMenuItem});
            this.数据库管理ToolStripMenuItem.Name = "数据库管理ToolStripMenuItem";
            this.数据库管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.数据库管理ToolStripMenuItem.Text = "数据库";
            // 
            // 部门负责人信息ToolStripMenuItem
            // 
            this.部门负责人信息ToolStripMenuItem.Name = "部门负责人信息ToolStripMenuItem";
            this.部门负责人信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.部门负责人信息ToolStripMenuItem.Text = "部门负责人信息";
            this.部门负责人信息ToolStripMenuItem.Click += new System.EventHandler(this.部门负责人信息ToolStripMenuItem_Click);
            // 
            // 普通员工信息ToolStripMenuItem
            // 
            this.普通员工信息ToolStripMenuItem.Name = "普通员工信息ToolStripMenuItem";
            this.普通员工信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.普通员工信息ToolStripMenuItem.Text = "普通员工信息";
            this.普通员工信息ToolStripMenuItem.Click += new System.EventHandler(this.普通员工信息ToolStripMenuItem_Click);
            // 
            // 请假信息ToolStripMenuItem
            // 
            this.请假信息ToolStripMenuItem.Name = "请假信息ToolStripMenuItem";
            this.请假信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.请假信息ToolStripMenuItem.Text = "请假信息";
            this.请假信息ToolStripMenuItem.Click += new System.EventHandler(this.请假信息ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(248, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "请假审批";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(494, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "审批人:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name_label.Location = new System.Drawing.Point(561, 98);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(69, 20);
            this.name_label.TabIndex = 7;
            this.name_label.Text = "label3";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.dataGridView1.Location = new System.Drawing.Point(23, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectedIndex = -1;
            this.dataGridView1.ShowGridLine = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 338);
            this.dataGridView1.StripeOddColor = System.Drawing.Color.White;
            this.dataGridView1.Style = Sunny.UI.UIStyle.White;
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FillColor = System.Drawing.Color.White;
            this.button1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.button1.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.button1.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.button1.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.button1.Location = new System.Drawing.Point(674, 222);
            this.button1.MinimumSize = new System.Drawing.Size(1, 1);
            this.button1.Name = "button1";
            this.button1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.button1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Style = Sunny.UI.UIStyle.White;
            this.button1.TabIndex = 9;
            this.button1.Text = "通过";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FillColor = System.Drawing.Color.White;
            this.button3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button3.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button3.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.button3.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.button3.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.button3.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.button3.Location = new System.Drawing.Point(674, 386);
            this.button3.MinimumSize = new System.Drawing.Size(1, 1);
            this.button3.Name = "button3";
            this.button3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.button3.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.Style = Sunny.UI.UIStyle.White;
            this.button3.TabIndex = 10;
            this.button3.Text = "驳回";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 545);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "manage";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "部门负责人";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.Load += new System.EventHandler(this.manage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工信息增删ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门负责人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 普通员工信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 请假信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 请假审批ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工请假记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门请假记录ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name_label;
        private Sunny.UI.UIDataGridView dataGridView1;
        private Sunny.UI.UIButton button1;
        private Sunny.UI.UIButton button3;
    }
}