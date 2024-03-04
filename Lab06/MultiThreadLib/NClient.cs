using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MultiThreadLib
{
	public class NClient
	{
		public int port { get; set; }
		public IPAddress ip { get; set; }
		public delegate void SetTextToControl(string message);
		public SetTextToControl SetMessage;
		public SetTextToControl SetStatus;

		private int maxSize = 1024;
		private byte[] buff;
		private int bytes;
		private Socket server;
		private IPEndPoint serverEndPoint;
		private string messageServer;

		public NClient(IPAddress ip, int port)
		{
			this.port = port;
			this.ip = ip;
		}

		public void Connect()
		{
			server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			serverEndPoint = new IPEndPoint(IPAddress.Loopback, port);
			server.BeginConnect(serverEndPoint, new AsyncCallback(ConnectCallback), server);
		}

		private void ConnectCallback(IAsyncResult ar)
		{
			Socket server = (Socket)ar.AsyncState;
			try
			{
				SetStatus("Connecting...");
				server.EndConnect(ar);
				SetStatus("Connected successfully");
			}
			catch (Exception e)
			{
				SetStatus("Failure connection");
				return;
			}
			buff = new byte[maxSize];
			server.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), server);
		}

		private void ReceiveCallback(IAsyncResult ar)
		{
			Socket server = (Socket)ar.AsyncState;
			bytes = server.EndReceive(ar);
			messageServer = Encoding.UTF8.GetString(buff, 0, bytes);
			SetMessage(messageServer);
		}

		private void SendCallback(IAsyncResult ar)
		{
			Socket server = (Socket)ar.AsyncState;
			server.EndSend(ar);
			buff = new byte[maxSize];
			server.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), server);
		}

		public bool Disconnect()
		{
			try
			{
				server.Shutdown(SocketShutdown.Both);
				server.Close();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public void Send(string message)
		{
			buff = Encoding.UTF8.GetBytes(message);
			server.BeginSend(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(SendCallback), server);
		}
	}
}
