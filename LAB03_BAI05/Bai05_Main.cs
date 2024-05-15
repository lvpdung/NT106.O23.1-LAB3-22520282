using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_BAI05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Bai05_Client client = new Bai05_Client();
            client.Show();
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            Bai05_Server server = new Bai05_Server();
            server.Show();
        }
    }
}
