using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace MultiThreadLib
{
	public class NServer
	{
		public IPAddress ip { get; set; }
		public int port { get; set; }
		public delegate void SetTextToControl(string message);
		public SetTextToControl SetMessage;
		public SetTextToControl SetStatus;
		public SetTextToControl SetClient;

		private string firstMessage = "Hello Client";
		private int maxSize = 1024;
		private byte[] buff;
		private int bytes;
		private Socket client;
		private Socket server;

		public NServer(IPAddress ip, int port, Socket server)
		{
			this.ip = ip;
			this.port = port;
			this.server = server;
		}

		public void Start()
		{
			try
			{
				server.BeginAccept(new AsyncCallback(AcceptCallback), server);
			}
			catch (Exception)
			{
			}
			SetStatus("Waiting others for connecting...");
		}

		public void Stop()
		{
			// client.Close();
			server.Close();
		}

		private void AcceptCallback(IAsyncResult ar)
		{
			Socket server = (Socket)ar.AsyncState;
			try
			{
				client = server.EndAccept(ar);
			}
			catch (Exception)
			{
				Thread.CurrentThread.Abort();
				return;
			}
			EndPoint remote = client.RemoteEndPoint;
			SetClient(remote.ToString());
			buff = Encoding.UTF8.GetBytes(firstMessage);
			client.BeginSend(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(SendCallback), client);
		}

		private void SendCallback(IAsyncResult ar)
		{
			Socket server = (Socket)ar.AsyncState;
			server.EndSend(ar);
			buff = new byte[maxSize];
			server.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), server);
		}

		private void ReceiveCallback(IAsyncResult ar)
		{
			Socket server = (Socket)ar.AsyncState;
			try
			{
				bytes = server.EndReceive(ar);
			}
			catch (Exception)
			{
				SetMessage("Error occurs when receiving data");
				Stop();
				Start();
				return;
			}
			if (bytes == 0)
			{
				Stop();
				SetStatus("Client disconnected");
			}
			else
			{
				string message = Encoding.UTF8.GetString(buff, 0, bytes);
				SetMessage("Client: " + message);
				server.BeginSend(buff, 0, bytes, SocketFlags.None, new AsyncCallback(SendCallback), server);
			}
		}

	}
}
