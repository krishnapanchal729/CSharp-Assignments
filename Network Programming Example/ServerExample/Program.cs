using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPAddress ipAdd = IPAddress.Parse("127.0.0.1"); // use local m/c ip address

                /* Initializes the listener */
                TcpListener myList = new TcpListener(ipAdd, 8001);

                /* Start Listening at the specified port */
                myList.Start();

                Console.WriteLine("The server is running at port 8001");
                Console.WriteLine("The local End-point id :" + myList.LocalEndpoint);
                Console.WriteLine("Waiting for a connection....");

                //Accepts the connection
                Socket s = myList.AcceptSocket();
                Console.WriteLine("Connection Accepted from" + s.RemoteEndPoint);

                //Get the data
                byte[] b = new byte[100];
                int k = s.Receive(b);
                Console.WriteLine("Received...");
                for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(b[i]));

                //Send the Replay
                ASCIIEncoding asen = new ASCIIEncoding();
                s.Send(asen.GetBytes("The message was received by the server."));
                Console.WriteLine("\nSent Acknowledgement");

                //Clean Up
                s.Close();
                myList.Stop();
            }
            catch ( Exception e)
            {
                Console.WriteLine("Error......" + e.StackTrace);
            }
        }
    }
}
