namespace 五子棋2
{
    partial class main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_listen = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.btn_sendMsg = new System.Windows.Forms.Button();
            this.txt_talk = new System.Windows.Forms.TextBox();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.btn_stopConnect = new System.Windows.Forms.Button();
            this.btn_localGame = new System.Windows.Forms.Button();
            this.btn_internetGmae = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_listen
            // 
            this.btn_listen.Enabled = false;
            this.btn_listen.Location = new System.Drawing.Point(245, 498);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(75, 23);
            this.btn_listen.TabIndex = 2;
            this.btn_listen.Text = "监听";
            this.btn_listen.UseVisualStyleBackColor = true;
            this.btn_listen.Click += new System.EventHandler(this.btn_listen_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Enabled = false;
            this.btn_connect.Location = new System.Drawing.Point(328, 498);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_ip
            // 
            this.txt_ip.Enabled = false;
            this.txt_ip.Location = new System.Drawing.Point(409, 500);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(100, 21);
            this.txt_ip.TabIndex = 4;
            this.txt_ip.Text = "192.168.10.123";
            // 
            // btn_sendMsg
            // 
            this.btn_sendMsg.Enabled = false;
            this.btn_sendMsg.Location = new System.Drawing.Point(716, 494);
            this.btn_sendMsg.Name = "btn_sendMsg";
            this.btn_sendMsg.Size = new System.Drawing.Size(75, 23);
            this.btn_sendMsg.TabIndex = 5;
            this.btn_sendMsg.Text = "发送消息";
            this.btn_sendMsg.UseVisualStyleBackColor = true;
            this.btn_sendMsg.Click += new System.EventHandler(this.btn_sendMsg_Click);
            // 
            // txt_talk
            // 
            this.txt_talk.Location = new System.Drawing.Point(506, 12);
            this.txt_talk.Multiline = true;
            this.txt_talk.Name = "txt_talk";
            this.txt_talk.ReadOnly = true;
            this.txt_talk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_talk.Size = new System.Drawing.Size(285, 392);
            this.txt_talk.TabIndex = 6;
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(506, 410);
            this.txt_send.Multiline = true;
            this.txt_send.Name = "txt_send";
            this.txt_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_send.Size = new System.Drawing.Size(285, 64);
            this.txt_send.TabIndex = 7;
            // 
            // btn_stopConnect
            // 
            this.btn_stopConnect.Enabled = false;
            this.btn_stopConnect.Location = new System.Drawing.Point(635, 494);
            this.btn_stopConnect.Name = "btn_stopConnect";
            this.btn_stopConnect.Size = new System.Drawing.Size(75, 23);
            this.btn_stopConnect.TabIndex = 8;
            this.btn_stopConnect.Text = "断开";
            this.btn_stopConnect.UseVisualStyleBackColor = true;
            this.btn_stopConnect.Click += new System.EventHandler(this.btn_stopConnect_Click);
            // 
            // btn_localGame
            // 
            this.btn_localGame.Location = new System.Drawing.Point(2, 498);
            this.btn_localGame.Name = "btn_localGame";
            this.btn_localGame.Size = new System.Drawing.Size(75, 23);
            this.btn_localGame.TabIndex = 9;
            this.btn_localGame.Text = "单机双人";
            this.btn_localGame.UseVisualStyleBackColor = true;
            this.btn_localGame.Click += new System.EventHandler(this.btn_localGame_Click);
            // 
            // btn_internetGmae
            // 
            this.btn_internetGmae.Location = new System.Drawing.Point(83, 498);
            this.btn_internetGmae.Name = "btn_internetGmae";
            this.btn_internetGmae.Size = new System.Drawing.Size(75, 23);
            this.btn_internetGmae.TabIndex = 10;
            this.btn_internetGmae.Text = "联网对战";
            this.btn_internetGmae.UseVisualStyleBackColor = true;
            this.btn_internetGmae.Click += new System.EventHandler(this.btn_internetGmae_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Enabled = false;
            this.btn_restart.Location = new System.Drawing.Point(164, 498);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(75, 23);
            this.btn_restart.TabIndex = 11;
            this.btn_restart.Text = "重新开始";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 529);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_internetGmae);
            this.Controls.Add(this.btn_localGame);
            this.Controls.Add(this.btn_stopConnect);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.txt_talk);
            this.Controls.Add(this.btn_sendMsg);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_listen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "五子棋-FMN";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_listen;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button btn_sendMsg;
        private System.Windows.Forms.TextBox txt_talk;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.Button btn_stopConnect;
        private System.Windows.Forms.Button btn_localGame;
        private System.Windows.Forms.Button btn_internetGmae;
        private System.Windows.Forms.Button btn_restart;
    }
}

