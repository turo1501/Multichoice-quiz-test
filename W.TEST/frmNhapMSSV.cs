using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BusinessLogicTier;
using System.IO;

namespace W.TEST
{
    public partial class frmNhapMSSV : Form
    {
        private BL_SinhVien objBL_SinhVien;

        public frmNhapMSSV()
        {
            InitializeComponent();
            lblChuY.BackColor = Color.Transparent;
        }

        private void frmNhapMSSV_Load(object sender, EventArgs e)
        {
            DataTable dt = new BL_SinhVien().getAllSinhVien();
            //foreach(DataRow r in dt.Rows)
            //    imgLst.Images.Add(r["MSSV"].ToString(), Image.FromFile("imageSV/" + r["MSSV"] + ".PNG"));
        }

        private bool kiemTra()
        {
            if (!radTinChi.Checked && !radNienChe.Checked)
            {
                MessageBox.Show("Bạn hãy chọn Hệ!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtMSSV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn hãy nhập MSSV!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMSSV.SelectAll();
                txtMSSV.Focus();
                return false;
            }
            if (txtLop.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn hãy nhập Lớp!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLop.SelectAll();
                txtLop.Focus();
                return false;
            }
            return true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!kiemTra())
                return;
            objBL_SinhVien = new BL_SinhVien(txtMSSV.Text, txtLop.Text);
            if (!objBL_SinhVien.trueLogin())
            {
                MessageBox.Show("Bạn đã nhập sai thông tin sinh viên,\nVui lòng kiểm tra lại!", "Sai thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMSSV.SelectAll();
                txtMSSV.Focus();
                return;
            }
            pnNhapMSSV.Visible = false;
            pnChonChuong.Visible = true;
            hienThi_thongTin(txtMSSV.Text);
        }

        private void hienThi_thongTin(string mSSV)
        {
            picSV.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/imageSV/" + mSSV + ".PNG");
            DataRow r = objBL_SinhVien.getThongTin().Rows[0];
            lblTen.Text = r["HoDem"] + " " + r["Ten"];
            lblMSSV.Text = mSSV;
            lblLop.Text = r["TenLop"].ToString();
        }

        private void cboChonMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMon.Text = lblMon.Text.Replace("...", "Công Nghệ Phần Mềm");
        }

        private void btnLamBai_Click(object sender, EventArgs e)
        {
            if (cboChonMon.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chính xác môn thi mà Sinh Viên đang theo học!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmChonChuong f = new frmChonChuong();
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.Visible = false;
                if (new frmLamBai(f.chuong, lblTen.Text, txtMSSV.Text, lblLop.Text).ShowDialog() == DialogResult.Retry)
                    this.DialogResult = DialogResult.Retry;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radNienChe_CheckedChanged(object sender, EventArgs e)
        {
            txtMSSV.Focus();
        }
    }
}
