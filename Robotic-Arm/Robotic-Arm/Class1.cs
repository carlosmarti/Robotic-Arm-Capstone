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
        const int PORT_NO = 81;
        const string SERVER_IP = "10.5.196.103";
        //---data to send to the server---
        string textToSend = DateTime.Now.ToString();
        //---create a TCPClient object at the IP and port no.---
        TcpClient client;
        NetworkStream nwStream;

        public TCPClient()
        {
            client = new TcpClient(SERVER_IP, PORT_NO);
            nwStream = client.GetStream();
        }
        public string TextToSend
        {
            get { return textToSend; }
            set { textToSend = value; }
        }


        public void sendMSG()
        {
            //---send the text---
            //---Find the length of data being sent---
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
            System.Diagnostics.Debug.WriteLine("Sending : " + textToSend);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);
            //---read back the text, predicts size recieved---
            //byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            //int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            //System.Diagnostics.Debug.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
        }

        public void stopClient()
        {
            Console.ReadLine();
            client.Close();
        }
    }
}
