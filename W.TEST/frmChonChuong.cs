using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BusinessLogicTier;

namespace W.TEST
{
    public partial class frmChonChuong : Form
    {
        public int chuong = 2;

        public frmChonChuong()
        {
            InitializeComponent();
        }

        private void frmChonChuong_Load(object sender, EventArgs e)
        {
            DataTable dt = new BL_Chuong().getAllChuong();
            chk1.Text = dt.Rows[0]["TenChuong"].ToString();
            chk2.Text = dt.Rows[1]["TenChuong"].ToString();
            chk3.Text = dt.Rows[2]["TenChuong"].ToString();
            chk4.Text = dt.Rows[3]["TenChuong"].ToString();
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3.Checked)
                chuong = 3;
            else
            {
                chk4.Checked = false;
                chuong = 2;
            }
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4.Checked)
            {
                chuong = 4;
                chk3.Checked = true;
            }
            else
                chuong = 3;
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            ((CheckBox)sender).Checked = true;
        }
    }
}
