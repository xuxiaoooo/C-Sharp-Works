namespace MyTickets
{
    partial class 机票预订
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(机票预订));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airways = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbnQuery = new System.Windows.Forms.Button();
            this.cboDestinationCity = new System.Windows.Forms.ComboBox();
            this.cboLeaveCity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numNunber = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtLandTime = new System.Windows.Forms.TextBox();
            this.txtLeaveTime = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtAirways = new System.Windows.Forms.TextBox();
            this.txtFlightNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLandTime1 = new System.Windows.Forms.Label();
            this.txtPrice1 = new System.Windows.Forms.Label();
            this.txtLeaveTime1 = new System.Windows.Forms.Label();
            this.txtFrom1 = new System.Windows.Forms.Label();
            this.txtTo1 = new System.Windows.Forms.Label();
            this.txtAirways1 = new System.Windows.Forms.Label();
            this.txtFlightNo1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.usename = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNunber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "出发地：";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.tbnQuery);
            this.groupBox1.Controls.Add(this.cboDestinationCity);
            this.groupBox1.Controls.Add(this.cboLeaveCity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(821, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "航班信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightNo,
            this.airways,
            this.leaveTime,
            this.landTime,
            this.price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(39, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(745, 198);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // flightNo
            // 
            this.flightNo.DataPropertyName = "flightNo";
            this.flightNo.HeaderText = "航班号";
            this.flightNo.MinimumWidth = 6;
            this.flightNo.Name = "flightNo";
            // 
            // airways
            // 
            this.airways.DataPropertyName = "airways";
            this.airways.HeaderText = "航空公司";
            this.airways.MinimumWidth = 6;
            this.airways.Name = "airways";
            // 
            // leaveTime
            // 
            this.leaveTime.DataPropertyName = "leaveTime";
            this.leaveTime.HeaderText = "出发时间";
            this.leaveTime.MinimumWidth = 6;
            this.leaveTime.Name = "leaveTime";
            // 
            // landTime
            // 
            this.landTime.DataPropertyName = "landTime";
            this.landTime.HeaderText = "到达时间";
            this.landTime.MinimumWidth = 6;
            this.landTime.Name = "landTime";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "成人票价";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // tbnQuery
            // 
            this.tbnQuery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbnQuery.BackgroundImage")));
            this.tbnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbnQuery.Location = new System.Drawing.Point(644, 22);
            this.tbnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.tbnQuery.Name = "tbnQuery";
            this.tbnQuery.Size = new System.Drawing.Size(107, 49);
            this.tbnQuery.TabIndex = 2;
            this.tbnQuery.UseVisualStyleBackColor = true;
            this.tbnQuery.Click += new System.EventHandler(this.tbnQuery_Click);
            // 
            // cboDestinationCity
            // 
            this.cboDestinationCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestinationCity.FormattingEnabled = true;
            this.cboDestinationCity.Location = new System.Drawing.Point(405, 34);
            this.cboDestinationCity.Margin = new System.Windows.Forms.Padding(4);
            this.cboDestinationCity.Name = "cboDestinationCity";
            this.cboDestinationCity.Size = new System.Drawing.Size(160, 23);
            this.cboDestinationCity.TabIndex = 1;
            // 
            // cboLeaveCity
            // 
            this.cboLeaveCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeaveCity.FormattingEnabled = true;
            this.cboLeaveCity.Location = new System.Drawing.Point(117, 34);
            this.cboLeaveCity.Margin = new System.Windows.Forms.Padding(4);
            this.cboLeaveCity.Name = "cboLeaveCity";
            this.cboLeaveCity.Size = new System.Drawing.Size(160, 23);
            this.cboLeaveCity.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "目的地：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.numNunber);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtLandTime);
            this.groupBox2.Controls.Add(this.txtLeaveTime);
            this.groupBox2.Controls.Add(this.txtFrom);
            this.groupBox2.Controls.Add(this.txtTo);
            this.groupBox2.Controls.Add(this.txtAirways);
            this.groupBox2.Controls.Add(this.txtFlightNo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtLandTime1);
            this.groupBox2.Controls.Add(this.txtPrice1);
            this.groupBox2.Controls.Add(this.txtLeaveTime1);
            this.groupBox2.Controls.Add(this.txtFrom1);
            this.groupBox2.Controls.Add(this.txtTo1);
            this.groupBox2.Controls.Add(this.txtAirways1);
            this.groupBox2.Controls.Add(this.txtFlightNo1);
            this.groupBox2.Location = new System.Drawing.Point(44, 365);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(821, 276);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "航班预订";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(524, 232);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 25);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // numNunber
            // 
            this.numNunber.Location = new System.Drawing.Point(147, 234);
            this.numNunber.Margin = new System.Windows.Forms.Padding(4);
            this.numNunber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNunber.Name = "numNunber";
            this.numNunber.Size = new System.Drawing.Size(176, 25);
            this.numNunber.TabIndex = 2;
            this.numNunber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Location = new System.Drawing.Point(147, 184);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(176, 25);
            this.txtPrice.TabIndex = 1;
            // 
            // txtLandTime
            // 
            this.txtLandTime.BackColor = System.Drawing.Color.AliceBlue;
            this.txtLandTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLandTime.Location = new System.Drawing.Point(524, 134);
            this.txtLandTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtLandTime.Name = "txtLandTime";
            this.txtLandTime.ReadOnly = true;
            this.txtLandTime.Size = new System.Drawing.Size(176, 25);
            this.txtLandTime.TabIndex = 1;
            // 
            // txtLeaveTime
            // 
            this.txtLeaveTime.BackColor = System.Drawing.Color.AliceBlue;
            this.txtLeaveTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLeaveTime.Location = new System.Drawing.Point(147, 134);
            this.txtLeaveTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtLeaveTime.Name = "txtLeaveTime";
            this.txtLeaveTime.ReadOnly = true;
            this.txtLeaveTime.Size = new System.Drawing.Size(176, 25);
            this.txtLeaveTime.TabIndex = 1;
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFrom.Location = new System.Drawing.Point(147, 84);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.Size = new System.Drawing.Size(176, 25);
            this.txtFrom.TabIndex = 1;
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.AliceBlue;
            this.txtTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTo.Location = new System.Drawing.Point(524, 84);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(176, 25);
            this.txtTo.TabIndex = 1;
            // 
            // txtAirways
            // 
            this.txtAirways.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAirways.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAirways.Location = new System.Drawing.Point(524, 34);
            this.txtAirways.Margin = new System.Windows.Forms.Padding(4);
            this.txtAirways.Name = "txtAirways";
            this.txtAirways.ReadOnly = true;
            this.txtAirways.Size = new System.Drawing.Size(176, 25);
            this.txtAirways.TabIndex = 1;
            // 
            // txtFlightNo
            // 
            this.txtFlightNo.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFlightNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFlightNo.Location = new System.Drawing.Point(145, 34);
            this.txtFlightNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFlightNo.Name = "txtFlightNo";
            this.txtFlightNo.ReadOnly = true;
            this.txtFlightNo.Size = new System.Drawing.Size(176, 25);
            this.txtFlightNo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "出发日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 238);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "预订数量：";
            // 
            // txtLandTime1
            // 
            this.txtLandTime1.AutoSize = true;
            this.txtLandTime1.Location = new System.Drawing.Point(447, 138);
            this.txtLandTime1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLandTime1.Name = "txtLandTime1";
            this.txtLandTime1.Size = new System.Drawing.Size(82, 15);
            this.txtLandTime1.TabIndex = 0;
            this.txtLandTime1.Text = "到达时间：";
            // 
            // txtPrice1
            // 
            this.txtPrice1.AutoSize = true;
            this.txtPrice1.Location = new System.Drawing.Point(71, 188);
            this.txtPrice1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(82, 15);
            this.txtPrice1.TabIndex = 0;
            this.txtPrice1.Text = "成人票价：";
            // 
            // txtLeaveTime1
            // 
            this.txtLeaveTime1.AutoSize = true;
            this.txtLeaveTime1.Location = new System.Drawing.Point(69, 138);
            this.txtLeaveTime1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLeaveTime1.Name = "txtLeaveTime1";
            this.txtLeaveTime1.Size = new System.Drawing.Size(82, 15);
            this.txtLeaveTime1.TabIndex = 0;
            this.txtLeaveTime1.Text = "出发时间：";
            // 
            // txtFrom1
            // 
            this.txtFrom1.AutoSize = true;
            this.txtFrom1.Location = new System.Drawing.Point(84, 88);
            this.txtFrom1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtFrom1.Name = "txtFrom1";
            this.txtFrom1.Size = new System.Drawing.Size(67, 15);
            this.txtFrom1.TabIndex = 0;
            this.txtFrom1.Text = "出发地：";
            // 
            // txtTo1
            // 
            this.txtTo1.AutoSize = true;
            this.txtTo1.Location = new System.Drawing.Point(461, 88);
            this.txtTo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTo1.Name = "txtTo1";
            this.txtTo1.Size = new System.Drawing.Size(67, 15);
            this.txtTo1.TabIndex = 0;
            this.txtTo1.Text = "目的地：";
            // 
            // txtAirways1
            // 
            this.txtAirways1.AutoSize = true;
            this.txtAirways1.Location = new System.Drawing.Point(447, 38);
            this.txtAirways1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAirways1.Name = "txtAirways1";
            this.txtAirways1.Size = new System.Drawing.Size(82, 15);
            this.txtAirways1.TabIndex = 0;
            this.txtAirways1.Text = "航空公司：";
            // 
            // txtFlightNo1
            // 
            this.txtFlightNo1.AutoSize = true;
            this.txtFlightNo1.Location = new System.Drawing.Point(83, 38);
            this.txtFlightNo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtFlightNo1.Name = "txtFlightNo1";
            this.txtFlightNo1.Size = new System.Drawing.Size(67, 15);
            this.txtFlightNo1.TabIndex = 0;
            this.txtFlightNo1.Text = "航班号：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(569, 649);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(715, 649);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 46);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usename
            // 
            this.usename.AutoSize = true;
            this.usename.BackColor = System.Drawing.Color.Transparent;
            this.usename.Location = new System.Drawing.Point(131, 9);
            this.usename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usename.Name = "usename";
            this.usename.Size = new System.Drawing.Size(15, 15);
            this.usename.TabIndex = 5;
            this.usename.Text = " ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(118, 655);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "查看所有航班";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // 机票预订
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 714);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.usename);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "机票预订";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "机票预订";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.机票预订_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.机票预订_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.机票预订_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNunber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tbnQuery;
        private System.Windows.Forms.ComboBox cboDestinationCity;
        private System.Windows.Forms.ComboBox cboLeaveCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtAirways;
        private System.Windows.Forms.TextBox txtFlightNo;
        private System.Windows.Forms.Label txtPrice1;
        private System.Windows.Forms.Label txtLeaveTime1;
        private System.Windows.Forms.Label txtFrom1;
        private System.Windows.Forms.Label txtTo1;
        private System.Windows.Forms.Label txtAirways1;
        private System.Windows.Forms.Label txtFlightNo1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numNunber;
        private System.Windows.Forms.TextBox txtLandTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtLandTime1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn airways;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn landTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.TextBox txtLeaveTime;
        private System.Windows.Forms.Label usename;
        private System.Windows.Forms.Button button3;
    }
}

