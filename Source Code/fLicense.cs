using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class fLicense : Form
    {
        public fLicense()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void linkLabel1_LinkClicked_1(object sender, EventArgs e)
        {
            linkLabel1.LinkVisited = true;
        }

    }
}
