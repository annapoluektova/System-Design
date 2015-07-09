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
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patients pat = new Patients();
            pat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrugList dl = new DrugList();
            dl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdatingDrugList udl = new UpdatingDrugList();
            udl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrescriptionForm pf = new PrescriptionForm();
            pf.Show();
        }
    }
}
