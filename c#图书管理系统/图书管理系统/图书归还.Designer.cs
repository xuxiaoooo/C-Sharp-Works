
namespace 图书管理系统
{
    partial class 图书归还
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.readerno,
            this.operatorno,
            this.bookno,
            this.borrowtime});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(544, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            this.no.HeaderText = "编号";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // readerno
            // 
            this.readerno.DataPropertyName = "readerno";
            this.readerno.HeaderText = "读者编号";
            this.readerno.Name = "readerno";
            this.readerno.ReadOnly = true;
            // 
            // operatorno
            // 
            this.operatorno.DataPropertyName = "operatorno";
            this.operatorno.HeaderText = "操作员";
            this.operatorno.Name = "operatorno";
            this.operatorno.ReadOnly = true;
            // 
            // bookno
            // 
            this.bookno.DataPropertyName = "bookno";
            this.bookno.HeaderText = "书籍编号";
            this.bookno.Name = "bookno";
            this.bookno.ReadOnly = true;
            // 
            // borrowtime
            // 
            this.borrowtime.DataPropertyName = "borrowtime";
            this.borrowtime.HeaderText = "借出时间";
            this.borrowtime.Name = "borrowtime";
            this.borrowtime.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "确认归还";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 图书归还
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "图书归还";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书归还";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerno;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookno;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowtime;
        private System.Windows.Forms.Button button1;
    }
}