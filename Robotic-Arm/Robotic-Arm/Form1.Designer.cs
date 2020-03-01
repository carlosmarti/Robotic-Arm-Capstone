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
            this.SuspendLayout();
            // 
            // msgBox
            // 
            this.msgBox.FormattingEnabled = true;
            this.msgBox.Location = new System.Drawing.Point(107, 22);
            this.msgBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(275, 134);
            this.msgBox.TabIndex = 2;
            this.msgBox.SelectedIndexChanged += new System.EventHandler(this.msgBox_SelectedIndexChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(156, 219);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(76, 20);
            this.txtPort.TabIndex = 3;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(156, 241);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(76, 20);
            this.txtIP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "IPAddress";
            // 
            // clientMSG
            // 
            this.clientMSG.Location = new System.Drawing.Point(356, 221);
            this.clientMSG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientMSG.Name = "clientMSG";
            this.clientMSG.Size = new System.Drawing.Size(78, 20);
            this.clientMSG.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client Message";
            // 
            // connectClient
            // 
            this.connectClient.Location = new System.Drawing.Point(163, 274);
            this.connectClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectClient.Name = "connectClient";
            this.connectClient.Size = new System.Drawing.Size(76, 30);
            this.connectClient.TabIndex = 9;
            this.connectClient.Text = "Connect";
            this.connectClient.UseVisualStyleBackColor = true;
            this.connectClient.Click += new System.EventHandler(this.connectClient_Click);
            // 
            // disconnectClient
            // 
            this.disconnectClient.Location = new System.Drawing.Point(322, 274);
            this.disconnectClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disconnectClient.Name = "disconnectClient";
            this.disconnectClient.Size = new System.Drawing.Size(80, 30);
            this.disconnectClient.TabIndex = 10;
            this.disconnectClient.Text = "Disconnect";
            this.disconnectClient.UseVisualStyleBackColor = true;
            this.disconnectClient.Click += new System.EventHandler(this.disconnectClient_Click);
            // 
            // clientSendMsg
            // 
            this.clientSendMsg.Location = new System.Drawing.Point(226, 309);
            this.clientSendMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientSendMsg.Name = "clientSendMsg";
            this.clientSendMsg.Size = new System.Drawing.Size(111, 34);
            this.clientSendMsg.TabIndex = 11;
            this.clientSendMsg.Text = "Send Message";
            this.clientSendMsg.UseVisualStyleBackColor = true;
            this.clientSendMsg.Click += new System.EventHandler(this.clientSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

