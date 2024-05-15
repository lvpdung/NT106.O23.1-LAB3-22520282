using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_BAI04
{
    public partial class Lab03_Bai04 : Form
    {
        public Lab03_Bai04()
        {
            InitializeComponent();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Bai04_Client client = new Bai04_Client();
            client.Show();
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            Bai04_Server server = new Bai04_Server();   
            server.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
