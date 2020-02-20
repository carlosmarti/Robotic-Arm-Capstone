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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                var portNum = int.Parse(txtPort.Text);
                TcpConnection.Init(portNum, txtPort.Text);
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
            
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            TcpConnection.Running = false;
            TcpConnection.StopServer();
        }
    }
}
