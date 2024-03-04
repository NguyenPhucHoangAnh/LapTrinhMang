using MultiThreadLib;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Lab6
{
	public partial class Server : Form
	{
		private int port;
		private Socket serverSocket;
		private IPEndPoint serverEndPoint;
		private NServer Nserver;

		public Server()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
		}

		private void DoOnRealTime()
		{
			while (true)
			{
				Thread t = new Thread(() =>
				{
					Nserver = new NServer(IPAddress.Any, port, serverSocket)
					{
						SetMessage = new NServer.SetTextToControl(SetMessage),
						SetStatus = new NServer.SetTextToControl(SetStatus),
						SetClient = new NServer.SetTextToControl(SetClient)
					};
					Nserver.Start();
				});
				t.Start();
			}
		}

		private void Init()
		{
			serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			serverEndPoint = new IPEndPoint(IPAddress.Any, port);
			try
			{
				serverSocket.Bind(serverEndPoint);
			}
			catch (SocketException se)
			{
				return;
			}
			serverSocket.Listen(-1);
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			port = GetPort();
			if (port == 0)
			{
				MessageBox.Show("The port is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Init();
			new Thread(DoOnRealTime).Start();
		}

		private void SetClient(string message)
		{
			cbxClients.Items.Add(message);
			cbxClients.SelectedIndex = 0;
		}

		private void SetStatus(string message)
		{
			tbxStatus.Text = message;
		}

		private void SetMessage(string message)
		{
			tbxReceive.Text += message + "\r\n";
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			Nserver.Stop();
			Environment.Exit(1);
		}

		private void Server_FormClosing(object sender, FormClosingEventArgs e)
		{
			btnStop.PerformClick();
		}

		private int GetPort()
		{
			if (int.TryParse(tbxPort.Text, out int port))
				return port;
			return 0;
		}
	}
}
