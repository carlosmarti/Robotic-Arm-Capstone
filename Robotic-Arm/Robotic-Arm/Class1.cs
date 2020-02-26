using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Robotic_Arm
{
    class TCPClient
    {
        //---Server IP and port---
        private int portNum;
        private string serverIp;
        //---data to send to the server---
        string textToSend = DateTime.Now.ToString();
        //---create a TCPClient object at the IP and port no.---
        TcpClient client;
        NetworkStream nwStream;

        public TCPClient(string ip,int pNum )
        {
            try
            {
                serverIp = ip;
                portNum = pNum;
                client = new TcpClient(serverIp, portNum);
                nwStream = client.GetStream();
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


        public void sendMSG()
        {
            try
            {
                //---send the text---
                //---Find the length of data being sent---
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
                System.Diagnostics.Debug.WriteLine("Sending : " + textToSend);
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);

                readMsg();
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void readMsg()
        {
            //---read back the text, predicts size recieved---
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);

            TextToSend = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
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
