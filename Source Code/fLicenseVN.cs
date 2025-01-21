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
    public partial class fLicenseVN : Form
    {
        public fLicenseVN()
        {
            InitializeComponent();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void linkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkWeb.LinkVisited = true;
        }
    }
}
