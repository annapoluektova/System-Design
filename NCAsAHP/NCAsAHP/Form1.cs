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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patienttoWaitingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatienttoWaitingList ptwl = new PatienttoWaitingList();
            ptwl.Show();
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prescription p = new Prescription();
            p.Show();
        }

        private void specialistAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecialistAppointment sa = new SpecialistAppointment();
            sa.Show();
        }
    }
}
