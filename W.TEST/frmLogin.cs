using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BusinessLogicTier;
using DevComponents.DotNetBar;

namespace W.TEST
{
    public partial class frmLogin : Office2007Form
    {
        public static string id;

        public frmLogin()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
        }

        private bool kiemTra()
        {
            if (txtID.Text.Trim().Equals(""))
            {
                MessageBoxEx.Show("Bạn hãy nhập <font color=\"#FF0000\">ID</font> !", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.SelectAll();
                txtID.Focus();
                return false ;
            }
            if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBoxEx.Show("Bạn hãy nhập <font color=\"#FF0000\">Password</font> !", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.SelectAll();
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!kiemTra())
                return;
            if (!new BL_Admin(txtID.Text,txtPassword.Text).trueLogin())
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Đăng nhập không thành công !</font>", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.SelectAll();
                txtID.Focus();
                return;
            }
            MessageBoxEx.Show("<font color=\"#FF0000\">Chúc mừng bạn đã đăng nhập thành công !</font>", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            id = txtID.Text;
            new frmThaoTacCSDL().ShowDialog();
            txtID.Clear();
            txtPassword.Clear();
            txtID.Focus();
        }
    }
}
