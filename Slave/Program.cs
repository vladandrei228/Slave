using System;
using System.IO;
using System.Net.Sockets;

namespace Slave
{
   
       class Program
        {
            static void Main(string[] args)
            {
                TcpClient clientSocket = new TcpClient("localhost", 6789);

                Stream ns = clientSocket.GetStream(); //provides a NetworkStream
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);
                sw.AutoFlush = true; // enable automatic flushing

                //request the server for a chunk/dictionary/passwords
                sw.WriteLine("password");

                Console.ReadKey();

                ns.Close();
                clientSocket.Close();

            }
        }

    
}
