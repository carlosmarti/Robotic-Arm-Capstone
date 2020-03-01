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
            txtPort.Text = "13000";
            txtIP.Text = "192.168.0.254";
            clientMSG.Text = "INFcommand";
            //TcpConnection.Init(81, "10.5.196.103"); local server 
        }

        /*private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                var portNum = int.Parse(txtPort.Text);
                TcpConnection.Init(portNum, txtIP.Text);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }*/

        /*private void btnDisconnect_Click(object sender, EventArgs e)
        {
            TcpConnection.StopServer();
        }*/

        public ListBox getMsgBox()
        {
            return msgBox;
        }

        private void connectClient_Click(object sender, EventArgs e)
        {
            client = new TCPClient(txtIP.Text, int.Parse(txtPort.Text), this);
            client.TextToSend = "INFcommand";
            //client.sendMSG();
        }

        private void disconnectClient_Click(object sender, EventArgs e)
        {
            client.stopClient();
        }

        private void clientSend_Click(object sender, EventArgs e)
        {
            client.TextToSend = clientMSG.Text;
            client.sendMSG();
            msgBox.Items.Add(client.TextToSend);
        }

        private void msgBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
