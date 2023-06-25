namespace exp1
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_UserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_PlanManage = new System.Windows.Forms.ToolStripMenuItem();
            this.库存基数预警ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存上限预警ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存下限预警ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.有效期管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.滞留药品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_StorageManage = new System.Windows.Forms.ToolStripMenuItem();
            this.药品查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_FundingManage = new System.Windows.Forms.ToolStripMenuItem();
            this.资金查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_FormAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.药库入库汇总报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.药库出库汇总报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_DataMent = new System.Windows.Forms.ToolStripMenuItem();
            this.密码维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ReceiptManage = new System.Windows.Forms.ToolStripMenuItem();
            this.入库开单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直接入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_DrugAdjust = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_UserInfo,
            this.tsm_PlanManage,
            this.tsm_StorageManage,
            this.tsm_FundingManage,
            this.tsm_FormAdd,
            this.tsm_DataMent,
            this.tsm_ReceiptManage,
            this.tsm_DrugAdjust});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(970, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsm_UserInfo
            // 
            this.tsm_UserInfo.Name = "tsm_UserInfo";
            this.tsm_UserInfo.Size = new System.Drawing.Size(83, 24);
            this.tsm_UserInfo.Text = "个人信息";
            this.tsm_UserInfo.Click += new System.EventHandler(this.个人信息ToolStripMenuItem_Click);
            // 
            // tsm_PlanManage
            // 
            this.tsm_PlanManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.库存基数预警ToolStripMenuItem,
            this.库存上限预警ToolStripMenuItem,
            this.库存下限预警ToolStripMenuItem,
            this.有效期管理ToolStripMenuItem,
            this.滞留药品管理ToolStripMenuItem});
            this.tsm_PlanManage.Name = "tsm_PlanManage";
            this.tsm_PlanManage.Size = new System.Drawing.Size(83, 24);
            this.tsm_PlanManage.Text = "计划管理";
            // 
            // 库存基数预警ToolStripMenuItem
            // 
            this.库存基数预警ToolStripMenuItem.Name = "库存基数预警ToolStripMenuItem";
            this.库存基数预警ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.库存基数预警ToolStripMenuItem.Text = "库存基数预警";
            this.库存基数预警ToolStripMenuItem.Click += new System.EventHandler(this.库存基数预警ToolStripMenuItem_Click);
            // 
            // 库存上限预警ToolStripMenuItem
            // 
            this.库存上限预警ToolStripMenuItem.Name = "库存上限预警ToolStripMenuItem";
            this.库存上限预警ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.库存上限预警ToolStripMenuItem.Text = "库存上限预警";
            this.库存上限预警ToolStripMenuItem.Click += new System.EventHandler(this.库存上限预警ToolStripMenuItem_Click_1);
            // 
            // 库存下限预警ToolStripMenuItem
            // 
            this.库存下限预警ToolStripMenuItem.Name = "库存下限预警ToolStripMenuItem";
            this.库存下限预警ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.库存下限预警ToolStripMenuItem.Text = "库存下限预警";
            this.库存下限预警ToolStripMenuItem.Click += new System.EventHandler(this.库存下限预警ToolStripMenuItem_Click_1);
            // 
            // 有效期管理ToolStripMenuItem
            // 
            this.有效期管理ToolStripMenuItem.Name = "有效期管理ToolStripMenuItem";
            this.有效期管理ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.有效期管理ToolStripMenuItem.Text = "有效期管理";
            this.有效期管理ToolStripMenuItem.Click += new System.EventHandler(this.有效期管理ToolStripMenuItem_Click_1);
            // 
            // 滞留药品管理ToolStripMenuItem
            // 
            this.滞留药品管理ToolStripMenuItem.Name = "滞留药品管理ToolStripMenuItem";
            this.滞留药品管理ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.滞留药品管理ToolStripMenuItem.Text = "滞留药品管理";
            this.滞留药品管理ToolStripMenuItem.Click += new System.EventHandler(this.滞留药品管理ToolStripMenuItem_Click_1);
            // 
            // tsm_StorageManage
            // 
            this.tsm_StorageManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.药品查询ToolStripMenuItem});
            this.tsm_StorageManage.Name = "tsm_StorageManage";
            this.tsm_StorageManage.Size = new System.Drawing.Size(83, 24);
            this.tsm_StorageManage.Text = "药库盘点";
            // 
            // 药品查询ToolStripMenuItem
            // 
            this.药品查询ToolStripMenuItem.Name = "药品查询ToolStripMenuItem";
            this.药品查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.药品查询ToolStripMenuItem.Text = "药品查询";
            this.药品查询ToolStripMenuItem.Click += new System.EventHandler(this.药品查询ToolStripMenuItem_Click);
            // 
            // tsm_FundingManage
            // 
            this.tsm_FundingManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.资金查询ToolStripMenuItem});
            this.tsm_FundingManage.Name = "tsm_FundingManage";
            this.tsm_FundingManage.Size = new System.Drawing.Size(83, 24);
            this.tsm_FundingManage.Text = "资金管理";
            // 
            // 资金查询ToolStripMenuItem
            // 
            this.资金查询ToolStripMenuItem.Name = "资金查询ToolStripMenuItem";
            this.资金查询ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.资金查询ToolStripMenuItem.Text = "资金查询";
            this.资金查询ToolStripMenuItem.Click += new System.EventHandler(this.资金查询ToolStripMenuItem_Click);
            // 
            // tsm_FormAdd
            // 
            this.tsm_FormAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.药库入库汇总报表ToolStripMenuItem,
            this.药库出库汇总报表ToolStripMenuItem});
            this.tsm_FormAdd.Name = "tsm_FormAdd";
            this.tsm_FormAdd.Size = new System.Drawing.Size(83, 24);
            this.tsm_FormAdd.Text = "统计报表";
            // 
            // 药库入库汇总报表ToolStripMenuItem
            // 
            this.药库入库汇总报表ToolStripMenuItem.Name = "药库入库汇总报表ToolStripMenuItem";
            this.药库入库汇总报表ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.药库入库汇总报表ToolStripMenuItem.Text = "药库入库汇总报表";
            this.药库入库汇总报表ToolStripMenuItem.Click += new System.EventHandler(this.药库入库汇总报表ToolStripMenuItem_Click);
            // 
            // 药库出库汇总报表ToolStripMenuItem
            // 
            this.药库出库汇总报表ToolStripMenuItem.Name = "药库出库汇总报表ToolStripMenuItem";
            this.药库出库汇总报表ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.药库出库汇总报表ToolStripMenuItem.Text = "药库出库汇总报表";
            this.药库出库汇总报表ToolStripMenuItem.Click += new System.EventHandler(this.药库出库汇总报表ToolStripMenuItem_Click);
            // 
            // tsm_DataMent
            // 
            this.tsm_DataMent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.密码维护ToolStripMenuItem});
            this.tsm_DataMent.Name = "tsm_DataMent";
            this.tsm_DataMent.Size = new System.Drawing.Size(83, 24);
            this.tsm_DataMent.Text = "数据维护";
            // 
            // 密码维护ToolStripMenuItem
            // 
            this.密码维护ToolStripMenuItem.Name = "密码维护ToolStripMenuItem";
            this.密码维护ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.密码维护ToolStripMenuItem.Text = "密码维护";
            this.密码维护ToolStripMenuItem.Click += new System.EventHandler(this.密码维护ToolStripMenuItem_Click);
            // 
            // tsm_ReceiptManage
            // 
            this.tsm_ReceiptManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入库开单ToolStripMenuItem,
            this.直接入库ToolStripMenuItem});
            this.tsm_ReceiptManage.Name = "tsm_ReceiptManage";
            this.tsm_ReceiptManage.Size = new System.Drawing.Size(83, 24);
            this.tsm_ReceiptManage.Text = "单据处理";
            // 
            // 入库开单ToolStripMenuItem
            // 
            this.入库开单ToolStripMenuItem.Name = "入库开单ToolStripMenuItem";
            this.入库开单ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.入库开单ToolStripMenuItem.Text = "入库开单";
            // 
            // 直接入库ToolStripMenuItem
            // 
            this.直接入库ToolStripMenuItem.Name = "直接入库ToolStripMenuItem";
            this.直接入库ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.直接入库ToolStripMenuItem.Text = "直接入库";
            // 
            // tsm_DrugAdjust
            // 
            this.tsm_DrugAdjust.Name = "tsm_DrugAdjust";
            this.tsm_DrugAdjust.Size = new System.Drawing.Size(83, 24);
            this.tsm_DrugAdjust.Text = "药品调价";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(246, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎登录药库管理系统！";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 259);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(805, 29);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(970, 431);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Menu";
            this.Text = "菜单";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_PlanManage;
        private System.Windows.Forms.ToolStripMenuItem tsm_ReceiptManage;
        private System.Windows.Forms.ToolStripMenuItem tsm_FundingManage;
        private System.Windows.Forms.ToolStripMenuItem tsm_StorageManage;
        private System.Windows.Forms.ToolStripMenuItem tsm_DrugAdjust;
        private System.Windows.Forms.ToolStripMenuItem tsm_FormAdd;
        private System.Windows.Forms.ToolStripMenuItem tsm_DataMent;
        private System.Windows.Forms.ToolStripMenuItem tsm_UserInfo;
        private System.Windows.Forms.ToolStripMenuItem 库存基数预警ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存上限预警ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存下限预警ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 有效期管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 滞留药品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 药品查询ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem 入库开单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直接入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 资金查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 药库入库汇总报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 药库出库汇总报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 密码维护ToolStripMenuItem;
    }
}