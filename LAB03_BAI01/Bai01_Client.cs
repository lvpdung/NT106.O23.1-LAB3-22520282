using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_BAI01
{
    public partial class Bai01_Client : Form
    {
        public Bai01_Client()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo kết nối UDP
                UdpClient udpClient = new UdpClient();

                // Chuyển đổi chuỗi thông điệp sang kiểu byte
                Byte[] sendBytes = Encoding.ASCII.GetBytes(textBoxMassage.Text);

                // Gởi dữ liệu mà không cần thiết lập kết nối với Server
                udpClient.Send(sendBytes, sendBytes.Length, textBoxIP.Text, int.Parse(textBoxPort.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
