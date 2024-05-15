namespace LAB03_BAI05
{
    partial class Bai05_Client
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
            this.buttonDisconect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.buttonCongDong = new System.Windows.Forms.Button();
            this.buttonCaNhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCaNhan = new System.Windows.Forms.TextBox();
            this.textBoxCongDong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDisconect
            // 
            this.buttonDisconect.Location = new System.Drawing.Point(448, 109);
            this.buttonDisconect.Name = "buttonDisconect";
            this.buttonDisconect.Size = new System.Drawing.Size(107, 37);
            this.buttonDisconect.TabIndex = 36;
            this.buttonDisconect.Text = "Ngắt kết nối";
            this.buttonDisconect.UseVisualStyleBackColor = true;
            this.buttonDisconect.Click += new System.EventHandler(this.buttonDisconect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(448, 54);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(107, 37);
            this.buttonConnect.TabIndex = 35;
            this.buttonConnect.Text = "Kết nối";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(646, 310);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 39);
            this.buttonExit.TabIndex = 34;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(180, 114);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(214, 26);
            this.textBoxPort.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "IP Address";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(180, 59);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(214, 26);
            this.textBoxIP.TabIndex = 27;
            // 
            // buttonCongDong
            // 
            this.buttonCongDong.Location = new System.Drawing.Point(274, 232);
            this.buttonCongDong.Name = "buttonCongDong";
            this.buttonCongDong.Size = new System.Drawing.Size(107, 37);
            this.buttonCongDong.TabIndex = 37;
            this.buttonCongDong.Text = "Cộng đồng";
            this.buttonCongDong.UseVisualStyleBackColor = true;
            this.buttonCongDong.Click += new System.EventHandler(this.buttonCongDong_Click);
            // 
            // buttonCaNhan
            // 
            this.buttonCaNhan.Location = new System.Drawing.Point(274, 275);
            this.buttonCaNhan.Name = "buttonCaNhan";
            this.buttonCaNhan.Size = new System.Drawing.Size(107, 37);
            this.buttonCaNhan.TabIndex = 38;
            this.buttonCaNhan.Text = "Cá nhân";
            this.buttonCaNhan.UseVisualStyleBackColor = true;
            this.buttonCaNhan.Click += new System.EventHandler(this.buttonCaNhan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Lấy ngẫu nhiên món ăn từ";
            // 
            // textBoxCaNhan
            // 
            this.textBoxCaNhan.Location = new System.Drawing.Point(400, 280);
            this.textBoxCaNhan.Name = "textBoxCaNhan";
            this.textBoxCaNhan.Size = new System.Drawing.Size(214, 26);
            this.textBoxCaNhan.TabIndex = 41;
            // 
            // textBoxCongDong
            // 
            this.textBoxCongDong.Location = new System.Drawing.Point(400, 237);
            this.textBoxCongDong.Name = "textBoxCongDong";
            this.textBoxCongDong.Size = new System.Drawing.Size(214, 26);
            this.textBoxCongDong.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "User\'ID";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(180, 174);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(214, 26);
            this.textBoxUser.TabIndex = 42;
            // 
            // Bai05_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxCaNhan);
            this.Controls.Add(this.textBoxCongDong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCaNhan);
            this.Controls.Add(this.buttonCongDong);
            this.Controls.Add(this.buttonDisconect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIP);
            this.Name = "Bai05_Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDisconect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button buttonCongDong;
        private System.Windows.Forms.Button buttonCaNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCaNhan;
        private System.Windows.Forms.TextBox textBoxCongDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUser;
    }
}