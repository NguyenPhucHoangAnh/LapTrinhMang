using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            DisplayIPDetails();
        }
        private void DisplayIPDetails()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                rtbInfo.AppendText($"Tên giao diện: {networkInterface.Name}\n");
                if (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
                    UnicastIPAddressInformationCollection unicastAddresses = ipProperties.UnicastAddresses;

                    foreach (UnicastIPAddressInformation address in unicastAddresses)
                    {
                        rtbInfo.AppendText($"Địa chỉ IP: {address.Address}\n");
                        rtbInfo.AppendText($"Subnet Mask: {address.IPv4Mask}\n");
                    }

                    GatewayIPAddressInformationCollection gatewayAddresses = ipProperties.GatewayAddresses;

                    foreach (GatewayIPAddressInformation gatewayAddress in gatewayAddresses)
                    {
                        rtbInfo.AppendText($"Default Gateway: {gatewayAddress.Address}\n");
                    }
                }
                rtbInfo.AppendText("\n");
            }
        }
        private void GetHostInfo(string host)
        {
            try
            {
                IPHostEntry hostInfo = Dns.GetHostEntry(host);
                rtbInfo.AppendText($"Tên miền: {hostInfo.HostName}\n");
                rtbInfo.AppendText($"Địa chỉ ip: \n");
                foreach (IPAddress ipaddr in hostInfo.AddressList)
                {
                    rtbInfo.AppendText(ipaddr.ToString() + "\n");
                }

            }
            catch
            {
                rtbInfo.AppendText("không phân giải được ten miền:" + host + "\n");
            }
        }

        private void btnPhanGiai_Click(object sender, EventArgs e)
        {
            rtbInfo.Clear();
            GetHostInfo(txtTenMien.Text);
        }
    }
}
