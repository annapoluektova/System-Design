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
    public partial class Contracts : Form
    {
        public Contracts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientContractDetails ccd = new ClientContractDetails();
            ccd.Show();
        }
    }
}
