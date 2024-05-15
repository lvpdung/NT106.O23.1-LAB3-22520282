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

namespace LAB03_BAI05
{
    public partial class Bai05_Client : Form
    {
        public Bai05_Client()
        {
            InitializeComponent();
        }

        TcpClient tcpClient;
        NetworkStream ns;

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


                // Tạo luồng để đọc và ghi dữ liệu dựa trên NetworkStream
                ns = tcpClient.GetStream();

                // Gửi dữ liệu đến Server
                Byte[] data = System.Text.Encoding.UTF8.GetBytes(textBoxUser.Text);
                ns.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDisconect_Click(object sender, EventArgs e)
        {
            // Đóng kết nối
            ns.Close();
            tcpClient.Close();
        }

        private void buttonCongDong_Click(object sender, EventArgs e)
        {
            // Tạo luồng để đọc và ghi dữ liệu dựa trên NetworkStream
            ns = tcpClient.GetStream();

            // Gửi dữ liệu đến Server
            Byte[] data = System.Text.Encoding.UTF8.GetBytes("Lay ngau nhien mon an tu du lieu cong dong!");
            ns.Write(data, 0, data.Length);
        }

        private void buttonCaNhan_Click(object sender, EventArgs e)
        {
            // Tạo luồng để đọc và ghi dữ liệu dựa trên NetworkStream
            ns = tcpClient.GetStream();

            // Gửi dữ liệu đến Server
            Byte[] data = System.Text.Encoding.UTF8.GetBytes("Lay ngau nhien mon an tu du lieu ca nhan!");
            ns.Write(data, 0, data.Length);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ns.Close();
            tcpClient.Close();
            this.Close();
        }
    }



}
