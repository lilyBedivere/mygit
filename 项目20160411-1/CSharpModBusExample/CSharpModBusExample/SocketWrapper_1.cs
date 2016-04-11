using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Configuration;

namespace CSharpModBusExample
{
    internal class SocketWrapper : IDisposable
    {
        private static string IP = ConfigurationManager.AppSettings["IP"];
        private static int Port = Int32.Parse(ConfigurationManager.AppSettings["Port"]);
        private static int TimeOut = Int32.Parse(ConfigurationManager.AppSettings["SocketTimeOut"]);

        public ILog Logger { get; set; }
        private Socket socket = null;

        public void Connect()
        {
            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, TimeOut);

            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(IP), Port);
            this.socket.Connect(ip);
        }

        public byte[] Read(int length)
        {
            byte[] data = new byte[length];
            this.socket.Receive(data);
            this.Log("Receive:", data);
            return data;
        }

        public void Write(byte[] data)
        {
            this.Log("Send:", data);
            this.socket.Send(data);
        }

        private void Log(string type, byte[] data)
        {
            if (this.Logger != null)
            {
                StringBuilder logText = new StringBuilder(type);
                foreach (byte item in data)
                {
                    logText.Append(item.ToString() + " ");
                }

                this.Logger.Write(logText.ToString());
            }
        }

        #region IDisposable 成员
        public void Dispose()
        {
            if (this.socket != null)
            {
                this.socket.Close();
            }
        }
        #endregion
    }
}
