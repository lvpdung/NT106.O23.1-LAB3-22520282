using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_BAI06
{
    public partial class Bai06_Main : Form
    {
        public Bai06_Main()
        {
            InitializeComponent();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Bai06_Client client = new Bai06_Client();
            client.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            Bai06_Server server = new Bai06_Server();
            server.Show();
        }
    }
}
