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
    public partial class frmXemSua_Lop : Office2007Form
    {
        private string maLop;
        private BL_Lop objBL_Lop;

        public frmXemSua_Lop(string maLop)
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
            this.maLop = maLop;
        }

        private void frmXemSua_Lop_Load(object sender, EventArgs e)
        {
            objBL_Lop = new BL_Lop(maLop);
            DataRow r = objBL_Lop.getLop_theo_Ma().Rows[0];
            txtMa.Text = r["MaLop"].ToString();
            txtTen.Text = r["TenLop"].ToString();
            txtSiSo.Text = r["SiSo"].ToString();
            txtGVCN.Text = r["GVCN"].ToString();
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
            objBL_Lop = new BL_Lop(txtMa.Text);
            return objBL_Lop.getLop_theo_Ma().Rows.Count > 0;
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
            txtGVCN.ReadOnly = !bl;
            if (bl) txtMa.Focus();
        }
        //Download source code tại Sharecode.vn
        private void btnLuu_Click(object sender, EventArgs e)
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
            if (kiemTra_trungMa() && maLop != txtMa.Text)
            {
                MessageBoxEx.Show("Đã có mã lớp <font color=\"#FF0000\">" + txtMa.Text + "</font> này! Vui lòng chọn mã khác!", "Trùng mã lớp",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.SelectAll();
                txtMa.Focus();
                return;
            }
            objBL_Lop = new BL_Lop(maLop);
            DataTable dt = objBL_Lop.getLop_theo_Ma();
            dt.Rows[0]["MaLop"] = txtMa.Text;
            dt.Rows[0]["TenLop"] = txtTen.Text;
            dt.Rows[0]["GVCN"] = txtGVCN.Text;
            objBL_Lop = new BL_Lop(dt);
            if (objBL_Lop.updateLop() == 0)
                MessageBoxEx.Show("<font color=\"#FF0000\">Cập nhật thất bại!</font>", "Cập nhật lớp",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Cập nhật thành công!</font>", "Cập nhật lớp",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}