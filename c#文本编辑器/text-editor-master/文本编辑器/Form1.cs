using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 文本编辑器
{
    public partial class Form1 : Form
    {
        string localFilePath;
        public static string path;
        public Form1()
        {
            InitializeComponent();
            状态栏SToolStripMenuItem.Enabled = false;
            go_to转到GToolStripMenuItem.Enabled = false;
            interface_settings界面设置UToolStripMenuItem.Enabled = false;
            查看帮助HToolStripMenuItem.Enabled = false;
            //undo撤销UToolStripMenuItem.Enabled = false;
           // cut剪切TToolStripMenuItem.Enabled = false;
            //copy复制CToolStripMenuItem.Enabled = false;
            //paste粘贴PToolStripMenuItem.Enabled = false;
            //delete删除LToolStripMenuItem.Enabled = false;
            //find_next查找下一个NToolStripMenuItem.Enabled = false;
            this.Text = "狐仙魔法书";
        }


        private void new新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (informationData.isTextSaved == false)
            {
                op_forExit();
                informationData.isOpenFile = false;
            }
            else
            {
                this.Text = "狐仙魔法书";
                richTextBox1.Clear();
            }
        }

        private void opne打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op_open();
            informationData.isOpening = true;
        }
        //文件保存功能
        private void save保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informationData.isTextSaved = true;
            informationData.text = this.richTextBox1.Text;    //将当前文本保存到text中
            op_save();
        }
        //文件另存为功能
        private void save_as另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op_saveAs();
        }

        private void interface_settings界面设置UToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void print打印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();     //打印机会话框对象
            printDialog1.ShowDialog();
        }

        private void exit退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (informationData.isTextSaved == false)
            {
                op_forExit();
            }
            else if (informationData.isTextSaved == true)
            {
                this.Close();
            }
            if (richTextBox1.Text == "")
                this.Close();
        }

        private void undo撤销UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cut剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);//复制RTF数据到剪贴板 
            richTextBox1.SelectedRtf = "";//再把当前选取的RTF内容清除掉,当前就实现剪切功能了. 
        }

        private void copy复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);//复制RTF数据到剪贴板 
        }

        private void paste粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();//把剪贴板上的数据粘贴到目标RichTextBox 
        }

        private void delete删除LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedRtf = "";//把当前选取的RTF内容清除掉
        }

        private void find查找FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm findForm2 = new FindForm();
            findForm2.StartPosition = FormStartPosition.CenterScreen;
            findForm2.Show();
        }

        private void find_next查找下一个NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm findForm2 = new FindForm();
            findForm2.StartPosition = FormStartPosition.CenterScreen;
            findForm2.Show();
        }

        private void replace替换RToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void go_to转到GToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void all全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();//设置先焦点定位到当前活动的RichTextBox
            richTextBox1.SelectAll();
        }

        private void date时间日期DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToString());
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if(richTextBox1.SelectedText != "")
            {
                copy复制CToolStripMenuItem.Enabled = true;
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)    //记录下文本已改变
        {
            informationData.isTextChanged = true;
            if(richTextBox1.Text != informationData.text)
                informationData.isTextSaved = false;
        }
        //文件保存操作
        public void op_save()
        {
            bool temp = informationData.isTextSaved;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.InitialDirectory = "d:\\";
            MessageBox.Show(informationData.filePath);
                try
                {
                    richTextBox1.SaveFile(path, RichTextBoxStreamType.PlainText);
                    informationData.isTextChanged = false;
                    //MessageBox.Show("hi");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("文件保存失败！");            //保存失败的异常处理
                    informationData.isTextChanged = temp;
                }
        }

        public void op_saveAs()
        {
            bool temp = informationData.isTextSaved;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.InitialDirectory = "d:\\";
            saveFileDialog1.Filter = "文本文档 (*.txt)|*.txt|所有文件(*.*)|*>**";                 //设置文件类型
            saveFileDialog1.FilterIndex = 2;                //显示默认文件显示顺序
            saveFileDialog1.RestoreDirectory = true;          //记忆上次打开的目录
            DialogResult dr = saveFileDialog1.ShowDialog();
            localFilePath = saveFileDialog1.FileName.ToString();    //获取文件路径
            if (dr == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                try
                {
                    richTextBox1.SaveFile(localFilePath, RichTextBoxStreamType.PlainText);
                    //MessageBox.Show(informationData.filePath.ToString(), localFilePath.ToString());
                    informationData.isTextChanged = false;
                    informationData.text = richTextBox1.Text;
                    informationData.isTextSaved = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("文件保存失败！");            //保存失败的异常处理
                    informationData.isTextChanged = temp;
                }
            }
        }
        //文件打开操作
        public void op_open()
        {
            if(this.richTextBox1.Text == informationData.text || richTextBox1.Text == "")
            {
                informationData.isOpenFile = true;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog1.Filter = "文档文件（*.txt）|*.txt|所有文件(*.*)|*>**";     //打开文件的文件类型过滤
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                DialogResult dr = openFileDialog1.ShowDialog();
                localFilePath = openFileDialog1.FileName.ToString();
                informationData.filePath = openFileDialog1.FileName;    //存储下打开文件的文件路径，用于保存时对源文件进行修改
                path = openFileDialog1.FileName;
                if (dr == DialogResult.OK)
                {
                    string temp = richTextBox1.Text;
                    try
                    {
                        richTextBox1.Clear();     //清除原来的文本
                        StreamReader st = new StreamReader(informationData.filePath, Encoding.GetEncoding("gb2312"));
                        richTextBox1.Text = st.ReadToEnd();    //读取文本内容
                        st.Dispose();
                        this.Text = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);  //修改文本文件名
                        informationData.isTextChanged = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("打开文件出错：" + ex.Message);
                        richTextBox1.Text = temp;    //恢复文本内容 
                        informationData.isOpenFile = false;
                    }
                }
            }
            else
            {
                op_forExit();
            }
        }
        //文件在新建和打开时，当前文件未保存时的处理
        public void op_forExit()
        {
            string name = this.Text;
            if(richTextBox1.Text != "")
            {
                DialogResult result = MessageBox.Show("                             是否将更改保存到" + name, "狐仙魔法书", MessageBoxButtons.YesNoCancel);
                switch (result)       //用户不同选择的处理
                {
                    case DialogResult.Yes:     //保存
                        op_saveAs();
                        break;
                    case DialogResult.No:
                        this.Text = "新建文本文档";
                        this.richTextBox1.Clear();
                        break;
                    case DialogResult.Cancel:    //取消，什么都不做
                        break;
                }
                informationData.isOpening = false;
            }
        }

        private void font字体FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FontForm fontform = new FontForm();
            //fontform.StartPosition = FormStartPosition.CenterParent;
            //fontform.Show();
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)      //调用字体对话框设置字体
            {
                richTextBox1.Font = fontDialog.Font;
                richTextBox1.ForeColor = fontDialog.Color;
            }
        }

        private void 查看帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 自动换行WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行WToolStripMenuItem.Checked == false)
            {
                自动换行WToolStripMenuItem.Checked = true;
                richTextBox1.Multiline = true;
            }
            else
                自动换行WToolStripMenuItem.Checked = false;
        }

        private void 关于记事本AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎使用狐仙魔法书，祝您使用愉快！");
        }

        public void Form1_MounseDown(Object sender,MouseEventArgs e)
        {
            MessageBox.Show("单击成功！");
        }
    }
}
