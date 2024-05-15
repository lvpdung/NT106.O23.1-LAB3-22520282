using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_BAI06
{
    public partial class Bai06_Server : Form
    {
        public Bai06_Server()
        {
            InitializeComponent();
        }

        Socket Client;
        IPEndPoint IPEP;
        TcpListener Listener;

        private void buttonListen_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        void Addmessage(string message)
        {
            listViewMessages.Items.Add(message);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Connect()
        {
            IPEP = new IPEndPoint(IPAddress.Any, int.Parse(textBoxPort.Text));
            Listener = new TcpListener(IPEP);
            Addmessage("Server started!");
            // Tạo luồng để nhận kết nối
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    // Lắng nghe kết nối
                    Listener.Start();
                    // Chấp nhận kết nối
                    Client = Listener.AcceptSocket();
                    Addmessage("New client connected from " + Client.RemoteEndPoint.ToString());
                    // Tạo luồng xử lý dữ liệu
                    Thread receive = new Thread(Receive);
                    receive.IsBackground = true;
                    receive.Start(Client);
                }
            });
            thread.IsBackground = true;
            thread.Start();
            // Nhận và xử lý dữ liệu từ client
            void Receive(Object obj)
            {
                while (true)
                {
                    Socket client = obj as Socket;
                    byte[] recv = new byte[1000];
                    Client.Receive(recv);
                    string str = Encoding.UTF8.GetString(recv);
                    Addmessage(str);
                }
            }
        }
    }
}
