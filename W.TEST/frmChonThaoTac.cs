using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace W.TEST
{
    public partial class frmChonThaoTac : DevComponents.DotNetBar.Office2007Form
    {
        public frmChonThaoTac()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmLogin().ShowDialog();
            this.Visible = true;
        }

        private void btnLamBaiThi_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DialogResult dlr;
            do dlr = new frmNhapMSSV().ShowDialog();
            while (dlr == DialogResult.Retry);
        }

        private void frmChonThaoTac_FormClosed(object sender, FormClosedEventArgs e)
        {
            new frmAbout().ShowDialog();
        }
    }
}
