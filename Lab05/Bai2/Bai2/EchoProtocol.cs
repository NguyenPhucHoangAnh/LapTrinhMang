using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Bai2
{
    class EchoProtocol : IProtocol
    {
        public const int BUFSIZE = 32; //Byte size off IO buffer
        private Socket clnSock; //Connection socket
        private ILogger logger; //Logging Facility
        public EchoProtocol(Socket clnSock , ILogger logger)
        {
            this.clnSock = clnSock;
            this.logger = logger;
        }

        public void handleclient()
        {
            ArrayList entry =new ArrayList();
            entry.Add("Client address and port = " + clnSock.RemoteEndPoint);
            entry.Add("Thread = " + Thread.CurrentThread.GetHashCode());

            try
            {
                int recvMsgSize;
                int totalBytesEchoed = 0;
                byte[] rcvBuffer = new byte[BUFSIZE];
                try
                {
                    while ((recvMsgSize = clnSock.Receive(rcvBuffer, 0, rcvBuffer.Length, SocketFlags.None)) > 0)
                    {
                        clnSock.Send(rcvBuffer, 0, recvMsgSize, SocketFlags.None);
                        totalBytesEchoed += recvMsgSize;
                    }
                }
                catch (SocketException se)
                {
                    entry.Add(se.ErrorCode + ":" + se.Message);
                }
                entry.Add("Client finished; echoed " + totalBytesEchoed + " bytes.");
            }
            catch (SocketException se) 
            {
                entry.Add(se.ErrorCode + ":" + se.Message);
            }
            clnSock.Close();
            logger.writeEntry(entry);
        }
    }
}
