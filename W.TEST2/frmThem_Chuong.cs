using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BusinessLogicTier;
using DevComponents.DotNetBar;

namespace W.TEST
{
    public partial class frmThem_Chuong : Office2007Form
    {

        public frmThem_Chuong()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
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
                MessageBoxEx.Show("<font color=\"#FF0000\">Lỗi tràn số</font> !", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.SelectAll();
                txtMa.Focus();
                return false;
            }
            return true;
        }

        private bool kiemTra_trungMa()
        {
            return new BL_Chuong(Convert.ToInt32(txtMa.Text)).getChuong_theo_maChuong().Rows.Count > 0;
            //true: trung
            //false: khong trung
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (!kiemTra_nhapLieu()) return;
            if (kiemTra_trungMa())
            {
                MessageBoxEx.Show("Đã có mã chương <font color=\"#FF0000\">" + txtMa.Text + "</font> này! Vui lòng chọn mã khác!", "Trùng mã chương",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.SelectAll();
                txtMa.Focus();
                return;
            }
            DataTable dt = new BL_Chuong().getChuong_cauTruc();
            DataRow r = dt.NewRow();
            r["MaChuong"] = txtMa.Text;
            r["TenChuong"] = txtTen.Text;
            dt.Rows.Add(r);
            if (new BL_Chuong(dt).updateChuong() == 0)
                MessageBoxEx.Show("<font color=\"#FF0000\">Thêm chương mới thất bại</font>!", "Thêm chương",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Thêm chương mới thành công!</font>", "Thêm chương",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}