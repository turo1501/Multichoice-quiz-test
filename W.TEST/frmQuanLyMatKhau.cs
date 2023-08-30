using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BusinessLogicTier;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace W.TEST
{
    public partial class frmQuanLyMatKhau : Office2007Form
    {
        private BL_Admin objBL_Admin;

        public frmQuanLyMatKhau()
        {
            InitializeComponent();
        }

        private void frmQuanLyMatKhau_Load(object sender, EventArgs e)
        {
            txtID.Text = frmLogin.id;
            loadMatKhau();
        }

        private void loadMatKhau()
        {
            objBL_Admin = new BL_Admin(txtID.Text, null);
            txtMatKhau.Text = objBL_Admin.getAdmin_theo_ID().Rows[0]["Pass"].ToString();
        }

        private void lnkHienThi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool bl = lnkHienThi.Text.Equals("Hiện mật khẩu");
            txtMatKhau.UseSystemPasswordChar = !bl;
            lnkHienThi.Text = bl ? "Ẩn mật khẩu" : "Hiện mật khẩu";
        }

        private void btnThayDoiMK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (new frmThayDoiMatKhau().ShowDialog() == DialogResult.OK) loadMatKhau();
            this.Visible = true;
        }
    }
}