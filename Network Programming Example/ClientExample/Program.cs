using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.InteropServices;

namespace ClientExample
{
    class Program
    {
        [DllImport("msvcrt")]
        static extern int _getch();
        static void Main(string[] args)
        {
            try
            {
                TcpClient tcplnt = new TcpClient();
                Console.WriteLine("Connecting....");

                tcplnt.Connect("127.0.0.1", 8001); // use the same ipaddress as in the server progra

                Console.WriteLine("Connected");
                Console.WriteLine("Enter the Message to be Transmitted:");

                //read the contents from console
                String str = Console.ReadLine();
                Stream stm = tcplnt.GetStream();

                //send it to the server as ASCII text encoding
                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                Console.WriteLine("Transmitting....");

                stm.Write(ba, 0, ba.Length);

                byte[] bb = new byte[100];
                int k = stm.Read(bb, 0, 100);

                for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(bb[i]));

                tcplnt.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error....." + e.StackTrace);
            }
            _getch();
        }
    }
}
