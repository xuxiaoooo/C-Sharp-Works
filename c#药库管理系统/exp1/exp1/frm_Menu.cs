using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exp1
{
    public partial class frm_Menu : Form
    {
        private string UID;
        public frm_Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frm_Menu(string uID) : this()
        {
            this.UID = uID;
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_User frm_User = new frm_User(UID);
            frm_User.ShowDialog();
        }

        private void 药品查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_SearchingDrug frm_SearchingDrug = new frm_SearchingDrug();
            frm_SearchingDrug.ShowDialog();
            this.Show();
        }
        private void 库存基数预警ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ManagePlan frm_ManagePlan = new frm_ManagePlan();
            frm_ManagePlan.tbc_ManagePlan.SelectedTab = frm_ManagePlan.tbc_ManagePlan.TabPages[0];
            frm_ManagePlan.ShowDialog();
            this.Show();
        }



        private void 库存上限预警ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frm_ManagePlan frm_ManagePlan = new frm_ManagePlan();
            frm_ManagePlan.tbc_ManagePlan.SelectedTab = frm_ManagePlan.tbc_ManagePlan.TabPages[2];
            frm_ManagePlan.ShowDialog();
            this.Show();
        }

        private void 库存下限预警ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frm_ManagePlan frm_ManagePlan = new frm_ManagePlan();
            frm_ManagePlan.tbc_ManagePlan.SelectedTab = frm_ManagePlan.tbc_ManagePlan.TabPages[1];
            frm_ManagePlan.ShowDialog();
            this.Show();
        }

        private void 有效期管理ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frm_ManagePlan frm_ManagePlan = new frm_ManagePlan();
            frm_ManagePlan.tbc_ManagePlan.SelectedTab = frm_ManagePlan.tbc_ManagePlan.TabPages[3];
            frm_ManagePlan.ShowDialog();
            this.Show();
        }

        private void 滞留药品管理ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frm_ManagePlan frm_ManagePlan = new frm_ManagePlan();
            frm_ManagePlan.tbc_ManagePlan.SelectedTab = frm_ManagePlan.tbc_ManagePlan.TabPages[4];
            frm_ManagePlan.ShowDialog();
            this.Show();
        }

        private void 计划订单ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frm_ManagePlan frm_ManagePlan = new frm_ManagePlan();
            frm_ManagePlan.tbc_ManagePlan.SelectedTab = frm_ManagePlan.tbc_ManagePlan.TabPages[5];
            frm_ManagePlan.ShowDialog();
            this.Show();
        }

        private void 订单修改ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frm_ManagePlan frm_ManagePlan = new frm_ManagePlan();
            frm_ManagePlan.tbc_ManagePlan.SelectedTab = frm_ManagePlan.tbc_ManagePlan.TabPages[6];
            frm_ManagePlan.ShowDialog();
            this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 密码维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Password fp = new frm_Password();
            fp.Show();

        }

        private void 资金查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Asset fa = new frm_Asset();
            fa.Show();
        }

        private void 药库入库汇总报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global.i = 1;
            frm_selectall fs = new frm_selectall();
            fs.Show();
        }

        private void 药库出库汇总报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global.i = 2;
            frm_selectall fs = new frm_selectall();
            fs.Show();
        }
    }
}
