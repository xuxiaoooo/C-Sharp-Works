namespace Exam
{
    partial class frmTestHistory
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
            this.考生姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.考生学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.考生科目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.考试时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.考试科目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.考试成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.考生姓名,
            this.考生学号,
            this.考生科目,
            this.考试时间,
            this.考试科目,
            this.考试成绩});
            this.dataGridView1.Location = new System.Drawing.Point(23, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(483, 155);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 考生姓名
            // 
            this.考生姓名.HeaderText = "考生姓名";
            this.考生姓名.Name = "考生姓名";
            // 
            // 考生学号
            // 
            this.考生学号.HeaderText = "考生学号";
            this.考生学号.Name = "考生学号";
            // 
            // 考生科目
            // 
            this.考生科目.HeaderText = "考生科目";
            this.考生科目.Name = "考生科目";
            // 
            // 考试时间
            // 
            this.考试时间.HeaderText = "考试时间";
            this.考试时间.Name = "考试时间";
            // 
            // 考试科目
            // 
            this.考试科目.HeaderText = "考试科目";
            this.考试科目.Name = "考试科目";
            // 
            // 考试成绩
            // 
            this.考试成绩.HeaderText = "考试成绩";
            this.考试成绩.Name = "考试成绩";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(112, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "模拟考试历史记录";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmTestHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(553, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTestHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试历史";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 考生姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 考生学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 考生科目;
        private System.Windows.Forms.DataGridViewTextBoxColumn 考试时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 考试科目;
        private System.Windows.Forms.DataGridViewTextBoxColumn 考试成绩;
    }
}