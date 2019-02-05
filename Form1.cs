using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Media;
using System.IO;

namespace MyChat
{

    public partial class Form1 : Form
    {
        private Sender       send;
        private Recipient    rec;
        private string       name;

        public Form1()
        {
            InitializeComponent();
            this.Connect.Enabled = false;
            this.FormClosing += Form_Closing;
        }

        public void ReciverResetButton ()
        {       
            this.Server.Enabled = true;
            this.ReciveTextBox.Items.Add("Ошибка при запуске сервера! Проверьте правильность вводимых данных.");
            rec = null;
        }

        public void SenderResetButton(string eror)
        {
            this.Connect.Enabled = true;
            this.ReciveTextBox.Items.Add("Ошибка при попытке подключиться! Проверьте правильность вводимых данных.");
            send = null;
        }

        public void AddMess(string msg)
        {
            this.ReciveTextBox.Items.Add(msg);

        }

        public void SetAccept()
        {
            Thread t = new Thread(rec.AcceptClient);
            t.Start();
            this.Connect.Enabled = true;
        }

        public  void ReciveMSG()
        {
            ReciveTextBox.Items.Add("Клиент подключился!");
            Thread t = new Thread(rec.ReciveMes);
            t.Start();   
        }

        public  void SetConnect()
        {
            send.Connect();
            this.Connect.Enabled = false;
        } 

        public void AddEror (string eror)
        {
            StreamWriter file = new StreamWriter(@"\System Eror.txt");
            file.Write(eror);
            file.Close();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ( OutIP.Text != "" && OutPort.Text != "" )
                {
                   
                    string Out_ip = OutIP.Text;
                    int Out_port = Convert.ToInt32(OutPort.Text);  

                    send = new Sender(Out_ip, Out_port);
                    send.Connect();

                   send.MsgSendEror += SenderResetButton;
                   //send.MsgSendEror += AddEror;
                    if (send.Socket() != null)
                        Connect.Enabled = false;
                    else
                        SendButton.Enabled = false;
                }
                else
                    MessageBox.Show("The fields are not filled");
            }
            catch(Exception exc)
            {
                this.SenderResetButton(exc.ToString() + '\n' + exc.Message);
                //this.AddEror(exc.ToString() + '\n' + exc.Message);
                MessageBox.Show(exc.ToString() + '\n' + exc.Message);
            }
        }

        private void AutoButton_Click(object sender, EventArgs e)
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    MyIP.Text = ip.ToString();
                    MyPort.Text = Convert.ToString(20000);
                    OutIP.Text = ip.ToString(); 
                    OutPort.Text = Convert.ToString(20000);
                }
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (SendTextBox.Text != "")
            {
                send.Send(name + ": " + SendTextBox.Text);
                ReciveTextBox.Items.Add(name +": " + SendTextBox.Text);
                SendTextBox.Clear();
            }
        }

        private void Server_Click(object sender, EventArgs e)
        {
            if (MyIP.Text != "" && MyPort.Text != "" && NameBox.Text != "")
            {
                name = NameBox.Text;
                string My_ip = MyIP.Text;
                int My_port = Convert.ToInt32(MyPort.Text);

                rec = new Recipient(My_ip, My_port);

                rec.ServerInLIsten += SetAccept;
                rec.NewClient += ReciveMSG;
                rec.NewMSG += AddMess;
                rec.ConnectionError += ReciverResetButton;

                Thread thread = new Thread(new ThreadStart(rec.Listening));
                thread.Start();

                ReciveTextBox.Items.Add("Сервер запущен. Ожидание подключения...");
                this.Server.Enabled = false;
            }
            else
                MessageBox.Show("The fields are not filled");
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (rec != null)
                rec.Close();
            if(send != null)
                send.Close();
        }
    }
}
