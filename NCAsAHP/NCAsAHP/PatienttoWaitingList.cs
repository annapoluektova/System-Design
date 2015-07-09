using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NCAsAHP
{
    public partial class PatienttoWaitingList : Form
    {
        public PatienttoWaitingList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patients pa = new Patients();
            pa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WaitingList wl = new WaitingList();
            wl.Show();
        }
    }
}
