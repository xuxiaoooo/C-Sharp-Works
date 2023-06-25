namespace 文本编辑器
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.new新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opne打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save_as另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interface_settings界面设置UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.print打印PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undo撤销UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cut剪切TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copy复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paste粘贴PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete删除LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.find查找FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.find_next查找下一个NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replace替换RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.go_to转到GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.all全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.date时间日期DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动换行WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.font字体FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态栏SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于记事本AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1621, 851);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new新建ToolStripMenuItem,
            this.opne打开OToolStripMenuItem,
            this.save保存SToolStripMenuItem,
            this.save_as另存为AToolStripMenuItem,
            this.interface_settings界面设置UToolStripMenuItem,
            this.print打印PToolStripMenuItem,
            this.exit退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.文件FToolStripMenuItem.Text = "文件(F)";
            // 
            // new新建ToolStripMenuItem
            // 
            this.new新建ToolStripMenuItem.Name = "new新建ToolStripMenuItem";
            this.new新建ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.new新建ToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.new新建ToolStripMenuItem.Text = "新建(N)                    ";
            this.new新建ToolStripMenuItem.Click += new System.EventHandler(this.new新建ToolStripMenuItem_Click);
            // 
            // opne打开OToolStripMenuItem
            // 
            this.opne打开OToolStripMenuItem.Name = "opne打开OToolStripMenuItem";
            this.opne打开OToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.opne打开OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.opne打开OToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.opne打开OToolStripMenuItem.Text = "打开(O)...";
            this.opne打开OToolStripMenuItem.Click += new System.EventHandler(this.opne打开OToolStripMenuItem_Click);
            // 
            // save保存SToolStripMenuItem
            // 
            this.save保存SToolStripMenuItem.Name = "save保存SToolStripMenuItem";
            this.save保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save保存SToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.save保存SToolStripMenuItem.Text = "保存(S)";
            this.save保存SToolStripMenuItem.Click += new System.EventHandler(this.save保存SToolStripMenuItem_Click);
            // 
            // save_as另存为AToolStripMenuItem
            // 
            this.save_as另存为AToolStripMenuItem.Name = "save_as另存为AToolStripMenuItem";
            this.save_as另存为AToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.save_as另存为AToolStripMenuItem.Text = "另存为(A)...";
            this.save_as另存为AToolStripMenuItem.Click += new System.EventHandler(this.save_as另存为AToolStripMenuItem_Click);
            // 
            // interface_settings界面设置UToolStripMenuItem
            // 
            this.interface_settings界面设置UToolStripMenuItem.Name = "interface_settings界面设置UToolStripMenuItem";
            this.interface_settings界面设置UToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.interface_settings界面设置UToolStripMenuItem.Text = "界面设置(U)...";
            this.interface_settings界面设置UToolStripMenuItem.Click += new System.EventHandler(this.interface_settings界面设置UToolStripMenuItem_Click);
            // 
            // print打印PToolStripMenuItem
            // 
            this.print打印PToolStripMenuItem.Name = "print打印PToolStripMenuItem";
            this.print打印PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.print打印PToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.print打印PToolStripMenuItem.Text = "打印(P)...";
            this.print打印PToolStripMenuItem.Click += new System.EventHandler(this.print打印PToolStripMenuItem_Click);
            // 
            // exit退出XToolStripMenuItem
            // 
            this.exit退出XToolStripMenuItem.Name = "exit退出XToolStripMenuItem";
            this.exit退出XToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.exit退出XToolStripMenuItem.Text = "退出(X)";
            this.exit退出XToolStripMenuItem.Click += new System.EventHandler(this.exit退出XToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undo撤销UToolStripMenuItem,
            this.cut剪切TToolStripMenuItem,
            this.copy复制CToolStripMenuItem,
            this.paste粘贴PToolStripMenuItem,
            this.delete删除LToolStripMenuItem,
            this.find查找FToolStripMenuItem,
            this.find_next查找下一个NToolStripMenuItem,
            this.replace替换RToolStripMenuItem,
            this.go_to转到GToolStripMenuItem,
            this.all全选AToolStripMenuItem,
            this.date时间日期DToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.编辑EToolStripMenuItem.Text = "编辑(E)";
            // 
            // undo撤销UToolStripMenuItem
            // 
            this.undo撤销UToolStripMenuItem.Name = "undo撤销UToolStripMenuItem";
            this.undo撤销UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undo撤销UToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.undo撤销UToolStripMenuItem.Text = "撤销(U)                    ";
            this.undo撤销UToolStripMenuItem.Click += new System.EventHandler(this.undo撤销UToolStripMenuItem_Click);
            // 
            // cut剪切TToolStripMenuItem
            // 
            this.cut剪切TToolStripMenuItem.Name = "cut剪切TToolStripMenuItem";
            this.cut剪切TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cut剪切TToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.cut剪切TToolStripMenuItem.Text = "剪切(T)";
            this.cut剪切TToolStripMenuItem.Click += new System.EventHandler(this.cut剪切TToolStripMenuItem_Click);
            // 
            // copy复制CToolStripMenuItem
            // 
            this.copy复制CToolStripMenuItem.Name = "copy复制CToolStripMenuItem";
            this.copy复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy复制CToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.copy复制CToolStripMenuItem.Text = "复制(C)";
            this.copy复制CToolStripMenuItem.Click += new System.EventHandler(this.copy复制CToolStripMenuItem_Click);
            // 
            // paste粘贴PToolStripMenuItem
            // 
            this.paste粘贴PToolStripMenuItem.Name = "paste粘贴PToolStripMenuItem";
            this.paste粘贴PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste粘贴PToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.paste粘贴PToolStripMenuItem.Text = "粘贴(P)";
            this.paste粘贴PToolStripMenuItem.Click += new System.EventHandler(this.paste粘贴PToolStripMenuItem_Click);
            // 
            // delete删除LToolStripMenuItem
            // 
            this.delete删除LToolStripMenuItem.Name = "delete删除LToolStripMenuItem";
            this.delete删除LToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            this.delete删除LToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.delete删除LToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.delete删除LToolStripMenuItem.Text = "删除(L)";
            this.delete删除LToolStripMenuItem.Click += new System.EventHandler(this.delete删除LToolStripMenuItem_Click);
            // 
            // find查找FToolStripMenuItem
            // 
            this.find查找FToolStripMenuItem.Name = "find查找FToolStripMenuItem";
            this.find查找FToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.find查找FToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.find查找FToolStripMenuItem.Text = "查找(F)";
            this.find查找FToolStripMenuItem.Click += new System.EventHandler(this.find查找FToolStripMenuItem_Click);
            // 
            // find_next查找下一个NToolStripMenuItem
            // 
            this.find_next查找下一个NToolStripMenuItem.Name = "find_next查找下一个NToolStripMenuItem";
            this.find_next查找下一个NToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.find_next查找下一个NToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.find_next查找下一个NToolStripMenuItem.Text = "查找下一个(N)";
            this.find_next查找下一个NToolStripMenuItem.Click += new System.EventHandler(this.find_next查找下一个NToolStripMenuItem_Click);
            // 
            // replace替换RToolStripMenuItem
            // 
            this.replace替换RToolStripMenuItem.Name = "replace替换RToolStripMenuItem";
            this.replace替换RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replace替换RToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.replace替换RToolStripMenuItem.Text = "替换(R)...";
            this.replace替换RToolStripMenuItem.Click += new System.EventHandler(this.replace替换RToolStripMenuItem_Click);
            // 
            // go_to转到GToolStripMenuItem
            // 
            this.go_to转到GToolStripMenuItem.Name = "go_to转到GToolStripMenuItem";
            this.go_to转到GToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.go_to转到GToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.go_to转到GToolStripMenuItem.Text = "转到(G)";
            this.go_to转到GToolStripMenuItem.Click += new System.EventHandler(this.go_to转到GToolStripMenuItem_Click);
            // 
            // all全选AToolStripMenuItem
            // 
            this.all全选AToolStripMenuItem.Name = "all全选AToolStripMenuItem";
            this.all全选AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.all全选AToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.all全选AToolStripMenuItem.Text = "全选(A)";
            this.all全选AToolStripMenuItem.Click += new System.EventHandler(this.all全选AToolStripMenuItem_Click);
            // 
            // date时间日期DToolStripMenuItem
            // 
            this.date时间日期DToolStripMenuItem.Name = "date时间日期DToolStripMenuItem";
            this.date时间日期DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.date时间日期DToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.date时间日期DToolStripMenuItem.Text = "时间/日期(D)";
            this.date时间日期DToolStripMenuItem.Click += new System.EventHandler(this.date时间日期DToolStripMenuItem_Click);
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动换行WToolStripMenuItem,
            this.font字体FToolStripMenuItem});
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.格式ToolStripMenuItem.Text = "格式(O)";
            // 
            // 自动换行WToolStripMenuItem
            // 
            this.自动换行WToolStripMenuItem.Checked = true;
            this.自动换行WToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.自动换行WToolStripMenuItem.Name = "自动换行WToolStripMenuItem";
            this.自动换行WToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.自动换行WToolStripMenuItem.Text = "自动换行(W)";
            this.自动换行WToolStripMenuItem.Click += new System.EventHandler(this.自动换行WToolStripMenuItem_Click);
            // 
            // font字体FToolStripMenuItem
            // 
            this.font字体FToolStripMenuItem.Name = "font字体FToolStripMenuItem";
            this.font字体FToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.font字体FToolStripMenuItem.Text = "字体(F)...";
            this.font字体FToolStripMenuItem.Click += new System.EventHandler(this.font字体FToolStripMenuItem_Click);
            // 
            // 查看VToolStripMenuItem
            // 
            this.查看VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态栏SToolStripMenuItem});
            this.查看VToolStripMenuItem.Name = "查看VToolStripMenuItem";
            this.查看VToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.查看VToolStripMenuItem.Text = "查看(V)";
            // 
            // 状态栏SToolStripMenuItem
            // 
            this.状态栏SToolStripMenuItem.Name = "状态栏SToolStripMenuItem";
            this.状态栏SToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.状态栏SToolStripMenuItem.Text = "状态栏(S)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助HToolStripMenuItem,
            this.关于记事本AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(H)";
            // 
            // 查看帮助HToolStripMenuItem
            // 
            this.查看帮助HToolStripMenuItem.Name = "查看帮助HToolStripMenuItem";
            this.查看帮助HToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.查看帮助HToolStripMenuItem.Text = "查看帮助(H)";
            this.查看帮助HToolStripMenuItem.Click += new System.EventHandler(this.查看帮助HToolStripMenuItem_Click);
            // 
            // 关于记事本AToolStripMenuItem
            // 
            this.关于记事本AToolStripMenuItem.Name = "关于记事本AToolStripMenuItem";
            this.关于记事本AToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.关于记事本AToolStripMenuItem.Text = "关于记事本(A)";
            this.关于记事本AToolStripMenuItem.Click += new System.EventHandler(this.关于记事本AToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.查看VToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1633, 28);
            this.menuStrip2.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1633, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1633, 901);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "无标题";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem new新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opne打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save_as另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interface_settings界面设置UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem print打印PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undo撤销UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cut剪切TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copy复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paste粘贴PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delete删除LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem find查找FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem find_next查找下一个NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replace替换RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem go_to转到GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem all全选AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem date时间日期DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动换行WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem font字体FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态栏SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于记事本AToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

