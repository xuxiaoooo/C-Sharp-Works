namespace MyTickets
{
    partial class 订单查询
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.您好 = new System.Windows.Forms.Label();
            this.usename = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leavePlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 您好
            // 
            this.您好.AutoSize = true;
            this.您好.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.您好.ForeColor = System.Drawing.Color.Gold;
            this.您好.Location = new System.Drawing.Point(77, 50);
            this.您好.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.您好.Name = "您好";
            this.您好.Size = new System.Drawing.Size(134, 37);
            this.您好.TabIndex = 4;
            this.您好.Text = "您好，";
            // 
            // usename
            // 
            this.usename.AutoSize = true;
            this.usename.BackColor = System.Drawing.Color.Transparent;
            this.usename.Font = new System.Drawing.Font("楷体", 21.75F);
            this.usename.ForeColor = System.Drawing.Color.Gold;
            this.usename.Location = new System.Drawing.Point(387, 62);
            this.usename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usename.Name = "usename";
            this.usename.Size = new System.Drawing.Size(0, 37);
            this.usename.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 228);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.flightNo,
            this.leavePlace,
            this.landPlace,
            this.leaveDate,
            this.landTime});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(31, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(856, 105);
            this.dataGridView1.TabIndex = 8;
            // 
            // orderId
            // 
            this.orderId.DataPropertyName = "orderId";
            this.orderId.HeaderText = "订单号";
            this.orderId.MinimumWidth = 6;
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            this.orderId.Width = 125;
            // 
            // flightNo
            // 
            this.flightNo.DataPropertyName = "flightNo";
            this.flightNo.HeaderText = "航班号";
            this.flightNo.MinimumWidth = 6;
            this.flightNo.Name = "flightNo";
            this.flightNo.ReadOnly = true;
            this.flightNo.Width = 125;
            // 
            // leavePlace
            // 
            this.leavePlace.DataPropertyName = "leavePlace";
            this.leavePlace.HeaderText = "出发地";
            this.leavePlace.MinimumWidth = 6;
            this.leavePlace.Name = "leavePlace";
            this.leavePlace.ReadOnly = true;
            this.leavePlace.Width = 125;
            // 
            // landPlace
            // 
            this.landPlace.DataPropertyName = "landPlace";
            this.landPlace.HeaderText = "目的地";
            this.landPlace.MinimumWidth = 6;
            this.landPlace.Name = "landPlace";
            this.landPlace.ReadOnly = true;
            this.landPlace.Width = 125;
            // 
            // leaveDate
            // 
            this.leaveDate.DataPropertyName = "leaveDate";
            this.leaveDate.HeaderText = "出发时间";
            this.leaveDate.MinimumWidth = 6;
            this.leaveDate.Name = "leaveDate";
            this.leaveDate.ReadOnly = true;
            this.leaveDate.Width = 125;
            // 
            // landTime
            // 
            this.landTime.DataPropertyName = "landTime";
            this.landTime.HeaderText = "到达时间";
            this.landTime.MinimumWidth = 6;
            this.landTime.Name = "landTime";
            this.landTime.ReadOnly = true;
            this.landTime.Width = 125;
            // 
            // 订单查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 286);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usename);
            this.Controls.Add(this.您好);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "订单查询";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订单查询";
            this.Load += new System.EventHandler(this.订单查询_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label 您好;
        private System.Windows.Forms.Label usename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn leavePlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn landPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn landTime;
    }
}