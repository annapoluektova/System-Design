using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSSM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void staffingRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffingRequests sr = new StaffingRequests();
            sr.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients c = new Clients();
            c.Show();
        }

        private void contractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contracts con = new Contracts();
            con.Show();
        }
    }
}
