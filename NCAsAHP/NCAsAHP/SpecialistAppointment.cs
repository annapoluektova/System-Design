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
    public partial class SpecialistAppointment : Form
    {
        public SpecialistAppointment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patients patien = new Patients();
            patien.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Specialists sp = new Specialists();
            sp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReferralAppointmentRequest rar = new ReferralAppointmentRequest();
            rar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReferralAcknowledgement ra = new ReferralAcknowledgement();
            ra.Show();
        }
    }
}
