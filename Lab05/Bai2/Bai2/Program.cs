﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
            static void Main(string[] args)
            {
                RunInCMD(9000);
            }

            private static void RunInCMD(string[] args)
            {
                if (args.Length != 1)
                    throw new AggregateException("Missing parameter!");
                int port = int.Parse(args[0]);
                TcpListener listener = new TcpListener(IPAddress.Any, port);
                ILogger logger = new ConsoleLogger();
                listener.Start();
                Run(listener, logger);
            }

            private static void RunInCMD(int port)
            {
                TcpListener listener = new TcpListener(IPAddress.Any, port);
                ILogger logger = new ConsoleLogger();
                listener.Start();
                Run(listener, logger);
            }

            private static void Run(TcpListener listener, ILogger logger)
            {
                int i = 1;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Waiting for a new client...");
                        Socket clientSocket = listener.AcceptSocket();
                        EchoProtocol protocol = new EchoProtocol(clientSocket, logger);
                        Thread thread = new Thread(protocol.handleclient);
                        thread.Start();
                        logger.writeEntry($"#{i}. A new thread established and this is thread number: {thread.GetHashCode()}");
                    }
                    catch (IOException e)
                    {
                        logger.writeEntry("Error: " + e.Message);
                    }
                    i++;
                }
            }

    }
}
