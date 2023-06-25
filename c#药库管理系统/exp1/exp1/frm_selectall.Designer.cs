
namespace exp1
{
    partial class frm_selectall
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
            this.dgv_fun1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_fun2 = new System.Windows.Forms.DataGridView();
            this.No1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amounts1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicinePrice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fun1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fun2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_fun1
            // 
            this.dgv_fun1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fun1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.MedicineNo,
            this.SupplierNo,
            this.Amounts,
            this.MedicinePrice,
            this.CreationTime});
            this.dgv_fun1.Location = new System.Drawing.Point(12, 12);
            this.dgv_fun1.Name = "dgv_fun1";
            this.dgv_fun1.RowHeadersWidth = 51;
            this.dgv_fun1.RowTemplate.Height = 27;
            this.dgv_fun1.Size = new System.Drawing.Size(775, 291);
            this.dgv_fun1.TabIndex = 0;
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
            this.SupplierNo.HeaderText = "供应商编号";
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
            this.CreationTime.HeaderText = "订单创建时间";
            this.CreationTime.MinimumWidth = 6;
            this.CreationTime.Name = "CreationTime";
            this.CreationTime.Width = 125;
            // 
            // dgv_fun2
            // 
            this.dgv_fun2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fun2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No1,
            this.MedicineNo1,
            this.ClientNo1,
            this.SupplierNo1,
            this.Amounts1,
            this.MedicinePrice1,
            this.CreationTime1});
            this.dgv_fun2.Location = new System.Drawing.Point(12, 12);
            this.dgv_fun2.Name = "dgv_fun2";
            this.dgv_fun2.RowHeadersWidth = 51;
            this.dgv_fun2.RowTemplate.Height = 27;
            this.dgv_fun2.Size = new System.Drawing.Size(776, 292);
            this.dgv_fun2.TabIndex = 1;
            // 
            // No1
            // 
            this.No1.DataPropertyName = "No";
            this.No1.HeaderText = "订单编号";
            this.No1.MinimumWidth = 6;
            this.No1.Name = "No1";
            this.No1.Width = 125;
            // 
            // MedicineNo1
            // 
            this.MedicineNo1.DataPropertyName = "MedicineNo";
            this.MedicineNo1.HeaderText = "药品编号";
            this.MedicineNo1.MinimumWidth = 6;
            this.MedicineNo1.Name = "MedicineNo1";
            this.MedicineNo1.Width = 125;
            // 
            // ClientNo1
            // 
            this.ClientNo1.DataPropertyName = "ClientNo";
            this.ClientNo1.HeaderText = "用户编号";
            this.ClientNo1.MinimumWidth = 6;
            this.ClientNo1.Name = "ClientNo1";
            this.ClientNo1.Width = 125;
            // 
            // SupplierNo1
            // 
            this.SupplierNo1.DataPropertyName = "SupplierNo";
            this.SupplierNo1.HeaderText = "供应商编号";
            this.SupplierNo1.MinimumWidth = 6;
            this.SupplierNo1.Name = "SupplierNo1";
            this.SupplierNo1.Width = 125;
            // 
            // Amounts1
            // 
            this.Amounts1.DataPropertyName = "Amounts";
            this.Amounts1.HeaderText = "数量";
            this.Amounts1.MinimumWidth = 6;
            this.Amounts1.Name = "Amounts1";
            this.Amounts1.Width = 125;
            // 
            // MedicinePrice1
            // 
            this.MedicinePrice1.DataPropertyName = "MedicinePrice";
            this.MedicinePrice1.HeaderText = "药品单价";
            this.MedicinePrice1.MinimumWidth = 6;
            this.MedicinePrice1.Name = "MedicinePrice1";
            this.MedicinePrice1.Width = 125;
            // 
            // CreationTime1
            // 
            this.CreationTime1.DataPropertyName = "CreationTime";
            this.CreationTime1.HeaderText = "订单创建时间";
            this.CreationTime1.MinimumWidth = 6;
            this.CreationTime1.Name = "CreationTime1";
            this.CreationTime1.Width = 125;
            // 
            // frm_selectall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.dgv_fun2);
            this.Controls.Add(this.dgv_fun1);
            this.Name = "frm_selectall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "统计报表";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fun1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fun2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_fun1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicinePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationTime;
        private System.Windows.Forms.DataGridView dgv_fun2;
        private System.Windows.Forms.DataGridViewTextBoxColumn No1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amounts1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicinePrice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationTime1;
    }
}