using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Robotic_Arm
{
    class TCPClient
    {
        //---Server IP and port---
        private int portNum;
        private string serverIp;
        //---data to send to the server---
        string textToSend = DateTime.Now.ToString();
        //--data received from sever--
        string txtReceived = "?asd,jfd,irf,jgk ????";
        //---create a TCPClient object at the IP and port no.---
        TcpClient client;
        NetworkStream nwStream;
        Form1 wForm;

        public TCPClient(string ip,int pNum, Form1 form1 )
        {
            try
            {
                wForm = form1;
                serverIp = ip;
                portNum = pNum;
                client = new TcpClient(serverIp, portNum);
                nwStream = client.GetStream();
                Console.WriteLine("yay");
            }
            catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public string TextToSend
        {
            get { return textToSend; }
            set { textToSend = value; }
        }

        public String TextReceived
        {
            get { return txtReceived; }
            set { txtReceived = value; }
        }


        public void sendMSG()
        {
            try
            {
                //---send the text---
                //---Find the length of data being sent---
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
                System.Diagnostics.Debug.WriteLine("Sending : --" + textToSend + "--");
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                readMsg();
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        private void readMsg()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                { //---read back the text, predicts size recieved---
                    byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                    int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                    Console.WriteLine(bytesRead);
                    TextReceived = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                    Console.WriteLine(TextReceived);

                    //if a message was received send it to the form
                    if(bytesRead > 0)
                    {
                        cleanMsg();
                        sendToForm();
                    }
                    Thread.Sleep(50);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            
        }

        private void cleanMsg()
        {
            TextReceived = TextReceived.Replace("?", "");
        }

        private void sendToForm()
        {
            string[] messages = TextReceived.Split(',');
            ListBox lstBox = wForm.getMsgBox();

            foreach (var msg in messages)
            {
                lstBox.Items.Add(msg);
            }
        }

        public void stopClient()
        {
            try
            {
                Console.ReadLine();
                client.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
