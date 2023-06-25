namespace exp1
{
    partial class frm_ManagePlan
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
            this.tbc_ManagePlan = new System.Windows.Forms.TabControl();
            this.tbp_StockPotency = new System.Windows.Forms.TabPage();
            this.btn_Query = new System.Windows.Forms.Button();
            this.dgv_StockPotency = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbp_StockLowerLimit = new System.Windows.Forms.TabPage();
            this.btn_QueryLower = new System.Windows.Forms.Button();
            this.dgv_StockLowerLimit = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbp_StockTopLimit = new System.Windows.Forms.TabPage();
            this.btn_QueryTopLimit = new System.Windows.Forms.Button();
            this.dgv_StockTopLimit = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbp_PeriodOfValidity = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_PeriodOfValidity = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_PeriodOfValidity = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbp_RentionMedicine = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_RetentionQuery = new System.Windows.Forms.Button();
            this.dgv_MedicineRetention = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tbp_PlanOrder = new System.Windows.Forms.TabPage();
            this.tbp_ModifyOrder = new System.Windows.Forms.TabPage();
            this.tbc_ManagePlan.SuspendLayout();
            this.tbp_StockPotency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockPotency)).BeginInit();
            this.tbp_StockLowerLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockLowerLimit)).BeginInit();
            this.tbp_StockTopLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockTopLimit)).BeginInit();
            this.tbp_PeriodOfValidity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PeriodOfValidity)).BeginInit();
            this.tbp_RentionMedicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MedicineRetention)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_ManagePlan
            // 
            this.tbc_ManagePlan.Controls.Add(this.tbp_StockPotency);
            this.tbc_ManagePlan.Controls.Add(this.tbp_StockLowerLimit);
            this.tbc_ManagePlan.Controls.Add(this.tbp_StockTopLimit);
            this.tbc_ManagePlan.Controls.Add(this.tbp_PeriodOfValidity);
            this.tbc_ManagePlan.Controls.Add(this.tbp_RentionMedicine);
            this.tbc_ManagePlan.Controls.Add(this.tbp_PlanOrder);
            this.tbc_ManagePlan.Controls.Add(this.tbp_ModifyOrder);
            this.tbc_ManagePlan.Location = new System.Drawing.Point(6, 4);
            this.tbc_ManagePlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbc_ManagePlan.Name = "tbc_ManagePlan";
            this.tbc_ManagePlan.SelectedIndex = 0;
            this.tbc_ManagePlan.Size = new System.Drawing.Size(1020, 570);
            this.tbc_ManagePlan.TabIndex = 1;
            // 
            // tbp_StockPotency
            // 
            this.tbp_StockPotency.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbp_StockPotency.Controls.Add(this.btn_Query);
            this.tbp_StockPotency.Controls.Add(this.dgv_StockPotency);
            this.tbp_StockPotency.Controls.Add(this.label1);
            this.tbp_StockPotency.Location = new System.Drawing.Point(4, 28);
            this.tbp_StockPotency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_StockPotency.Name = "tbp_StockPotency";
            this.tbp_StockPotency.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_StockPotency.Size = new System.Drawing.Size(1012, 538);
            this.tbp_StockPotency.TabIndex = 0;
            this.tbp_StockPotency.Text = "库存基数预警";
            // 
            // btn_Query
            // 
            this.btn_Query.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Query.Location = new System.Drawing.Point(89, 244);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(196, 66);
            this.btn_Query.TabIndex = 2;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // dgv_StockPotency
            // 
            this.dgv_StockPotency.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_StockPotency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StockPotency.Location = new System.Drawing.Point(489, 31);
            this.dgv_StockPotency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_StockPotency.Name = "dgv_StockPotency";
            this.dgv_StockPotency.ReadOnly = true;
            this.dgv_StockPotency.RowTemplate.Height = 27;
            this.dgv_StockPotency.Size = new System.Drawing.Size(482, 335);
            this.dgv_StockPotency.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "库存基数预警查询";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbp_StockLowerLimit
            // 
            this.tbp_StockLowerLimit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbp_StockLowerLimit.Controls.Add(this.btn_QueryLower);
            this.tbp_StockLowerLimit.Controls.Add(this.dgv_StockLowerLimit);
            this.tbp_StockLowerLimit.Controls.Add(this.label2);
            this.tbp_StockLowerLimit.Location = new System.Drawing.Point(4, 28);
            this.tbp_StockLowerLimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_StockLowerLimit.Name = "tbp_StockLowerLimit";
            this.tbp_StockLowerLimit.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_StockLowerLimit.Size = new System.Drawing.Size(1012, 538);
            this.tbp_StockLowerLimit.TabIndex = 1;
            this.tbp_StockLowerLimit.Text = "库存下限预警";
            // 
            // btn_QueryLower
            // 
            this.btn_QueryLower.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_QueryLower.Location = new System.Drawing.Point(160, 275);
            this.btn_QueryLower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_QueryLower.Name = "btn_QueryLower";
            this.btn_QueryLower.Size = new System.Drawing.Size(196, 66);
            this.btn_QueryLower.TabIndex = 5;
            this.btn_QueryLower.Text = "查询";
            this.btn_QueryLower.UseVisualStyleBackColor = true;
            this.btn_QueryLower.Click += new System.EventHandler(this.btn_QueryLower_Click_1);
            // 
            // dgv_StockLowerLimit
            // 
            this.dgv_StockLowerLimit.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_StockLowerLimit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StockLowerLimit.Location = new System.Drawing.Point(455, 48);
            this.dgv_StockLowerLimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_StockLowerLimit.Name = "dgv_StockLowerLimit";
            this.dgv_StockLowerLimit.ReadOnly = true;
            this.dgv_StockLowerLimit.RowTemplate.Height = 27;
            this.dgv_StockLowerLimit.Size = new System.Drawing.Size(508, 335);
            this.dgv_StockLowerLimit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 72);
            this.label2.TabIndex = 3;
            this.label2.Text = "库存下限预警查询";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbp_StockTopLimit
            // 
            this.tbp_StockTopLimit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbp_StockTopLimit.Controls.Add(this.btn_QueryTopLimit);
            this.tbp_StockTopLimit.Controls.Add(this.dgv_StockTopLimit);
            this.tbp_StockTopLimit.Controls.Add(this.label3);
            this.tbp_StockTopLimit.Location = new System.Drawing.Point(4, 28);
            this.tbp_StockTopLimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_StockTopLimit.Name = "tbp_StockTopLimit";
            this.tbp_StockTopLimit.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_StockTopLimit.Size = new System.Drawing.Size(1012, 538);
            this.tbp_StockTopLimit.TabIndex = 2;
            this.tbp_StockTopLimit.Text = "库存上限预警";
            // 
            // btn_QueryTopLimit
            // 
            this.btn_QueryTopLimit.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_QueryTopLimit.Location = new System.Drawing.Point(145, 275);
            this.btn_QueryTopLimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_QueryTopLimit.Name = "btn_QueryTopLimit";
            this.btn_QueryTopLimit.Size = new System.Drawing.Size(196, 66);
            this.btn_QueryTopLimit.TabIndex = 5;
            this.btn_QueryTopLimit.Text = "查询";
            this.btn_QueryTopLimit.UseVisualStyleBackColor = true;
            this.btn_QueryTopLimit.Click += new System.EventHandler(this.btn_QueryTopLimit_Click_1);
            // 
            // dgv_StockTopLimit
            // 
            this.dgv_StockTopLimit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_StockTopLimit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StockTopLimit.Location = new System.Drawing.Point(473, 51);
            this.dgv_StockTopLimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_StockTopLimit.Name = "dgv_StockTopLimit";
            this.dgv_StockTopLimit.RowTemplate.Height = 27;
            this.dgv_StockTopLimit.Size = new System.Drawing.Size(520, 335);
            this.dgv_StockTopLimit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 72);
            this.label3.TabIndex = 3;
            this.label3.Text = "库存上限预警查询";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbp_PeriodOfValidity
            // 
            this.tbp_PeriodOfValidity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbp_PeriodOfValidity.Controls.Add(this.label5);
            this.tbp_PeriodOfValidity.Controls.Add(this.dtp_PeriodOfValidity);
            this.tbp_PeriodOfValidity.Controls.Add(this.button1);
            this.tbp_PeriodOfValidity.Controls.Add(this.dgv_PeriodOfValidity);
            this.tbp_PeriodOfValidity.Controls.Add(this.label4);
            this.tbp_PeriodOfValidity.Location = new System.Drawing.Point(4, 28);
            this.tbp_PeriodOfValidity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_PeriodOfValidity.Name = "tbp_PeriodOfValidity";
            this.tbp_PeriodOfValidity.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_PeriodOfValidity.Size = new System.Drawing.Size(1012, 538);
            this.tbp_PeriodOfValidity.TabIndex = 3;
            this.tbp_PeriodOfValidity.Text = "有效期管理";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "有效期选择:";
            // 
            // dtp_PeriodOfValidity
            // 
            this.dtp_PeriodOfValidity.Location = new System.Drawing.Point(386, 436);
            this.dtp_PeriodOfValidity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_PeriodOfValidity.Name = "dtp_PeriodOfValidity";
            this.dtp_PeriodOfValidity.Size = new System.Drawing.Size(224, 28);
            this.dtp_PeriodOfValidity.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(386, 485);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgv_PeriodOfValidity
            // 
            this.dgv_PeriodOfValidity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_PeriodOfValidity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_PeriodOfValidity.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_PeriodOfValidity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PeriodOfValidity.Location = new System.Drawing.Point(116, 98);
            this.dgv_PeriodOfValidity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_PeriodOfValidity.Name = "dgv_PeriodOfValidity";
            this.dgv_PeriodOfValidity.RowTemplate.Height = 27;
            this.dgv_PeriodOfValidity.Size = new System.Drawing.Size(548, 330);
            this.dgv_PeriodOfValidity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(175, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 72);
            this.label4.TabIndex = 6;
            this.label4.Text = "有效期截止查询";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbp_RentionMedicine
            // 
            this.tbp_RentionMedicine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbp_RentionMedicine.Controls.Add(this.dateTimePicker1);
            this.tbp_RentionMedicine.Controls.Add(this.label8);
            this.tbp_RentionMedicine.Controls.Add(this.label7);
            this.tbp_RentionMedicine.Controls.Add(this.btn_RetentionQuery);
            this.tbp_RentionMedicine.Controls.Add(this.dgv_MedicineRetention);
            this.tbp_RentionMedicine.Controls.Add(this.label6);
            this.tbp_RentionMedicine.Location = new System.Drawing.Point(4, 28);
            this.tbp_RentionMedicine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_RentionMedicine.Name = "tbp_RentionMedicine";
            this.tbp_RentionMedicine.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_RentionMedicine.Size = new System.Drawing.Size(1012, 538);
            this.tbp_RentionMedicine.TabIndex = 4;
            this.tbp_RentionMedicine.Text = "滞留药品管理";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(306, 466);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 28);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "尚未出库的药品";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "从";
            // 
            // btn_RetentionQuery
            // 
            this.btn_RetentionQuery.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_RetentionQuery.Location = new System.Drawing.Point(644, 447);
            this.btn_RetentionQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_RetentionQuery.Name = "btn_RetentionQuery";
            this.btn_RetentionQuery.Size = new System.Drawing.Size(129, 62);
            this.btn_RetentionQuery.TabIndex = 8;
            this.btn_RetentionQuery.Text = "查询";
            this.btn_RetentionQuery.UseVisualStyleBackColor = true;
            this.btn_RetentionQuery.Click += new System.EventHandler(this.btn_RetentionQuery_Click);
            // 
            // dgv_MedicineRetention
            // 
            this.dgv_MedicineRetention.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_MedicineRetention.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_MedicineRetention.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MedicineRetention.Location = new System.Drawing.Point(102, 76);
            this.dgv_MedicineRetention.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_MedicineRetention.Name = "dgv_MedicineRetention";
            this.dgv_MedicineRetention.RowTemplate.Height = 27;
            this.dgv_MedicineRetention.Size = new System.Drawing.Size(702, 335);
            this.dgv_MedicineRetention.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(242, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(460, 72);
            this.label6.TabIndex = 6;
            this.label6.Text = "滞留药品查询";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbp_PlanOrder
            // 
            this.tbp_PlanOrder.Location = new System.Drawing.Point(4, 28);
            this.tbp_PlanOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_PlanOrder.Name = "tbp_PlanOrder";
            this.tbp_PlanOrder.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_PlanOrder.Size = new System.Drawing.Size(1012, 538);
            this.tbp_PlanOrder.TabIndex = 5;
            this.tbp_PlanOrder.Text = "计划订单";
            this.tbp_PlanOrder.UseVisualStyleBackColor = true;
            // 
            // tbp_ModifyOrder
            // 
            this.tbp_ModifyOrder.Location = new System.Drawing.Point(4, 28);
            this.tbp_ModifyOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_ModifyOrder.Name = "tbp_ModifyOrder";
            this.tbp_ModifyOrder.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbp_ModifyOrder.Size = new System.Drawing.Size(989, 617);
            this.tbp_ModifyOrder.TabIndex = 6;
            this.tbp_ModifyOrder.Text = "订单修改";
            this.tbp_ModifyOrder.UseVisualStyleBackColor = true;
            // 
            // frm_ManagePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 554);
            this.Controls.Add(this.tbc_ManagePlan);
            this.Name = "frm_ManagePlan";
            this.Text = "计划管理";
            this.tbc_ManagePlan.ResumeLayout(false);
            this.tbp_StockPotency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockPotency)).EndInit();
            this.tbp_StockLowerLimit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockLowerLimit)).EndInit();
            this.tbp_StockTopLimit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockTopLimit)).EndInit();
            this.tbp_PeriodOfValidity.ResumeLayout(false);
            this.tbp_PeriodOfValidity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PeriodOfValidity)).EndInit();
            this.tbp_RentionMedicine.ResumeLayout(false);
            this.tbp_RentionMedicine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MedicineRetention)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tbc_ManagePlan;
        public System.Windows.Forms.TabPage tbp_StockPotency;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.DataGridView dgv_StockPotency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbp_StockLowerLimit;
        private System.Windows.Forms.Button btn_QueryLower;
        private System.Windows.Forms.DataGridView dgv_StockLowerLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbp_StockTopLimit;
        private System.Windows.Forms.Button btn_QueryTopLimit;
        private System.Windows.Forms.DataGridView dgv_StockTopLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tbp_PeriodOfValidity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_PeriodOfValidity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_PeriodOfValidity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tbp_RentionMedicine;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_RetentionQuery;
        private System.Windows.Forms.DataGridView dgv_MedicineRetention;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tbp_PlanOrder;
        private System.Windows.Forms.TabPage tbp_ModifyOrder;
    }
}