using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB03_BAI01
{
    public partial class Bai01_Server : Form
    {
        public Bai01_Server()
        {
            InitializeComponent();
        }

        private void InfoMessage(string message)
        {
            // Tạo một ListViewItem mới với nội dung là thông điệp
            ListViewItem item = new ListViewItem(message);

            // Thêm item vào ListView
            listViewMessages.Items.Add(item);
        }

        public void serverThread()
        {
            try
            {
                // Khởi tạo UDP server để lắng nghe các gói tin từ client
                UdpClient udpClient = new UdpClient(int.Parse(textBoxPort.Text));

                InfoMessage("Server is listening for connections...");

                while (true)
                {
                    // Nhận dữ liệu từ client
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, int.Parse(textBoxPort.Text));
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    string mess = returnData.ToString();

                    // Viết hàm InfoMessage để hiển thị thông điệp lên List View
                    InfoMessage(mess);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
