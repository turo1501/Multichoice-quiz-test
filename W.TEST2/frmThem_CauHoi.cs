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
    public partial class frmThem_CauHoi : Office2007Form
    {
        private BL_CauHoi objBL_CauHoi;
        public int chuong_daThem;
        public string maCauHoi_daThem;

        public frmThem_CauHoi()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
            cboDapAn.SelectedIndex = 0;
        }

        private void frmThem_CauHoi_Load(object sender, EventArgs e)
        {
            loadChuongs_ComboBox();
        }

        private void loadChuongs_ComboBox()
        {
            cboChuong.DataSource = new BL_Chuong().getAllChuong();
            cboChuong.ValueMember = "MaChuong";
            cboChuong.DisplayMember = "TenChuong";
        }

        private bool kiemTra_trungMa()
        {
            objBL_CauHoi = new BL_CauHoi(txtMa.Text);
            return objBL_CauHoi.getCauHoi_theoMa().Rows.Count > 0;
            //true: trùng
            //false: không trùng
        }

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

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            TextBox txt = kiemTra_nhapLieu();
            if (txt != null)
            {
                MessageBoxEx.Show("Bạn hãy nhập <font color=\"#FF0000\">" + txt.Tag.ToString() + "</font> !", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt.SelectAll();
                txt.Focus();
                return;
            }
            if (kiemTra_trungMa())
            {
                MessageBoxEx.Show("Đã có mã <font color=\"#FF0000\">" + txtMa.Text + "</font> này! Vui lòng chọn mã khác!", "Trùng mã",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.SelectAll();
                txtMa.Focus();
                return;
            }
            objBL_CauHoi = new BL_CauHoi();
            DataTable dt = objBL_CauHoi.getCauHoi_cauTruc();
            DataRow r = dt.NewRow();
            r["MaCauHoi"] = txtMa.Text;
            r["CauHoi"] = txtCauHoi.Text;
            r["A"] = txtA.Text;
            r["B"] = txtB.Text;
            r["C"] = txtC.Text;
            r["D"] = txtD.Text;
            r["DapAn"] = cboDapAn.SelectedItem.ToString();
            r["Chuong"] = Convert.ToInt32(cboChuong.SelectedValue.ToString());
            dt.Rows.Add(r);
            objBL_CauHoi = new BL_CauHoi(dt);
            if (objBL_CauHoi.updateCauHoi() == 0)
                MessageBoxEx.Show("<font color=\"#FF0000\">Thêm câu hỏi mới thất bại!</font>", "Thêm câu hỏi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Thêm câu hỏi mới thành công!</font>", "Thêm câu hỏi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                chuong_daThem = Convert.ToInt32(cboChuong.SelectedValue.ToString());
                maCauHoi_daThem = txtMa.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}