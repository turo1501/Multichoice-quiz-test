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
    public partial class frmXemSua_SinhVien : Office2007Form
    {
        private string mSSV;
        private BL_SinhVien objBL_SinhVien;
        private bool daThayAnh = false;

        public frmXemSua_SinhVien(string mSSV)
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
            this.mSSV = mSSV;
        }

        private void frmXemSua_SinhVien_Load(object sender, EventArgs e)
        {
            txtMSSV.Text = mSSV;
            objBL_SinhVien = new BL_SinhVien(mSSV);
            DataRow r = objBL_SinhVien.getSinhVien_theo_Ma().Rows[0];
            txtHoTen.Text = r["HoDem"] + " " + r["Ten"];
            dateNgaySinh.Value = Convert.ToDateTime(r["NgaySinh"]);
            cboGioiTinh.SelectedIndex = Convert.ToBoolean(r["GioiTinh"]) ? 0 : 1;
            txtDiaChi.Text = r["DiaChi"].ToString();
            txtDiem.Text = r["DiemCaoNhat"].ToString();
            cboLop.DataSource = new BL_Lop().getAllLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.SelectedValue = r["Lop"].ToString();
            if (File.Exists(Directory.GetCurrentDirectory() + "/imageSV/" + mSSV + ".PNG"))
                imgLst.Images.Add(mSSV, Image.FromFile("imageSV/" + mSSV + ".PNG"));
            else imgLst.Images.Add(mSSV, Image.FromFile("imageSV/null.png"));
            picAnh.Image = imgLst.Images[mSSV];
        }
        //Download source code tại Sharecode.vn
        private void btnSua_Click(object sender, EventArgs e)
        {
            bool bl = btnSua.Text.Equals("Sửa");
            this.btnSua.Image = bl ? global::W.TEST.Properties.Resources.Cancel_32 :
                global::W.TEST.Properties.Resources.Gnome_Logviewer_32;
            btnLuu.Enabled = bl;
            btnSua.Text = bl ? "Hủy" : "Sửa";
            txtMSSV.ReadOnly = !bl;
            txtHoTen.ReadOnly = !bl;
            dateNgaySinh.Enabled = bl;
            dateNgaySinh.IsInputReadOnly = !bl;
            cboGioiTinh.Enabled = bl;
            txtDiaChi.ReadOnly = !bl;
            btnChonAnh.Enabled = bl;
            cboLop.Enabled = bl;
            if (bl) txtMSSV.Focus();
        }

        private Control kiemTra_nhapLieu()
        {
            if (txtMSSV.Text.Trim().Equals("")) return txtMSSV;
            if (txtHoTen.Text.Trim().Equals("")) return txtHoTen;
            if (dateNgaySinh.Value == new DateTime()) return dateNgaySinh;
            if (txtDiaChi.Text.Trim().Equals("")) return txtDiaChi;
            return null;
        }

        private bool kiemTra_trungMa()
        {
            objBL_SinhVien = new BL_SinhVien(txtMSSV.Text);
            return objBL_SinhVien.getSinhVien_theo_Ma().Rows.Count > 0;
            //true: trùng
            //false: không trùng
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Control ctrl = kiemTra_nhapLieu();
            if (ctrl != null)
            {
                MessageBoxEx.Show("Bạn hãy nhập <font color=\"#FF0000\">" + ctrl.Tag + "</font> !", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ctrl != dateNgaySinh)
                    ((TextBox)ctrl).SelectAll();
                ctrl.Focus();
                return;
            }
            if (kiemTra_trungMa() && mSSV != txtMSSV.Text)
            {
                MessageBoxEx.Show("Đã có mã sinh viên <font color=\"#FF0000\">" + txtMSSV.Text +
                    "</font> này! Vui lòng chọn mã khác!", "Trùng mã",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMSSV.SelectAll();
                txtMSSV.Focus();
                return;
            }
            objBL_SinhVien = new BL_SinhVien(mSSV);
            DataTable dt = objBL_SinhVien.getSinhVien_theo_Ma();
            dt.Rows[0]["MSSV"] = txtMSSV.Text;
            dt.Rows[0]["Ten"] = "";
            for (int i = txtHoTen.Text.Length - 1; i >= 0; i--)
                if (txtHoTen.Text[i].Equals(' '))
                {
                    dt.Rows[0]["HoDem"] = txtHoTen.Text.Substring(0, txtHoTen.Text.Length - txtHoTen.Text.Substring(i).Length);
                    dt.Rows[0]["Ten"] = txtHoTen.Text.Substring(i + 1);
                    break;
                }
            if (dt.Rows[0]["Ten"].ToString().Equals("")) dt.Rows[0]["Ten"] = txtHoTen.Text;
            dt.Rows[0]["NgaySinh"] = dateNgaySinh.Value;
            dt.Rows[0]["GioiTinh"] = cboGioiTinh.SelectedIndex == 0;
            dt.Rows[0]["DiaChi"] = txtDiaChi.Text;
            dt.Rows[0]["Lop"] = cboLop.SelectedValue.ToString();
            objBL_SinhVien = new BL_SinhVien(dt);
            if (objBL_SinhVien.updateSinhVien() == 0)
                MessageBoxEx.Show("<font color=\"#FF0000\">Cập nhật thất bại!</font>", "Cập nhật sinh viên",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Cập nhật thành công!</font>", "Cập nhật sinh viên",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (daThayAnh)
                {
                    File.Delete(Directory.GetCurrentDirectory() + "/imageSV/" + mSSV + ".PNG");
                    picAnh.Image.Save(Directory.GetCurrentDirectory() + "/imageSV/" + txtMSSV.Text + ".PNG", ImageFormat.Png);
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPG Files (*.JPG)|*.JPG|PNG Files (*.PNG)|*.PNG|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(openFileDialog.FileName);
                daThayAnh = true;
            }
        }
    }
}