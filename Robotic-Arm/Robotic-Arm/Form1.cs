using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robotic_Arm
{
    public partial class Form1 : Form
    {
        TCPClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                var portNum = int.Parse(txtPort.Text);
                TcpConnection.Init(portNum, txtIP.Text);
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
            
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            TcpConnection.StopServer();
        }

        private void connectClient_Click(object sender, EventArgs e)
        {
            client = new TCPClient();
        }

        private void disconnectClient_Click(object sender, EventArgs e)
        {
            client.stopClient();
        }

        private void clientSend_Click(object sender, EventArgs e)
        {
            client.TextToSend = clientMSG.Text;
            client.sendMSG();
        }
    }
}
