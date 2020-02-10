using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Robotic_Arm
{
    class TcpConnection
    {
        //Memeber variables
        private int port = 81;

        public TcpConnection()
        {

            try
            {

                //instance listener to commumicate with server
                var ipAddress = System.Net.IPAddress.Any;
                var listener = new System.Net.Sockets.TcpListener(ipAddress, port);
                Console.WriteLine("Listening...");

                //start listening for server messages
                listener.Start();

                //get client tryng to send message
                var client = listener.AcceptTcpClient();


                NetworkStream netS = client.GetStream();

                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = netS.Read(buffer, 0, client.ReceiveBufferSize);

                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("received: {0}", dataReceived);

                //write back to server
                Console.WriteLine("Sending data back");
                netS.Write(buffer, 0, bytesRead);

                //close all open connections
                client.Close();
                listener.Stop();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

