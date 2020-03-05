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
        string txtReceived = "";
        //---create a TCPClient object at the IP and port no.---
        int[] point1 = { 43, 82, 20};
        int[] point2 = { 20, 40, 75 };
        int[] point3 = { 65, 48, 71 };
        int[] rot = { 0, 0, 0 };
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

        public string TextReceived
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
                //byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
                string mPoint = "MOVp1";
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
            String [] infoBox = { "", "Val3 Ver", "Arm Type", "Tuning", "Mounting", "Controller SN", "Arm SN", "Starc" };
            string[] messages = TextReceived.Split(',');
            ListBox lstBox = wForm.getInfBox();
            int j = 1;
            foreach (var msg in messages)
            {
                lstBox.Items.Add(infoBox[j] + ": " + msg);
                j++;
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
