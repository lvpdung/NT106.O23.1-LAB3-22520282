using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_BAI06
{
    public partial class Bai06_Client : Form
    {
        public Bai06_Client()
        {
            InitializeComponent();
        }

        TcpClient tcpClient;
        NetworkStream ns;

        private void buttonDisconect_Click(object sender, EventArgs e)
        {
            // Đóng kết nối
            ns.Close();
            tcpClient.Close();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            ns.Close();
            tcpClient.Close();
            this.Close();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng TcpClient
                tcpClient = new TcpClient();
                // Kết nối đến Server với 1 địa chỉ Ip và Port xác định
                IPAddress ipAddress = IPAddress.Parse(textBoxIP.Text);
                int port = int.Parse(textBoxPort.Text);
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);
                tcpClient.Connect(ipEndPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // Tạo luồng để đọc và ghi dữ liệu dựa trên NetworkStream
            ns = tcpClient.GetStream();

            // Gửi dữ liệu đến Server
            Byte[] data = System.Text.Encoding.UTF8.GetBytes(textBoxName.Text + ": " + textBoxMessage.Text);
            ns.Write(data, 0, data.Length);
        }

    }
}
