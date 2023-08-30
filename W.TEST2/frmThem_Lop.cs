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
    public partial class frmThem_Lop : Office2007Form
    {
        public frmThem_Lop()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
        }

        private TextBox kiemTra_nhapLieu()
        {
            if (txtMa.Text.Trim().Equals("")) return txtMa;
            if (txtTen.Text.Trim().Equals("")) return txtTen;
            if (txtGVCN.Text.Trim().Equals("")) return txtGVCN;
            return null;
        }

        private bool kiemTra_trungMa()
        {
            return new BL_Lop(txtMa.Text).getLop_theo_Ma().Rows.Count > 0;
            //true: trùng
            //false: không trùng
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            TextBox txt = kiemTra_nhapLieu();
            if (txt != null)
            {
                MessageBoxEx.Show("Bạn hãy nhập <font color=\"#FF0000\">" + txt.Tag + "</font> !", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt.SelectAll();
                txt.Focus();
                return;
            }
            if (kiemTra_trungMa())
            {
                MessageBoxEx.Show("Đã có mã lớp <font color=\"#FF0000\">" + txtMa.Text + "</font> này! Vui lòng chọn mã khác!", "Trùng mã lớp",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.SelectAll();
                txtMa.Focus();
                return;
            }
            DataTable dt = new BL_Lop().getLop_cauTruc();
            DataRow r = dt.NewRow();
            r["MaLop"] = txtMa.Text;
            r["TenLop"] = txtTen.Text;
            r["SiSo"] = 0;
            r["GVCN"] = txtGVCN.Text;
            dt.Rows.Add(r);
            if (new BL_Lop(dt).updateLop() == 0)
                MessageBoxEx.Show("<font color=\"#FF0000\">Thêm lớp mới thất bại!</font>", "Thêm lớp",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Thêm lớp mới thành công!</font>", "Thêm lớp",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}