using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
namespace MyChat
{
    class Recipient
    {
        Socket      socket;
        Socket      client;        
        IPEndPoint  localPoint;

        public delegate void ChangeSock();
        public event ChangeSock ServerInLIsten;
        public event ChangeSock NewClient;
        public event ChangeSock ConnectionError;
        
        public delegate void MSG(string mes);
        public event MSG NewMSG;    

        public Socket Socket() { return client; }
        public void setSocket(Socket set) { this.socket = set; }

        public Recipient() { }

        public Recipient(string ip, int port)
        {
            this.localPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.SetSocketOption(SocketOptionLevel.Socket,SocketOptionName.ReuseAddress,true);
            
        }

        public void Listening()
        {
            try
            {
                socket.Bind(localPoint);
                socket.Listen(1);  
                ServerInLIsten();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString() + "\n" + e.Message);
                if (ConnectionError != null)
                    ConnectionError();
            }
        }

        public void ReciveMes()
        {
            try
            {
                while (client.Connected)
                {
                    string str = null;
                    while (client.Available > 0)
                    {
                        byte[] data = new byte[1024];
                        client.Receive(data, data.Length, 0);
                        str += Encoding.UTF8.GetString(data);
                    }
                    if (str != null)
                        NewMSG(str);
                    Thread.Sleep(200);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString() + '\n' + e.Message);
                ConnectionError();
            }
        }
        
        public void AcceptClient()
        {
            client = socket.Accept();
            if (client.Connected)
            {
                NewClient();
                socket.Close();
            }
        }

        public void Close()
        {
            if (socket != null)
                socket.Close();
            if (client != null)
                client.Close();
        }
    }
}
