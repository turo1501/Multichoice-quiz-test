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
    public partial class frmTimKiem_CauHoi : Office2007Form
    {
        public DataTable dtResult;

        public frmTimKiem_CauHoi()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
        }

        private void frmTimKiem_CauHoi_Load(object sender, EventArgs e)
        {
            load_DSChuong_ComboBox();
            txtCauHoi.Text = frmThaoTacCSDL.timKiem_CauHoi.KeyCauHoi;
            txtDapAn.Text = frmThaoTacCSDL.timKiem_CauHoi.KeyDapAn;
            cboDapAn.Text = frmThaoTacCSDL.timKiem_CauHoi.DapAn;
            cboChuong.SelectedValue = frmThaoTacCSDL.timKiem_CauHoi.MaChuong;
            txtCauHoi.Focus();
            txtCauHoi.SelectAll();
        }

        private void load_DSChuong_ComboBox()
        {
            DataTable dtSource = new DataTable();
            dtSource.Columns.Add("MaChuong");
            dtSource.Columns.Add("TenChuong");
            DataRow dr = dtSource.NewRow();
            dr["MaChuong"] = 0;
            dr["TenChuong"] = "Ngẫu nhiên";
            dtSource.Rows.Add(dr);
            DataTable dt = new BL_Chuong().getAllChuong();
            foreach (DataRow row in dt.Rows)
            {
                DataRow r = dtSource.NewRow();
                r["MaChuong"] = row["MaChuong"];
                r["TenChuong"] = row["TenChuong"];
                dtSource.Rows.Add(r);
            }
            cboChuong.DataSource = dtSource;
            cboChuong.ValueMember = "MaChuong";
            cboChuong.DisplayMember = "TenChuong";
        }

        private bool kiemTra()
        {
            if (txtCauHoi.Text.Trim().Equals("") && txtDapAn.Text.Trim().Equals("") &&
                cboDapAn.SelectedIndex == 0 && cboChuong.SelectedIndex == 0)
            {
                MessageBoxEx.Show("<font color=\"#FF0000\">Bạn phải nhập ít nhất một ô từ khóa!</font>", "Tìm kiếm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCauHoi.SelectAll();
                txtCauHoi.Focus();
                return false;
            }
            return true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;
            dtResult = new BL_CauHoi(new TimKiemCauHoi(txtCauHoi.Text, txtDapAn.Text, cboDapAn.SelectedIndex == 0 ? "" : cboDapAn.SelectedItem.ToString(), cboChuong.SelectedIndex == 0 ? 0 : Convert.ToInt32(cboChuong.SelectedValue.ToString()))).timKiem();
            frmThaoTacCSDL.timKiem_CauHoi.KeyCauHoi = txtCauHoi.Text;
            frmThaoTacCSDL.timKiem_CauHoi.KeyDapAn = txtDapAn.Text;
            frmThaoTacCSDL.timKiem_CauHoi.DapAn = cboDapAn.SelectedItem.ToString();
            frmThaoTacCSDL.timKiem_CauHoi.MaChuong = Convert.ToInt32(cboChuong.SelectedValue.ToString());
            this.DialogResult = DialogResult.OK;
        }
    }
}