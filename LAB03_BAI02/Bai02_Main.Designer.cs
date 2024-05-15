namespace LAB03_BAI02
{
    partial class Bai02_Main
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.listViewCommand = new System.Windows.Forms.ListView();
            this.buttonListen = new System.Windows.Forms.Button();
            this.groupBoxListen = new System.Windows.Forms.GroupBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.groupBoxCommand = new System.Windows.Forms.GroupBox();
            this.groupBoxListen.SuspendLayout();
            this.groupBoxCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(609, 275);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(81, 39);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listViewCommand
            // 
            this.listViewCommand.HideSelection = false;
            this.listViewCommand.Location = new System.Drawing.Point(24, 35);
            this.listViewCommand.Name = "listViewCommand";
            this.listViewCommand.Size = new System.Drawing.Size(679, 225);
            this.listViewCommand.TabIndex = 4;
            this.listViewCommand.UseCompatibleStateImageBehavior = false;
            this.listViewCommand.View = System.Windows.Forms.View.List;
            // 
            // buttonListen
            // 
            this.buttonListen.Location = new System.Drawing.Point(539, 59);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(101, 41);
            this.buttonListen.TabIndex = 3;
            this.buttonListen.Text = "Listen";
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.buttonListen_Click);
            // 
            // groupBoxListen
            // 
            this.groupBoxListen.Controls.Add(this.textBoxPort);
            this.groupBoxListen.Controls.Add(this.label2);
            this.groupBoxListen.Controls.Add(this.label1);
            this.groupBoxListen.Controls.Add(this.textBoxIP);
            this.groupBoxListen.Controls.Add(this.buttonListen);
            this.groupBoxListen.Location = new System.Drawing.Point(69, 13);
            this.groupBoxListen.Name = "groupBoxListen";
            this.groupBoxListen.Size = new System.Drawing.Size(719, 142);
            this.groupBoxListen.TabIndex = 6;
            this.groupBoxListen.TabStop = false;
            this.groupBoxListen.Text = "Listen";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(193, 91);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(258, 26);
            this.textBoxPort.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Address";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(193, 39);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(258, 26);
            this.textBoxIP.TabIndex = 4;
            // 
            // groupBoxCommand
            // 
            this.groupBoxCommand.Controls.Add(this.listViewCommand);
            this.groupBoxCommand.Controls.Add(this.buttonExit);
            this.groupBoxCommand.Location = new System.Drawing.Point(69, 172);
            this.groupBoxCommand.Name = "groupBoxCommand";
            this.groupBoxCommand.Size = new System.Drawing.Size(719, 333);
            this.groupBoxCommand.TabIndex = 7;
            this.groupBoxCommand.TabStop = false;
            this.groupBoxCommand.Text = "Command";
            // 
            // Bai02_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 540);
            this.Controls.Add(this.groupBoxCommand);
            this.Controls.Add(this.groupBoxListen);
            this.Name = "Bai02_Main";
            this.Text = "Bai02";
            this.groupBoxListen.ResumeLayout(false);
            this.groupBoxListen.PerformLayout();
            this.groupBoxCommand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListView listViewCommand;
        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.GroupBox groupBoxListen;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.GroupBox groupBoxCommand;
    }
}

