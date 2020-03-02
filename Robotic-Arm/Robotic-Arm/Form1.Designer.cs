namespace Robotic_Arm
{
    partial class Form1
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
            this.msgBox = new System.Windows.Forms.ListBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientMSG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connectClient = new System.Windows.Forms.Button();
            this.disconnectClient = new System.Windows.Forms.Button();
            this.clientSendMsg = new System.Windows.Forms.Button();
            this.infBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgBox
            // 
            this.msgBox.FormattingEnabled = true;
            this.msgBox.ItemHeight = 16;
            this.msgBox.Location = new System.Drawing.Point(99, 40);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(288, 164);
            this.msgBox.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(208, 269);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 3;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(208, 297);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 22);
            this.txtIP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "IPAddress";
            // 
            // clientMSG
            // 
            this.clientMSG.Location = new System.Drawing.Point(474, 272);
            this.clientMSG.Name = "clientMSG";
            this.clientMSG.Size = new System.Drawing.Size(102, 22);
            this.clientMSG.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client Message";
            // 
            // connectClient
            // 
            this.connectClient.Location = new System.Drawing.Point(217, 337);
            this.connectClient.Name = "connectClient";
            this.connectClient.Size = new System.Drawing.Size(101, 37);
            this.connectClient.TabIndex = 9;
            this.connectClient.Text = "Connect";
            this.connectClient.UseVisualStyleBackColor = true;
            this.connectClient.Click += new System.EventHandler(this.connectClient_Click);
            // 
            // disconnectClient
            // 
            this.disconnectClient.Location = new System.Drawing.Point(430, 337);
            this.disconnectClient.Name = "disconnectClient";
            this.disconnectClient.Size = new System.Drawing.Size(107, 37);
            this.disconnectClient.TabIndex = 10;
            this.disconnectClient.Text = "Disconnect";
            this.disconnectClient.UseVisualStyleBackColor = true;
            this.disconnectClient.Click += new System.EventHandler(this.disconnectClient_Click);
            // 
            // clientSendMsg
            // 
            this.clientSendMsg.Location = new System.Drawing.Point(302, 380);
            this.clientSendMsg.Name = "clientSendMsg";
            this.clientSendMsg.Size = new System.Drawing.Size(148, 42);
            this.clientSendMsg.TabIndex = 11;
            this.clientSendMsg.Text = "Send Message";
            this.clientSendMsg.UseVisualStyleBackColor = true;
            this.clientSendMsg.Click += new System.EventHandler(this.clientSend_Click);
            // 
            // infBox
            // 
            this.infBox.FormattingEnabled = true;
            this.infBox.ItemHeight = 16;
            this.infBox.Location = new System.Drawing.Point(460, 40);
            this.infBox.Name = "infBox";
            this.infBox.Size = new System.Drawing.Size(292, 164);
            this.infBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Messages Sent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Messages Recieved";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.infBox);
            this.Controls.Add(this.clientSendMsg);
            this.Controls.Add(this.disconnectClient);
            this.Controls.Add(this.connectClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientMSG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.msgBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox msgBox;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientMSG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connectClient;
        private System.Windows.Forms.Button disconnectClient;
        private System.Windows.Forms.Button clientSendMsg;
        private System.Windows.Forms.ListBox infBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

