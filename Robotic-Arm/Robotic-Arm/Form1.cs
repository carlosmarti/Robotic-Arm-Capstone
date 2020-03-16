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
        MySqlConnector connector;
        public Form1()
        {
            InitializeComponent();
            txtPort.Text = "13000";
            txtIP.Text = "192.168.0.254";
            clientMSG.Text = "INF";
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
        public ListBox getInfBox()
        {
            return infBox;
        }

        private void connectClient_Click(object sender, EventArgs e)
        {
            client = new TCPClient(txtIP.Text, int.Parse(txtPort.Text), this);
            //client.TextToSend = clientMSG.Text;
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
            msgBox.Items.Add("--" + client.TextToSend + "--");
        }

        private void msgBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.TextToSend = "MV1";
            client.sendMSG();
            msgBox.Items.Add("--" + client.TextToSend + "--");
        }

        private void mvToPoint2Btn_Click(object sender, EventArgs e)
        {
            client.TextToSend = "MV2";
            client.sendMSG();
            msgBox.Items.Add("--" + client.TextToSend + "--");
        }

        private void mvToPoint3Btn_Click(object sender, EventArgs e)
        {
            client.TextToSend = "MV3";
            client.sendMSG();
            msgBox.Items.Add("--" + client.TextToSend + "--");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.TextToSend = "LOP";
            client.sendMSG();
            msgBox.Items.Add("--" + client.TextToSend + "--");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            client.TextToSend = "STP";
            //client.sendMSG();
            //msgBox.Items.Add("--" + client.TextToSend + "--");
        }

        private void autoOp(Object sender, EventArgs e)
        {
            client.TextToSend = "LOP";
            client.sendMSG();
            msgBox.Items.Add("--" + client.TextToSend + "--");
        }

        private void manualOp(Object sender, EventArgs e)
        {
            client.TextToSend = "STP";
            //client.sendMSG();
            //msgBox.Items.Add("--" + client.TextToSend + "--");
        }

        private void connectdatabase_Click(object sender, EventArgs e)
        {
            try
            {
                connector = new MySqlConnector("127.0.0.1", "endurancetesting", "root", "");
            }
            catch(Exception er)
            {
                Console.WriteLine(er.Message);
            }

        }
    }
}
