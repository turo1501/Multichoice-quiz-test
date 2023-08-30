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
    public partial class frmThayDoiMatKhau : Office2007Form
    {
        private BL_Admin objBL_Admin;

        public frmThayDoiMatKhau()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
        }

        private TextBoxX kiemTra()
        {
            if (txtMKCu.Text.Trim().Equals("")) return txtMKCu;
            if (txtMKMoi.Text.Trim().Equals("")) return txtMKMoi;
            if (txtMKMoi_2.Text.Trim().Equals("")) return txtMKMoi_2;
            return null;
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            TextBoxX txt = kiemTra();
            if (txt != null)
            {
                MessageBoxEx.Show("Bạn hãy nhập <font color=\"#FF0000\">" + txt.Tag + "</font> !", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt.SelectAll();
                txt.Focus();
                return;
            }
            if (txtMKCu.Text.Equals(txtMKMoi.Text))
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Mật khẩu mới bạn nhập giống mật khẩu cũ!</font>",
                    "Mật khẩu mới không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKMoi.SelectAll();
                txtMKMoi.Focus();
                return;
            }
            if (!txtMKMoi.Text.Equals(txtMKMoi_2.Text))
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Mật khẩu xác nhận lại không giống!</font>",
                    "Mật khẩu xác nhận không giống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKMoi.Clear();
                txtMKMoi_2.Clear();
                txtMKMoi.Focus();
                return;
            }
            objBL_Admin = new BL_Admin(frmLogin.id, null);
            DataTable dt = objBL_Admin.getAdmin_theo_ID();
            if (!txtMKCu.Text.Equals(dt.Rows[0]["Pass"].ToString()))
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Mật khẩu cũ bạn nhập không đúng!</font>",
                    "Mật khẩu cũ không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKCu.SelectAll();
                txtMKCu.Focus();
                return;
            }
            dt.Rows[0]["Pass"] = txtMKMoi.Text;
            if (new BL_Admin(dt).updateAdmin() == 0)
                MessageBoxEx.Show("<font color=\"#FF0000\">Thay đổi mật khẩu thất bại!</font>", "Thay đổi mật khẩu",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Thay đổi mật khẩu thành công!</font>", "Thay đổi mật khẩu",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}