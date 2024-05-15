using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_BAI03
{
    public partial class Bai03_Main : Form
    {
        public Bai03_Main()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Bai03_Client client = new Bai03_Client();
            client.Show();
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            Bai03_Server server = new Bai03_Server();
            server.Show();
        }
    }
}
