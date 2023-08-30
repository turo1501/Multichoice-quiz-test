using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BusinessLogicTier;
using DataTransferObject;
using DevComponents.DotNetBar;

namespace W.TEST
{
    public partial class frmTimKiem_SinhVien : Office2007Form
    {
        public DataTable dtResult;

        public frmTimKiem_SinhVien()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
        }

        private void frmTimKiem_SinhVien_Load(object sender, EventArgs e)
        {
            load_DSLop_ComboBox();
            txtMSSV.Text = frmThaoTacCSDL.timKiem_SinhVien.MSSV;
            txtHoDem.Text = frmThaoTacCSDL.timKiem_SinhVien.HoDem;
            txtTen.Text = frmThaoTacCSDL.timKiem_SinhVien.Ten;
            txtDiaChi.Text = frmThaoTacCSDL.timKiem_SinhVien.DiaChi;
            dateNgaySinh.Value = frmThaoTacCSDL.timKiem_SinhVien.NgaySinh;
            cboGioiTinh.SelectedIndex = frmThaoTacCSDL.timKiem_SinhVien.GioiTinh;
            cboLop.SelectedValue = frmThaoTacCSDL.timKiem_SinhVien.MaLop;
            txtMSSV.Focus();
            txtMSSV.SelectAll();
        }

        private void load_DSLop_ComboBox()
        {
            DataTable dtSource = new DataTable();
            dtSource.Columns.Add("MaLop");
            dtSource.Columns.Add("TenLop");
            DataRow dr = dtSource.NewRow();
            dr["MaLop"] = "";
            dr["TenLop"] = "Ngẫu nhiên";
            dtSource.Rows.Add(dr);
            DataTable dt = new BL_Lop().getAllLop();
            foreach (DataRow row in dt.Rows)
            {
                DataRow r = dtSource.NewRow();
                r["MaLop"] = row["MaLop"];
                r["TenLop"] = row["TenLop"];
                dtSource.Rows.Add(r);
            }
            cboLop.DataSource = dtSource;
            cboLop.ValueMember = "MaLop";
            cboLop.DisplayMember = "TenLop";
        }

        private bool kiemTra()
        {
            if (txtMSSV.Text.Trim().Equals("") && txtHoDem.Text.Trim().Equals("") &&
                txtTen.Text.Trim().Equals("") && cboLop.SelectedIndex == 0 &&
                dateNgaySinh.Value == new DateTime() && cboGioiTinh.SelectedIndex == 0 && txtDiaChi.Text.Trim().Equals(""))
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Bạn phải nhập ít nhất một ô từ khóa!</font>", "Tìm kiếm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMSSV.SelectAll();
                txtMSSV.Focus();
                return false;
            }
            return true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;
            dtResult = new BL_SinhVien(new TimKiemSinhVien(txtMSSV.Text, txtHoDem.Text, txtTen.Text, cboLop.SelectedValue.ToString(), dateNgaySinh.Value, Convert.ToByte(cboGioiTinh.SelectedIndex), txtDiaChi.Text)).timKiem();
            frmThaoTacCSDL.timKiem_SinhVien.MSSV = txtMSSV.Text;
            frmThaoTacCSDL.timKiem_SinhVien.HoDem = txtHoDem.Text;
            frmThaoTacCSDL.timKiem_SinhVien.Ten = txtTen.Text;
            frmThaoTacCSDL.timKiem_SinhVien.MaLop = cboLop.SelectedValue.ToString();
            frmThaoTacCSDL.timKiem_SinhVien.NgaySinh = dateNgaySinh.Value;
            frmThaoTacCSDL.timKiem_SinhVien.GioiTinh = Convert.ToByte(cboGioiTinh.SelectedIndex);
            frmThaoTacCSDL.timKiem_SinhVien.DiaChi = txtDiaChi.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}