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
    public partial class StaffingRequestDetails : Form
    {
        public StaffingRequestDetails()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clients cl = new Clients();
            cl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientContract clcont = new ClientContract();
            clcont.Show();
        }
    }
}
