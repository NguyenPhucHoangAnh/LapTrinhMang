using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    internal class Program
    {
        static void GetHostInfo(string host)
        {
            try
            {
                IPHostEntry hostInfo = Dns.GetHostEntry(host);
                //Display host name
                Console.WriteLine("Ten mien: " + hostInfo.HostName);
                //Display list of IP address
                Console.Write("Dia chi IP: ");
                foreach (IPAddress ipaddr in hostInfo.AddressList)
                {
                    Console.Write(ipaddr.ToString() + " ");
                }
                Console.WriteLine();
            }
            catch (Exception)
            {

                Console.WriteLine("Khong phan giai duoc ten mien:" + host + "\n");
            }
        }
        public static string ShowNetworkInfo()
        {
            StringBuilder builder = new StringBuilder();
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                builder.AppendLine("Tên Adapter: " + adapter.Description);
                foreach (UnicastIPAddressInformation addressInformation in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (addressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        builder.AppendLine("\tĐịa chỉ IP:. . . . . .\t" + addressInformation.Address.ToString());
                        builder.AppendLine("\tSubnet mask:. . . . . \t" + addressInformation.IPv4Mask);
                    }
                }
                var gateway = adapter.GetIPProperties().GatewayAddresses;
                if (gateway.Count > 0)
                {
                    foreach (var item in gateway)
                    {
                        builder.AppendLine("\tDefault gateway:. . . .\t" + item.Address.ToString());
                    }
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine("Phan giai ten mien:" + arg);
                GetHostInfo(arg);
            }
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(ShowNetworkInfo());
            Console.ReadKey();
        }
    }
}
