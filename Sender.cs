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
    class Sender
    {
        
        private Socket socket;       
        IPEndPoint endPoint;
        //----------------------------------------------//
        public delegate void Eror(string eror);
        public event Eror MsgSendEror;

        public Socket Socket() { return socket; }

        public void setSocket(Socket set) { this.socket = set; }

        public Sender() { }

        public Sender(string ip, int port)
        {
            try
            {
                this.endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            }
            catch (Exception e)
            {
                MsgSendEror(e.ToString() + '\n' + e.Message);
                //MessageBox.Show(e.ToString() + '\n' + e.Message);
            }
        }

        public void Connect()
        {
            try
            {                
                socket.Connect(endPoint);  
            }
            catch (Exception e)
            {        
                MsgSendEror(e.ToString() + '\n' + e.Message);
                //MessageBox.Show();
            }
        }

        public void Send(string message)
        {
            try
            {
                if (socket != null)
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    socket.Send(data, data.Length, 0);
                }
                else
                    MsgSendEror("Socket in Sender::Send is null");
            }
            catch (Exception e)
            {
               MessageBox.Show(e.ToString() + '\n' + e.Message);             
            }
        }

        public void Close()
        {
            if (socket == null)
                socket.Close();
        }
    }
}
