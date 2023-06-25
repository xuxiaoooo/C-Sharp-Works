
namespace exp1
{
    partial class frm_Asset
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
            this.dgv_input = new System.Windows.Forms.DataGridView();
            this.btn_show = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cal = new System.Windows.Forms.Button();
            this.lb_money = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_input)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_input
            // 
            this.dgv_input.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_input.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.MedicineNo,
            this.SupplierNo,
            this.Amounts,
            this.MedicinePrice,
            this.CreationTime});
            this.dgv_input.Location = new System.Drawing.Point(12, 12);
            this.dgv_input.Name = "dgv_input";
            this.dgv_input.RowHeadersWidth = 51;
            this.dgv_input.RowTemplate.Height = 27;
            this.dgv_input.Size = new System.Drawing.Size(776, 290);
            this.dgv_input.TabIndex = 0;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(32, 354);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(105, 38);
            this.btn_show.TabIndex = 1;
            this.btn_show.Text = "查询进货内容";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "进货编号";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 125;
            // 
            // MedicineNo
            // 
            this.MedicineNo.DataPropertyName = "MedicineNo";
            this.MedicineNo.HeaderText = "药品编号";
            this.MedicineNo.MinimumWidth = 6;
            this.MedicineNo.Name = "MedicineNo";
            this.MedicineNo.Width = 125;
            // 
            // SupplierNo
            // 
            this.SupplierNo.DataPropertyName = "SupplierNo";
            this.SupplierNo.HeaderText = "药品生产商编号";
            this.SupplierNo.MinimumWidth = 6;
            this.SupplierNo.Name = "SupplierNo";
            this.SupplierNo.Width = 125;
            // 
            // Amounts
            // 
            this.Amounts.DataPropertyName = "Amounts";
            this.Amounts.HeaderText = "进货数量";
            this.Amounts.MinimumWidth = 6;
            this.Amounts.Name = "Amounts";
            this.Amounts.Width = 125;
            // 
            // MedicinePrice
            // 
            this.MedicinePrice.DataPropertyName = "MedicinePrice";
            this.MedicinePrice.HeaderText = "药品单价";
            this.MedicinePrice.MinimumWidth = 6;
            this.MedicinePrice.Name = "MedicinePrice";
            this.MedicinePrice.Width = 125;
            // 
            // CreationTime
            // 
            this.CreationTime.DataPropertyName = "CreationTime";
            this.CreationTime.HeaderText = "进货时间";
            this.CreationTime.MinimumWidth = 6;
            this.CreationTime.Name = "CreationTime";
            this.CreationTime.Width = 125;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(233, 354);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(115, 38);
            this.btn_cal.TabIndex = 2;
            this.btn_cal.Text = "计算总金额";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Location = new System.Drawing.Point(431, 366);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(0, 15);
            this.lb_money.TabIndex = 3;
            // 
            // frm_Asset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_money);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.dgv_input);
            this.Name = "frm_Asset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "资金管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicinePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationTime;
        private System.Windows.Forms.DataGridView dgv_input;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Label lb_money;
    }
}