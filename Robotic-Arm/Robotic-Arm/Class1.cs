using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TCPTesting
{
    class TCPClient
    {
        //---Server IP and port---
        const int PORT_NO = 81;
        const string SERVER_IP = "10.5.196.103";
        public TCPClient()
        {
            //---data to send to the server---
            string textToSend = DateTime.Now.ToString();
            

            //---create a TCPClient object at the IP and port no.---
            TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
            System.Diagnostics.Debug.WriteLine("Connecting...");
            NetworkStream nwStream = client.GetStream();
            System.Diagnostics.Debug.WriteLine("Connected!");
            //---Find the length of data being sent---
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

            //---send the text---
            System.Diagnostics.Debug.WriteLine("Sending : " + textToSend);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);
            //---read back the text, predicts size recieved---
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            System.Diagnostics.Debug.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
            Console.ReadLine();
            client.Close();
        }
    }
}
