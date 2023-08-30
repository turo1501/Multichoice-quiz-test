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
    public partial class frmXemSua_Chuong : Office2007Form
    {
        private int maChuong;
        private BL_Chuong objBL_Chuong;

        public frmXemSua_Chuong(int maChuong)
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
            this.maChuong = maChuong;
        }

        private void frmXemSua_Chuong_Load(object sender, EventArgs e)
        {
            objBL_Chuong = new BL_Chuong(maChuong);
            DataRow r = objBL_Chuong.getChuong_theo_maChuong().Rows[0];
            txtMa.Text = maChuong.ToString();
            txtTen.Text = r["TenChuong"].ToString();
        }

        private bool kiemTra_nhapLieu()
        {
            if (txtMa.Text.Trim().Equals(""))
            {
                MessageBoxEx.Show("Bạn hãy nhập <font color=\"#FF0000\">Mã chương</font> !", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.SelectAll();
                txtMa.Focus();
                return false;
            }
            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBoxEx.Show("Bạn hãy nhập <font color=\"#FF0000\">Tên chương</font> !", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.SelectAll();
                txtTen.Focus();
                return false;
            }
            try
            {
                Convert.ToInt32(txtMa.Text);
            }
            catch (FormatException)
            {
                MessageBoxEx.Show("Bạn hãy nhập Mã chương <font color=\"#FF0000\">kiểu số</font> !", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.SelectAll();
                txtMa.Focus();
                return false;
            }
            catch (OverflowException)
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Lỗi tràn số!</font>", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.SelectAll();
                txtMa.Focus();
                return false;
            }
            return true;
        }

        private bool kiemTra_trungMa()
        {
            objBL_Chuong = new BL_Chuong(Convert.ToInt32(txtMa.Text));
            return objBL_Chuong.getChuong_theo_maChuong().Rows.Count > 0;
            //true: trùng
            //false: không trùng
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool bl = btnSua.Text.Equals("Sửa");
            this.btnSua.Image = bl ? global::W.TEST.Properties.Resources.Cancel_32 :
                global::W.TEST.Properties.Resources.Gnome_Logviewer_32;
            btnLuu.Enabled = bl;
            btnSua.Text = bl ? "Hủy" : "Sửa";
            txtMa.ReadOnly = !bl;
            txtTen.ReadOnly = !bl;
            if (bl) txtMa.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!kiemTra_nhapLieu()) return;
            if (kiemTra_trungMa() && maChuong != Convert.ToInt32(txtMa.Text))
            {
                MessageBoxEx.Show("Đã có mã chương <font color=\"#FF0000\">" + txtMa.Text + "</font> này! Vui lòng chọn mã khác!", "Trùng mã chương",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.SelectAll();
                txtMa.Focus();
                return;
            }
            objBL_Chuong = new BL_Chuong(maChuong);
            DataTable dt = objBL_Chuong.getChuong_theo_maChuong();
            dt.Rows[0]["MaChuong"] = Convert.ToInt32(txtMa.Text);
            dt.Rows[0]["TenChuong"] = txtTen.Text;
            if (new BL_Chuong(dt).updateChuong() == 0)
                MessageBoxEx.Show("<font color=\"#FF0000\">Cập nhật thất bại!</font>", "Cập nhật câu hỏi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Cập nhật thành công!</font>", "Cập nhật câu hỏi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
