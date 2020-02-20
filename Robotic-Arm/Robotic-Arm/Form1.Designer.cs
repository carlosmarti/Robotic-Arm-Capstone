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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.msgBox = new System.Windows.Forms.ListBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientMSG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connectClient = new System.Windows.Forms.Button();
            this.disconnectClient = new System.Windows.Forms.Button();
            this.clientSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(134, 368);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 31);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(234, 368);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(102, 31);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // msgBox
            // 
            this.msgBox.FormattingEnabled = true;
            this.msgBox.ItemHeight = 16;
            this.msgBox.Location = new System.Drawing.Point(143, 27);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(365, 164);
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
            this.clientMSG.Location = new System.Drawing.Point(613, 297);
            this.clientMSG.Name = "clientMSG";
            this.clientMSG.Size = new System.Drawing.Size(102, 22);
            this.clientMSG.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client Message";
            // 
            // connectClient
            // 
            this.connectClient.Location = new System.Drawing.Point(475, 337);
            this.connectClient.Name = "connectClient";
            this.connectClient.Size = new System.Drawing.Size(101, 37);
            this.connectClient.TabIndex = 9;
            this.connectClient.Text = "Connect";
            this.connectClient.UseVisualStyleBackColor = true;
            this.connectClient.Click += new System.EventHandler(this.connectClient_Click);
            // 
            // disconnectClient
            // 
            this.disconnectClient.Location = new System.Drawing.Point(636, 337);
            this.disconnectClient.Name = "disconnectClient";
            this.disconnectClient.Size = new System.Drawing.Size(107, 37);
            this.disconnectClient.TabIndex = 10;
            this.disconnectClient.Text = "Disconnect";
            this.disconnectClient.UseVisualStyleBackColor = true;
            this.disconnectClient.Click += new System.EventHandler(this.disconnectClient_Click);
            // 
            // clientSend
            // 
            this.clientSend.Location = new System.Drawing.Point(534, 380);
            this.clientSend.Name = "clientSend";
            this.clientSend.Size = new System.Drawing.Size(148, 42);
            this.clientSend.TabIndex = 11;
            this.clientSend.Text = "Send Message";
            this.clientSend.UseVisualStyleBackColor = true;
            this.clientSend.Click += new System.EventHandler(this.clientSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientSend);
            this.Controls.Add(this.disconnectClient);
            this.Controls.Add(this.connectClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientMSG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ListBox msgBox;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientMSG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connectClient;
        private System.Windows.Forms.Button disconnectClient;
        private System.Windows.Forms.Button clientSend;
    }
}

