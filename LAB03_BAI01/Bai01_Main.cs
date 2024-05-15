using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_BAI01
{
    public partial class Bai01_Main : Form
    {
        public Bai01_Main()
        {
            InitializeComponent();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Bai01_Client client = new Bai01_Client();
            client.Show();
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            Bai01_Server server = new Bai01_Server();
            server.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
