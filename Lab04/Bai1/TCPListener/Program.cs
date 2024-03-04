﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPListener
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int recv;
            byte[] data = new byte[1024];
            TcpListener newsock = new TcpListener(9000);
            newsock.Start();
            Console.WriteLine("Waiting for a client");
            //
            TcpClient client = newsock.AcceptTcpClient();
            //
            NetworkStream ns = client.GetStream();
            Console.WriteLine(client.Client.RemoteEndPoint.ToString());
            string welcom = "Welcom to the server";
            data = Encoding.ASCII.GetBytes(welcom);
            ns.Write(data, 0, data.Length);
            while (true)
            {
                data = new byte[1024];
                recv = ns.Read(data, 0, data.Length);
                if (recv == 0)
                {
                    break;
                }

                Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
                ns.Write(data, 0, recv);
            }
            ns.Close();
            client.Close();
            newsock.Stop();
        }
    }
}
