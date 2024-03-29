﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Employee;

namespace server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            int byteReceived;

            TcpListener server = new TcpListener(IPAddress.Any, 2308);
            server.Start();
            Console.WriteLine("Waiting for a connection...");

            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Connected succesfully");
            NetworkStream stream = client.GetStream();

            byte[] size = new byte[2];
            byteReceived = stream.Read(size, 0, 2);
            int packageSize = BitConverter.ToInt16(size, 0);
            Console.WriteLine("The size of package: {0}", packageSize);

            byteReceived = stream.Read(data, 0, packageSize);
            Employee.Employee employee = new Employee.Employee(data);
            Console.WriteLine(employee.ToString());

            stream.Close();
            client.Close();
            server.Stop();

            Console.ReadKey();
        }
    }
}
