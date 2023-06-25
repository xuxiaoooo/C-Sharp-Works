using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class 图书馆管理系统 : Form
    {
        public 图书馆管理系统()
        {
            InitializeComponent();
        }

        private void 读者信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            读者信息添加 dzxxtj = new 读者信息添加();
            dzxxtj.Show();
        }

        private void 读者信息修改与删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            读者信息修改与删除 dzxxxgysc = new 读者信息修改与删除();
            dzxxxgysc.Show();
        }

        private void 图书类别增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书类别增加 tslbzj = new 图书类别增加();
            tslbzj.Show();
        }

        private void 图书类别修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书类别修改 tslbxg = new 图书类别修改();
            tslbxg.Show();
        }

        private void 图书信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书信息添加 tsxxtj = new 图书信息添加();
            tsxxtj.Show();
        }

        private void 图书信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书信息修改 tsxxxg = new 图书信息修改();
            tsxxxg.Show();
        }

        private void 图书借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书借阅 tsjy = new 图书借阅();
            tsjy.Show();
        }

        private void 图书归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书归还 tsgh = new 图书归还();
            tsgh.Show();
        }

        private void 图书搜索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书查询 tsss = new 图书查询();
            tsss.Show();
        }

        private void 更改口令ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            更改口令 ggkl = new 更改口令();
            ggkl.Show();
        }

        private void 用户添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            用户添加 yhtj = new 用户添加();
            yhtj.Show();
        }

        private void 用户修改与删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            用户修改与删除 yhxgysc = new 用户修改与删除();
            yhxgysc.Show();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void 新书订购ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            新书订阅 xsdg = new 新书订阅();
            xsdg.Show();
        }

        private void 验收新书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            验收新书 ysxs = new 验收新书();
            ysxs.Show();
        }
    }
}
