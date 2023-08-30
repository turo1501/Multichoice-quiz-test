using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Drawing.Imaging;
using BusinessLogicTier;
using DevComponents.DotNetBar;

namespace W.TEST
{
    public partial class frmThem_SinhVien : Office2007Form
    {
        private BL_SinhVien objBL_SinhVien;
        public string mSSS_daThem, maLop_daThem;

        public frmThem_SinhVien()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
            cboGioiTinh.SelectedIndex = 0;
        }

        private void frmThem_SinhVien_Load(object sender, EventArgs e)
        {
            loadDSLop_ComboBox();
        }

        private void loadDSLop_ComboBox()
        {
            cboLop.DataSource = new BL_Lop().getAllLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPG Files (*.JPG)|*.JPG|PNG Files (*.PNG)|*.PNG|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                picAnh.Image = Image.FromFile(openFileDialog.FileName);
        }

        private Control kiemTra_nhapLieu()
        {
            if (txtMSSV.Text.Trim().Equals("")) return txtMSSV;
            if (txtHoTen.Text.Trim().Equals("")) return txtHoTen;
            if (dateNgaySinh.Value == new DateTime()) return dateNgaySinh;
            if (txtDiaChi.Text.Trim().Equals("")) return txtDiaChi;
            if (picAnh.Image == null) return picAnh;
            return null;
        }

        private bool kiemTra_trungMa()
        {
            objBL_SinhVien = new BL_SinhVien(txtMSSV.Text);
            return objBL_SinhVien.getSinhVien_theo_Ma().Rows.Count > 0;
            //true: trùng
            //false: không trùng
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            Control ctrl = kiemTra_nhapLieu();
            if (ctrl != null)
            {
                if (ctrl == picAnh)
                {
                    MessageBoxEx.Show("<font color=\"#FF0000\">Bạn hãy chọn ảnh hiển thị!</font>", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnChonAnh.Focus();
                    return;
                }
                MessageBoxEx.Show("Bạn hãy nhập <font color=\"#FF0000\">" + ctrl.Tag + "</font> !", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ctrl != dateNgaySinh)
                    ((TextBox)ctrl).SelectAll();
                ctrl.Focus();
                return;
            }
            if (kiemTra_trungMa())
            {
                MessageBoxEx.Show("Đã có mã sinh viên <font color=\"#FF0000\">" + txtMSSV.Text + "</font> này! Vui lòng chọn mã khác!", "Trùng mã",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMSSV.SelectAll();
                txtMSSV.Focus();
                return;
            }
            DataTable dt = objBL_SinhVien.getSinhVien_cauTruc();
            DataRow r = dt.NewRow();
            r["MSSV"] = txtMSSV.Text;
            for (int i = txtHoTen.Text.Length - 1; i >= 0; i--)
                if (txtHoTen.Text[i].Equals(' '))
                {
                    r["HoDem"] = txtHoTen.Text.Substring(0, txtHoTen.Text.Length - txtHoTen.Text.Substring(i).Length);
                    r["Ten"] = txtHoTen.Text.Substring(i + 1);
                    break;
                }
            if (r["Ten"].ToString().Equals("")) r["Ten"] = txtHoTen.Text;
            r["Lop"] = cboLop.SelectedValue.ToString();
            r["NgaySinh"] = dateNgaySinh.Value;
            r["GioiTinh"] = cboGioiTinh.SelectedIndex == 0;
            r["DiaChi"] = txtDiaChi.Text;
            dt.Rows.Add(r);
            if (new BL_SinhVien(dt).updateSinhVien() == 0)
                MessageBoxEx.Show("<font color=\"#FF0000\">Thêm sinh viên mới thất bại!</font>", "Thêm lớp",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Thêm sinh viên mới thành công!</font>", "Thêm lớp",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                picAnh.Image.Save(Directory.GetCurrentDirectory() + "/imageSV/" + txtMSSV.Text + ".PNG", ImageFormat.Png);
                mSSS_daThem = txtMSSV.Text;
                maLop_daThem = cboLop.SelectedValue.ToString();
                BL_Lop objBL_Lop = new BL_Lop(maLop_daThem);
                DataTable dtLop = objBL_Lop.getLop_theo_Ma();
                dtLop.Rows[0]["SiSo"] = Convert.ToInt32(dtLop.Rows[0]["SiSo"]) + 1;
                objBL_Lop = new BL_Lop(dtLop);
                objBL_Lop.updateLop();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}