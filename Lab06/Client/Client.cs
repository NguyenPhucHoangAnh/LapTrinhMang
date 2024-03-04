using MultiThreadLib;
using System;
using System.Net;
using System.Windows.Forms;

namespace Client
{
	public partial class Client : Form
	{
		private int port;
		private IPAddress ip;
		private NClient Nclient;

		public Client()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			tbxStatus.Text = "Connecting ... ";
			port = GetPort();
			if (port == 0)
			{
				MessageBox.Show("The port is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			ip = GetIP();
			if (ip == IPAddress.None)
			{
				MessageBox.Show("The IP address is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Nclient = new NClient(ip, port);
			Nclient.SetMessage = new NClient.SetTextToControl(SetMessage);
			Nclient.SetStatus = new NClient.SetTextToControl(SetStatus);
			Nclient.Connect();
		}

		private void SetMessage(string message)
		{
			tbxReceive.Text += message + "\r\n";
		}

		private void SetStatus(string message)
		{
			tbxStatus.Text = message;
		}

		private void btnDisconnect_Click(object sender, EventArgs e)
		{
			Nclient.Disconnect();
			Application.Exit();
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			string message = tbxText.Text;
			if (message != "")
				Nclient.Send(message);
			tbxText.Text = "";
		}

		private IPAddress GetIP()
		{
			if (IPAddress.TryParse(tbxIP.Text, out IPAddress ip))
				return ip;
			return IPAddress.None;
		}

		private int GetPort()
		{
			if (int.TryParse(tbxPort.Text, out int port))
				return port;
			return 0;
		}

		private void Client_FormClosing(object sender, FormClosingEventArgs e)
		{
			btnDisconnect.PerformClick();
		}
	}
}
