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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contracts contr = new Contracts();
            contr.Show();
        }
    }
}
