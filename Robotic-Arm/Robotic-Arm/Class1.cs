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
        static string textToSend = DateTime.Now.ToString();
        //--data received from sever--
        string txtReceived = "";
        int lp = 1;
        int idNo = 1;
        int testNo = 1;

        Thread armLoop;
       
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

        public int Loop
        {
            get { return lp; }
            set { lp = value; }
        }


        public void sendMSG()
        {
            try
            {
                //---send the text---
                //---Find the length of data being sent---
                //byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
                System.Diagnostics.Debug.WriteLine("Sending : --" + textToSend + "--");
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                
                if(TextToSend.Contains("INF"))
                    readMsg();

                if (TextToSend.Contains("LOP"))
                {
                    armLoop = new Thread(new ThreadStart(this.autoLoop));
                    armLoop.Start();
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void readMsg()
        {
            try
            {

                //---read back the text, predicts size recieved---
                byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                Console.WriteLine(bytesRead);
                TextReceived = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                Console.WriteLine(TextReceived);

                //if a message was received send it to the form
                if (bytesRead > 0)
                {
                    cleanMsg();
                    sendToForm();
                }

                Thread.Sleep(50);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void readMsg(MySqlConnector conn)
        {
            try
            {

                if (lp > 1)
                {
                    lp *= 2;
                }

                int cycleNo = 1;
                string startTime = "";
                string endTime = "";
                for (int i = 0; i < lp; i++)
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

                    if ((i % 2) == 0)
                    {
                        startTime = TextReceived;
                    }
                    else
                    {
                        endTime = TextReceived;
                        storeToDatabase(conn, idNo, cycleNo, testNo, startTime, endTime);
                        cycleNo++;
                        idNo++;
                        
                    }
                        
                    Thread.Sleep(50);

                }
                lp = 1;
                testNo++;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
       
        }

        private void autoLoop()
        {
            while(!TextToSend.Contains("STP"))
            {
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
                System.Diagnostics.Debug.WriteLine("Sending : --" + textToSend + "--");
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                Thread.Sleep(5000);
            }

            byte[] bytesToS = ASCIIEncoding.ASCII.GetBytes(textToSend);
            System.Diagnostics.Debug.WriteLine("Sending : --" + textToSend + "--");
            nwStream.Write(bytesToS, 0, bytesToS.Length);
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

            if(TextToSend == "INF")
            {
                foreach (var msg in messages)
                {
                    lstBox.Items.Add(infoBox[j] + ": " + msg);
                    j++;
                }
            }
            else if(TextToSend == "LP1")
            {
                lstBox.Items.Add("Time: " + TextReceived);
            }
            
        }

        private void storeToDatabase(MySqlConnector con, int id, int cNumber, int tNumber, string sTime, string eTime)
        {
            int dif = difference(sTime, eTime);

            con.Insert("INSERT into endurancetesting (ID, testNo, cycleNo, time) values( " + id.ToString() +"," + tNumber.ToString() + ", " + cNumber.ToString() + ", " + dif.ToString() + " )");
        }

        private int difference(string st, string et)
        {
            string[] startTimeStArr = st.Split(':');
            string[] endTimeStArr = et.Split(':');

            int[] startTimeArr = new int[3];
            for(int i = 0; i < startTimeStArr.Length; i++)
            {
                startTimeArr[i] = int.Parse(startTimeStArr[i]);
            }

            int[] endTimeArr = new int[3];
            for (int i = 0; i < endTimeStArr.Length; i++)
            {
                endTimeArr[i] = int.Parse(endTimeStArr[i]);
            }

            int startTSec = (startTimeArr[0] * 3600) + (startTimeArr[1] * 60) + startTimeArr[2];
            int endT = (endTimeArr[0] * 3600) + (endTimeArr[1] * 60) + endTimeArr[2];

            return endT - startTSec;
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
