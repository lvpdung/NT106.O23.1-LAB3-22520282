using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB03_BAI03
{
    public partial class Bai03_Server : Form
    {
        public Bai03_Server()
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
                    Addmessage("Connection accepted from: " + Client.RemoteEndPoint.ToString());
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
                    Addmessage("From client: " + str);
                }
            }
        }

    }
}
