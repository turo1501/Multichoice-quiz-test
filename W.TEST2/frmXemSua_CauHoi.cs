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
    public partial class frmXemSua_CauHoi : DevComponents.DotNetBar.Office2007Form
    {
        private string maCauHoi;
        private BL_CauHoi objBL_CauHoi;

        public frmXemSua_CauHoi(string maCauHoi)
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
            cboDapAn.SelectedIndex = 0;
            this.maCauHoi = maCauHoi;
        }

        private void frmXemSua_CauHoi_Load(object sender, EventArgs e)
        {
            objBL_CauHoi = new BL_CauHoi(maCauHoi);
            DataRow r = objBL_CauHoi.getCauHoi_theoMa().Rows[0];
            txtMa.Text = maCauHoi;
            txtCauHoi.Text = r["CauHoi"].ToString();
            txtA.Text = r["A"].ToString();
            txtB.Text = r["B"].ToString();
            txtC.Text = r["C"].ToString();
            txtD.Text = r["D"].ToString();
            cboDapAn.Text = r["DapAn"].ToString();
            cboChuong.DataSource = new BL_Chuong().getAllChuong();
            cboChuong.DisplayMember = "TenChuong";
            cboChuong.ValueMember = "MaChuong";
            cboChuong.SelectedValue = r["Chuong"].ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool bl = btnSua.Text.Equals("Sửa");
            this.btnSua.Image = bl ? global::W.TEST.Properties.Resources.Cancel_32 :
                global::W.TEST.Properties.Resources.Gnome_Logviewer_32;
            btnLuu.Enabled = bl;
            btnSua.Text = bl ? "Hủy" : "Sửa";
            txtMa.ReadOnly = !bl;
            txtCauHoi.ReadOnly = !bl;
            txtA.ReadOnly = !bl;
            txtB.ReadOnly = !bl;
            txtC.ReadOnly = !bl;
            txtD.ReadOnly = !bl;
            cboDapAn.Enabled = bl;
            cboChuong.Enabled = bl;
            txtCauHoi.ReadOnly = !bl;
            if (bl) txtMa.Focus();
        }
        //Download source code tại Sharecode.vn
        private TextBox kiemTra_nhapLieu()
        {
            if (txtMa.Text.Trim().Equals("")) return txtMa;
            if (txtCauHoi.Text.Trim().Equals("")) return txtCauHoi;
            if (txtA.Text.Trim().Equals("")) return txtA;
            if (txtB.Text.Trim().Equals("")) return txtB;
            if (txtC.Text.Trim().Equals("")) return txtC;
            if (txtD.Text.Trim().Equals("")) return txtD;
            return null;
        }

        private bool kiemTra_trungMa()
        {
            objBL_CauHoi = new BL_CauHoi(txtMa.Text);
            return objBL_CauHoi.getCauHoi_theoMa().Rows.Count > 0;
            //true: trùng
            //false: không trùng
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TextBox txt = kiemTra_nhapLieu();
            if (txt != null)
            {
                MessageBoxEx.Show("Bạn hãy nhập <font color=\"#FF0000\">" + txt.Tag + "</font> !", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (kiemTra_trungMa() && maCauHoi != txtMa.Text)
            {
                MessageBoxEx.Show("Đã có mã <font color=\"#FF0000\">" + txtMa.Text + "</font> này! Vui lòng chọn mã khác!", "Trùng mã",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.SelectAll();
                txtMa.Focus();
                return;
            }
            objBL_CauHoi = new BL_CauHoi(maCauHoi);
            DataTable dt = objBL_CauHoi.getCauHoi_theoMa();
            dt.Rows[0]["MaCauHoi"] = txtMa.Text;
            dt.Rows[0]["CauHoi"] = txtCauHoi.Text;
            dt.Rows[0]["A"] = txtA.Text;
            dt.Rows[0]["B"] = txtB.Text;
            dt.Rows[0]["C"] = txtC.Text;
            dt.Rows[0]["D"] = txtD.Text;
            dt.Rows[0]["DapAn"] = cboDapAn.SelectedItem.ToString();
            dt.Rows[0]["Chuong"] = Convert.ToInt32(cboChuong.SelectedValue.ToString());
            objBL_CauHoi = new BL_CauHoi(dt);
            if (objBL_CauHoi.updateCauHoi() == 0)
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