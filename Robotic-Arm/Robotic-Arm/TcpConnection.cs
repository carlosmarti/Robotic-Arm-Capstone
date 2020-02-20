using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Robotic_Arm
{
    static class TcpConnection
    {
        //Memeber variables
        private static int port;  //81
        private static bool running = false;

        private static TcpListener listener;
        private static Thread serverThread;

        public static void Init(int portNum, string ip)
        {
            
            try
            {
                port = portNum;
                //instance listener to commumicate with server
                var ipAddress = System.Net.IPAddress.Parse(ip);
                listener = new System.Net.Sockets.TcpListener(ipAddress, port);
                Console.WriteLine("created Listener");
                Start();
           
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        
        public static void Start()
        {
            try
            {
                Console.WriteLine("Listening...");
                //start listening for server messages
                listener.Start();

                serverThread = new Thread(new ThreadStart(Run));
                running = true;
                serverThread.Start();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void Run()
        {
            //get client tryng to send message
            var client = listener.AcceptTcpClient();

            try
            {
                while (running)
                {
                    

                    NetworkStream netS = client.GetStream();

                    byte[] buffer = new byte[client.ReceiveBufferSize];
                    int bytesRead = netS.Read(buffer, 0, client.ReceiveBufferSize);

                    string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Console.WriteLine("received: {0}", dataReceived);

<<<<<<< HEAD

=======
>>>>>>> cd6b4d333dd04e4b4b670e766c6af6501feadd01
                    //write back to server
                    //Console.WriteLine("Sending data back");
                    //netS.Write(buffer, 0, bytesRead);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //close client open connections
                client.Close();
                Console.ReadLine();
            }
            
        }

        public static void StopServer()
        {
            listener.Stop();
            Console.WriteLine("closed server");
        }

        public static bool Running
        {
            get { return running; }
            set { running = value; }
        }


    }
}

