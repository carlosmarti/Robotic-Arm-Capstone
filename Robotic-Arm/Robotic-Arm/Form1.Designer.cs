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
            this.mvToPoint1Btn = new System.Windows.Forms.Button();
            this.mvToPoint2Btn = new System.Windows.Forms.Button();
            this.mvToPoint3Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numCycles = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.txtPort.Location = new System.Drawing.Point(90, 267);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 3;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(90, 297);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 22);
            this.txtIP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "IPAddress";
            // 
            // clientMSG
            // 
            this.clientMSG.Location = new System.Drawing.Point(128, 352);
            this.clientMSG.Name = "clientMSG";
            this.clientMSG.Size = new System.Drawing.Size(102, 22);
            this.clientMSG.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client Command";
            // 
            // connectClient
            // 
            this.connectClient.Location = new System.Drawing.Point(206, 275);
            this.connectClient.Name = "connectClient";
            this.connectClient.Size = new System.Drawing.Size(101, 37);
            this.connectClient.TabIndex = 9;
            this.connectClient.Text = "Connect";
            this.connectClient.UseVisualStyleBackColor = true;
            this.connectClient.Click += new System.EventHandler(this.connectClient_Click);
            // 
            // disconnectClient
            // 
            this.disconnectClient.Location = new System.Drawing.Point(313, 275);
            this.disconnectClient.Name = "disconnectClient";
            this.disconnectClient.Size = new System.Drawing.Size(107, 37);
            this.disconnectClient.TabIndex = 10;
            this.disconnectClient.Text = "Disconnect";
            this.disconnectClient.UseVisualStyleBackColor = true;
            this.disconnectClient.Click += new System.EventHandler(this.disconnectClient_Click);
            // 
            // clientSendMsg
            // 
            this.clientSendMsg.Location = new System.Drawing.Point(42, 386);
            this.clientSendMsg.Name = "clientSendMsg";
            this.clientSendMsg.Size = new System.Drawing.Size(148, 42);
            this.clientSendMsg.TabIndex = 11;
            this.clientSendMsg.Text = "Send Command";
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
            // mvToPoint1Btn
            // 
            this.mvToPoint1Btn.Location = new System.Drawing.Point(313, 396);
            this.mvToPoint1Btn.Name = "mvToPoint1Btn";
            this.mvToPoint1Btn.Size = new System.Drawing.Size(92, 32);
            this.mvToPoint1Btn.TabIndex = 16;
            this.mvToPoint1Btn.Text = "Point 1";
            this.mvToPoint1Btn.UseVisualStyleBackColor = true;
            this.mvToPoint1Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // mvToPoint2Btn
            // 
            this.mvToPoint2Btn.Location = new System.Drawing.Point(411, 396);
            this.mvToPoint2Btn.Name = "mvToPoint2Btn";
            this.mvToPoint2Btn.Size = new System.Drawing.Size(92, 32);
            this.mvToPoint2Btn.TabIndex = 17;
            this.mvToPoint2Btn.Text = "Point 2";
            this.mvToPoint2Btn.UseVisualStyleBackColor = true;
            this.mvToPoint2Btn.Click += new System.EventHandler(this.mvToPoint2Btn_Click);
            // 
            // mvToPoint3Btn
            // 
            this.mvToPoint3Btn.Location = new System.Drawing.Point(509, 396);
            this.mvToPoint3Btn.Name = "mvToPoint3Btn";
            this.mvToPoint3Btn.Size = new System.Drawing.Size(92, 32);
            this.mvToPoint3Btn.TabIndex = 18;
            this.mvToPoint3Btn.Text = "Point 3";
            this.mvToPoint3Btn.UseVisualStyleBackColor = true;
            this.mvToPoint3Btn.Click += new System.EventHandler(this.mvToPoint3Btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "Auto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.autoOp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(617, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "Manual";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.manualOp);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "ConnectDatabase";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.connectdatabase_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Send To Point";
            // 
            // numCycles
            // 
            this.numCycles.Location = new System.Drawing.Point(919, 210);
            this.numCycles.Name = "numCycles";
            this.numCycles.Size = new System.Drawing.Size(100, 22);
            this.numCycles.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(794, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Number of Cycles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(796, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Paths:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Point 1 -> Point 3 -> Point 2",
            "Point 3 -> Point 2 -> Point 1",
            "Point 2 -> Point 1 -> Point 3"});
            this.checkedListBox1.Location = new System.Drawing.Point(797, 47);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(241, 157);
            this.checkedListBox1.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1044, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Run Path";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1044, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Record";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numCycles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mvToPoint3Btn);
            this.Controls.Add(this.mvToPoint2Btn);
            this.Controls.Add(this.mvToPoint1Btn);
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
        private System.Windows.Forms.Button mvToPoint1Btn;
        private System.Windows.Forms.Button mvToPoint2Btn;
        private System.Windows.Forms.Button mvToPoint3Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numCycles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

