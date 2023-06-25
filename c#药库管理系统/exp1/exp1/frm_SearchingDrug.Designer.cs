namespace exp1
{
    partial class frm_SearchingDrug
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
            this.btn_QueryAll = new System.Windows.Forms.Button();
            this.gbx_SelectSearchControl = new System.Windows.Forms.GroupBox();
            this.rdb_Pinyin = new System.Windows.Forms.RadioButton();
            this.rdb_Name = new System.Windows.Forms.RadioButton();
            this.rdb_No = new System.Windows.Forms.RadioButton();
            this.btn_SearchMedicine = new System.Windows.Forms.Button();
            this.txb_SearchIng = new System.Windows.Forms.TextBox();
            this.dgv_SearchMedicine = new System.Windows.Forms.DataGridView();
            this.gbx_SelectSearchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_QueryAll
            // 
            this.btn_QueryAll.Location = new System.Drawing.Point(211, 65);
            this.btn_QueryAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_QueryAll.Name = "btn_QueryAll";
            this.btn_QueryAll.Size = new System.Drawing.Size(100, 38);
            this.btn_QueryAll.TabIndex = 9;
            this.btn_QueryAll.Text = "全部";
            this.btn_QueryAll.UseVisualStyleBackColor = true;
            this.btn_QueryAll.Click += new System.EventHandler(this.btn_QueryAll_Click);
            // 
            // gbx_SelectSearchControl
            // 
            this.gbx_SelectSearchControl.Controls.Add(this.rdb_Pinyin);
            this.gbx_SelectSearchControl.Controls.Add(this.rdb_Name);
            this.gbx_SelectSearchControl.Controls.Add(this.rdb_No);
            this.gbx_SelectSearchControl.Location = new System.Drawing.Point(318, 31);
            this.gbx_SelectSearchControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_SelectSearchControl.Name = "gbx_SelectSearchControl";
            this.gbx_SelectSearchControl.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_SelectSearchControl.Size = new System.Drawing.Size(235, 85);
            this.gbx_SelectSearchControl.TabIndex = 8;
            this.gbx_SelectSearchControl.TabStop = false;
            // 
            // rdb_Pinyin
            // 
            this.rdb_Pinyin.AutoSize = true;
            this.rdb_Pinyin.Location = new System.Drawing.Point(151, 38);
            this.rdb_Pinyin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_Pinyin.Name = "rdb_Pinyin";
            this.rdb_Pinyin.Size = new System.Drawing.Size(69, 22);
            this.rdb_Pinyin.TabIndex = 2;
            this.rdb_Pinyin.TabStop = true;
            this.rdb_Pinyin.Text = "拼音";
            this.rdb_Pinyin.UseVisualStyleBackColor = true;
            // 
            // rdb_Name
            // 
            this.rdb_Name.AutoSize = true;
            this.rdb_Name.Location = new System.Drawing.Point(81, 38);
            this.rdb_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_Name.Name = "rdb_Name";
            this.rdb_Name.Size = new System.Drawing.Size(69, 22);
            this.rdb_Name.TabIndex = 1;
            this.rdb_Name.TabStop = true;
            this.rdb_Name.Text = "名称";
            this.rdb_Name.UseVisualStyleBackColor = true;
            // 
            // rdb_No
            // 
            this.rdb_No.AutoSize = true;
            this.rdb_No.Location = new System.Drawing.Point(9, 38);
            this.rdb_No.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_No.Name = "rdb_No";
            this.rdb_No.Size = new System.Drawing.Size(69, 22);
            this.rdb_No.TabIndex = 0;
            this.rdb_No.TabStop = true;
            this.rdb_No.Text = "编号";
            this.rdb_No.UseVisualStyleBackColor = true;
            // 
            // btn_SearchMedicine
            // 
            this.btn_SearchMedicine.Location = new System.Drawing.Point(802, 63);
            this.btn_SearchMedicine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SearchMedicine.Name = "btn_SearchMedicine";
            this.btn_SearchMedicine.Size = new System.Drawing.Size(90, 41);
            this.btn_SearchMedicine.TabIndex = 7;
            this.btn_SearchMedicine.Text = "查询";
            this.btn_SearchMedicine.UseVisualStyleBackColor = true;
            this.btn_SearchMedicine.Click += new System.EventHandler(this.btn_SearchMedicine_Click);
            // 
            // txb_SearchIng
            // 
            this.txb_SearchIng.BackColor = System.Drawing.SystemColors.Menu;
            this.txb_SearchIng.Location = new System.Drawing.Point(560, 63);
            this.txb_SearchIng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_SearchIng.Multiline = true;
            this.txb_SearchIng.Name = "txb_SearchIng";
            this.txb_SearchIng.Size = new System.Drawing.Size(217, 40);
            this.txb_SearchIng.TabIndex = 6;
            this.txb_SearchIng.TextChanged += new System.EventHandler(this.txb_SearchIng_TextChanged);
            // 
            // dgv_SearchMedicine
            // 
            this.dgv_SearchMedicine.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_SearchMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchMedicine.Location = new System.Drawing.Point(46, 143);
            this.dgv_SearchMedicine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_SearchMedicine.Name = "dgv_SearchMedicine";
            this.dgv_SearchMedicine.RowTemplate.Height = 27;
            this.dgv_SearchMedicine.Size = new System.Drawing.Size(970, 341);
            this.dgv_SearchMedicine.TabIndex = 10;
            this.dgv_SearchMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SearchMedicine_CellContentClick);
            // 
            // frm_SearchingDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 540);
            this.Controls.Add(this.dgv_SearchMedicine);
            this.Controls.Add(this.btn_QueryAll);
            this.Controls.Add(this.gbx_SelectSearchControl);
            this.Controls.Add(this.btn_SearchMedicine);
            this.Controls.Add(this.txb_SearchIng);
            this.Name = "frm_SearchingDrug";
            this.Text = "药品查询";
            this.gbx_SelectSearchControl.ResumeLayout(false);
            this.gbx_SelectSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_QueryAll;
        private System.Windows.Forms.GroupBox gbx_SelectSearchControl;
        private System.Windows.Forms.RadioButton rdb_Pinyin;
        private System.Windows.Forms.RadioButton rdb_Name;
        private System.Windows.Forms.RadioButton rdb_No;
        private System.Windows.Forms.Button btn_SearchMedicine;
        private System.Windows.Forms.TextBox txb_SearchIng;
        private System.Windows.Forms.DataGridView dgv_SearchMedicine;
    }
}