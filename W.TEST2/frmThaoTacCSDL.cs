using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BusinessLogicTier;
using DataTransferObject;
using DevComponents.DotNetBar;
using System.IO;
using System.Data.OleDb;

namespace W.TEST
{
    public partial class frmThaoTacCSDL : Office2007Form
    {
        private BL_Chuong objBL_Chuong;
        private BL_CauHoi objBL_CauHoi;
        private BL_Lop objBL_Lop;
        private BL_SinhVien objBL_SinhVien;
        public static TimKiemCauHoi timKiem_CauHoi = new TimKiemCauHoi();
        public static TimKiemSinhVien timKiem_SinhVien = new TimKiemSinhVien();
        private bool loadListBox_Chuong, loadListBox_Lop;
        private BindingSource bs = new BindingSource();
        private DataView dvSinhViens;
        private dsReport ds = new dsReport();

        public frmThaoTacCSDL()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
            lblIndex_CauHoi.BackColor = Color.Transparent;
            lblIndex_SinhVien.BackColor = Color.Transparent;
            bs.PositionChanged += new EventHandler(bs_PositionChanged);
        }

        private void bs_PositionChanged(object sender, EventArgs e)
        {
            lblIndex_CauHoi.Text = bs.Position + 1 + " / " + dgVwCauHoi.Rows.Count;
        }

        private void mnuTacGia_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.tmr.Enabled = false;
            f.ShowDialog();
        }

        private void tab_SelectedTabChanged(object sender, TabStripTabChangedEventArgs e)
        {
            switch (tab.SelectedTabIndex)
            {
                case 0:
                    picCauHoi.Image = global::W.TEST.Properties.Resources.Folder_Multiple_icon;
                    lblTitle.Text = "Quản Lý Câu Hỏi";
                    break;
                case 1:
                    picCauHoi.Image = global::W.TEST.Properties.Resources.Folder_user_icon;
                    lblTitle.Text = "Quản Lý Sinh Viên";
                    break;
                default:
                    picCauHoi.Image = global::W.TEST.Properties.Resources.Administrative_Tools_128;
                    lblTitle.Text = "Quản Lý Mật khẩu";
                    if (new frmQuanLyMatKhau().ShowDialog() == DialogResult.Cancel)
                        tab.SelectedTabIndex = 0;
                    break;
            }
        }
        //Download source code tại Sharecode.vn
        private void frmThaoTacCSDL_Load(object sender, EventArgs e)
        {
            load_DSChuong_ListBox();
            load_DSLop_ListBox();
            timKiem_CauHoi.KeyCauHoi = "";
            timKiem_CauHoi.DapAn = "Ngẫu nhiên";
            timKiem_SinhVien.MSSV = "";
            timKiem_SinhVien.GioiTinh = 0;
            timKiem_SinhVien.MaLop = "";
        }

        private void load_DSChuong_ListBox()
        {
            loadListBox_Chuong = false;
            objBL_Chuong = new BL_Chuong();
            DataTable dtChuongs = objBL_Chuong.getAllChuong();
            lstChuong.DataSource = dtChuongs;
            lstChuong.DisplayMember = "TenChuong";
            lstChuong.ValueMember = "MaChuong";
            conMnuChuong.Enabled = dtChuongs.Rows.Count > 0;
            loadListBox_Chuong = true;
            lstChuong_Click(null, null);
        }

        private void load_DSLop_ListBox()
        {
            loadListBox_Lop = false;
            objBL_Lop = new BL_Lop();
            DataTable dtLops = objBL_Lop.getAllLop();
            lstLop.DataSource = dtLops;
            lstLop.ValueMember = "MaLop";
            lstLop.DisplayMember = "TenLop";
            conMnuLop.Enabled = dtLops.Rows.Count > 0;
            loadListBox_Lop = true;
            lstLop_Click(null, null);
        }

        private void lstChuong_Click(object sender, EventArgs e)
        {
            if (lstChuong.SelectedIndices.Count == 0)
            {
                dgVwCauHoi.DataSource = new DataTable();
                grbCauHoi.Text = "Danh sách câu hỏi";
                mnuItemXemSuaCauHoi.Enabled = false;
                mnuItemXoaCauHoi.Enabled = false;
                return;
            }
            if (!loadListBox_Chuong) return;
            objBL_CauHoi = new BL_CauHoi(Convert.ToInt32(lstChuong.SelectedValue.ToString()));
            load_CauHoi_DataGirdView(objBL_CauHoi.getCauHois_theoChuong());
            grbCauHoi.Text = "Danh sách câu hỏi chương <font color=\"#FF0000\">" + lstChuong.Text + "</font>";
        }

        private void load_CauHoi_DataGirdView(DataTable dt)
        {
            DataTable dtSource = new DataTable();
            dtSource.Columns.Add("Mã");
            dtSource.Columns.Add("Câu hỏi");
            dtSource.Columns.Add("Đáp án");
            foreach (DataRow dr in dt.Rows)
            {
                DataRow r = dtSource.NewRow();
                r["Mã"] = dr["MaCauHoi"];
                r["Câu hỏi"] = dr["CauHoi"];
                r["Đáp Án"] = dr[dr["DapAn"].ToString()];
                dtSource.Rows.Add(r);
            }
            bs.DataSource = dtSource;
            dgVwCauHoi.DataSource = bs;
            foreach (DataGridViewRow r in dgVwCauHoi.Rows)
                if (r.Index % 2 == 1) r.DefaultCellStyle.BackColor = Color.LightGray;
            dgVwCauHoi.Columns[0].Width = 43;
            dgVwCauHoi.Columns[1].Width = 315;
            dgVwCauHoi.Columns[2].Width = 315;
            bs.MoveFirst();
            lblIndex_CauHoi.Text = "1 / " + dgVwCauHoi.Rows.Count;
            mnuItemXemSuaCauHoi.Enabled = dtSource.Rows.Count > 0;
            mnuItemXoaCauHoi.Enabled = dtSource.Rows.Count > 0;
        }

        private void dgVwDSCauHoi_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgVwCauHoi.Rows)
                if (r.Index % 2 == 1) r.DefaultCellStyle.BackColor = Color.LightGray;
        }

        private void mnuItemXemSuaChuong_Click(object sender, EventArgs e)
        {
            if (new frmXemSua_Chuong(Convert.ToInt32(lstChuong.SelectedValue.ToString())).ShowDialog() == DialogResult.OK)
                load_DSChuong_ListBox();
        }

        private void mnuItemXoaChuong_Click(object sender, EventArgs e)
        {
            string tenChuong = lstChuong.Text;
            if (MessageBoxEx.Show("Bạn có chắc chắn muốn xóa chương <font color=\"#FF0000\">" + tenChuong +
                "</font> khỏi danh sách?<br />Chọn No để hủy bỏ.<br /><br /><font color=\"#FF0000\">" +
                "Chú ý: Nhiều câu hỏi của chương này sẽ mất theo nếu bạn tiếp tục thao tác.</font>", "Xóa chương",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            objBL_Chuong = new BL_Chuong(Convert.ToInt32(lstChuong.SelectedValue.ToString()));
            DataTable dt = objBL_Chuong.getChuong_theo_maChuong();
            dt.Rows[0].Delete();
            objBL_Chuong = new BL_Chuong(dt);
            if (objBL_Chuong.updateChuong() == 0)
                MessageBoxEx.Show("Xóa chương <font color=\"#FF0000\">" + tenChuong + "</font> thất bại!", "Xóa chương",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBoxEx.Show("Đã xóa chương <font color=\"#FF0000\">" + tenChuong + "</font> khỏi danh sách!", "Xóa chương",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_DSChuong_ListBox();
            }
        }

        private void btnThemChuong_Click(object sender, EventArgs e)
        {
            if (new frmThem_Chuong().ShowDialog() == DialogResult.OK)
                load_DSChuong_ListBox();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem_CauHoi f = new frmTimKiem_CauHoi();
            if (f.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = f.dtResult;
                load_CauHoi_DataGirdView(dt);
                if (dt.Rows.Count == 0) MessageBoxEx.Show("<font color=\"#FF0000\">Không tìm thấy câu hỏi nào phù hợp điều kiện!</font>", "Tìm kiếm câu hỏi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            frmThem_CauHoi f = new frmThem_CauHoi();
            if (f.ShowDialog() == DialogResult.OK)
            {
                lstChuong.SelectedValue = f.chuong_daThem;
                objBL_CauHoi = new BL_CauHoi(f.chuong_daThem);
                load_CauHoi_DataGirdView(objBL_CauHoi.getCauHois_theoChuong());
                foreach (DataGridViewRow r in dgVwCauHoi.Rows)
                    if (r.Cells[0].Value.ToString().Equals(f.maCauHoi_daThem))
                    {
                        dgVwCauHoi.Focus();
                        r.Selected = true;
                        break;
                    }
            }
        }

        private void mnuItemXemSuaCauHoi_Click(object sender, EventArgs e)
        {
            if (new frmXemSua_CauHoi(dgVwCauHoi.CurrentRow.Cells[0].Value.ToString()).ShowDialog() == DialogResult.OK)
                load_CauHoi_DataGirdView(new BL_CauHoi(Convert.ToInt32(lstChuong.SelectedValue.ToString())).getCauHois_theoChuong());
        }

        private void mnuItemXoaCauHoi_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có chắc chắn muốn xóa câu hỏi mã <font color=\"#FF0000\">" + dgVwCauHoi.CurrentRow.Cells[0].Value.ToString() + "</font> khỏi danh sách?<br />Chọn No để hủy bỏ.", "Xóa câu hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            objBL_CauHoi = new BL_CauHoi(dgVwCauHoi.CurrentRow.Cells[0].Value.ToString());
            DataTable dt = objBL_CauHoi.getCauHoi_theoMa();
            dt.Rows[0].Delete();
            objBL_CauHoi = new BL_CauHoi(dt);
            if (objBL_CauHoi.updateCauHoi() == 0)
                MessageBoxEx.Show("Xóa câu hỏi mã <font color=\"#FF0000\">" + dgVwCauHoi.CurrentRow.Cells[0].Value.ToString() + "</font> thất bại!", "Xóa câu hỏi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBoxEx.Show("Đã xóa câu hỏi mã <font color=\"#FF0000\">" + dgVwCauHoi.CurrentRow.Cells[0].Value.ToString() + "</font> khỏi danh sách!", "Xóa câu hỏi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                objBL_CauHoi = new BL_CauHoi(Convert.ToInt32(lstChuong.SelectedValue.ToString()));
                load_CauHoi_DataGirdView(objBL_CauHoi.getCauHois_theoChuong());
            }
        }

        private void btnPosition_CauHoi_Click(object sender, EventArgs e)
        {
            switch (((ButtonX)sender).Name)
            {
                case "btnFirst_CauHoi": bs.MoveFirst(); break;
                case "btnPrevious_CauHoi": bs.MovePrevious(); break;
                case "btnNext_CauHoi": bs.MoveNext(); break;
                case "btnLast_CauHoi": bs.MoveLast(); break;
            }
        }

        private void btnPosition_SinhVien_Click(object sender, EventArgs e)
        {
            lstVwSinhVien.Focus();
            ListViewItem li;
            if (lstVwSinhVien.SelectedItems.Count == 0)
            {
                li = lstVwSinhVien.Items[0];
                li.Selected = true;
                li.Focused = true;
                return;
            }
            switch (((ButtonX)sender).Name)
            {
                case "btnFirst_SinhVien":
                    li = lstVwSinhVien.Items[0];
                    li.Selected = true;
                    li.Focused = true;
                    break;
                case "btnPrevious_SinhVien":
                    if (lstVwSinhVien.SelectedIndices[0] == 0) break;
                    li = lstVwSinhVien.Items[lstVwSinhVien.SelectedIndices[0] - 1];
                    li.Selected = true;
                    li.Focused = true;
                    break;
                case "btnNext_SinhVien":
                    if (lstVwSinhVien.SelectedIndices[0] == lstVwSinhVien.Items.Count - 1) break;
                    li = lstVwSinhVien.Items[lstVwSinhVien.SelectedIndices[0] + 1];
                    li.Selected = true;
                    li.Focused = true;
                    break;
                case "btnLast_SinhVien":
                    li = lstVwSinhVien.Items[lstVwSinhVien.Items.Count - 1];
                    li.Selected = true;
                    li.Focused = true;
                    break;
            }
        }

        private void lstLop_Click(object sender, EventArgs e)
        {
            if (lstLop.SelectedIndices.Count == 0)
            {
                lstVwSinhVien.Items.Clear();
                grbSinhVien.Text = "Danh sách sinh viên";
                mnuItemXemSuaSinhVien.Enabled = false;
                mnuItemXoaSinhVien.Enabled = false;
                return;
            }
            if (!loadListBox_Lop) return;
            objBL_SinhVien = new BL_SinhVien(null, lstLop.SelectedValue.ToString());
            load_SinhVien_ListView(new DataView(objBL_SinhVien.getSinhVien_theo_Lop()));
            grbSinhVien.Text = "Danh sách sinh viên lớp <font color=\"#FF0000\">" + lstLop.Text + "</font>";
        }

        private void load_SinhVien_ListView(DataView dv)
        {
            dvSinhViens = dv;
            lstVwSinhVien.Items.Clear();
            for (int i = 0; i < dv.Count; i++)
            {
                ListViewItem li = lstVwSinhVien.Items.Add(dv[i]["MSSV"].ToString());
                li.SubItems.Add(dv[i]["HoDem"] + " " + dv[i]["Ten"]);
                li.SubItems.Add(Convert.ToDateTime(dv[i]["NgaySinh"]).ToString("dd/MM/yyyy"));
                li.SubItems.Add(dv[i]["DiaChi"].ToString());
                li.SubItems.Add(dv[i]["DiemCaoNhat"].ToString());
                li.ImageIndex = Convert.ToBoolean(dv[i]["GioiTinh"]) ? 0 : 1;
                li.BackColor = i % 2 == 0 ? Color.White : Color.LightGray;
                for (int j = 0; j < li.SubItems.Count; j++)
                    li.SubItems[j].BackColor = i % 2 == 0 ? Color.White : mnuItemKieuXem_Details.Checked ? Color.LightGray : Color.White;
            }
            mnuItemXemSuaSinhVien.Enabled = lstVwSinhVien.Items.Count > 0;
            mnuItemXoaSinhVien.Enabled = lstVwSinhVien.Items.Count > 0;
            mnuItemInSinhVien.Enabled = lstVwSinhVien.SelectedItems.Count > 0;
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            if (new frmThem_Lop().ShowDialog() == DialogResult.OK)
                load_DSLop_ListBox();
        }

        private void mnuItemXemSuaLop_Click(object sender, EventArgs e)
        {
            if (new frmXemSua_Lop(lstLop.SelectedValue.ToString()).ShowDialog() == DialogResult.OK)
                load_DSLop_ListBox();
        }

        private void mnuItemXoaLop_Click(object sender, EventArgs e)
        {
            string tenLop = lstLop.Text;
            if (MessageBoxEx.Show("Bạn có chắc chắn muốn xóa lớp <font color=\"#FF0000\">" + tenLop
                + "</font> khỏi danh sách?<br />Chọn No để hủy bỏ.<br /><br /><font color=\"#FF0000\">" +
                "Chú ý: Nhiều sinh viên của lớp này sẽ mất theo nếu bạn tiếp tục thao tác.</font>", "Xóa lớp",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            objBL_Lop = new BL_Lop(lstLop.SelectedValue.ToString());
            DataTable dt = objBL_Lop.getLop_theo_Ma();
            dt.Rows[0].Delete();
            objBL_Lop = new BL_Lop(dt);
            if (objBL_Lop.updateLop() == 0)
                MessageBoxEx.Show("Xóa lớp <font color=\"#FF0000\">" + tenLop + "</font> thất bại!", "Xóa lớp",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBoxEx.Show("Đã xóa lớp <font color=\"#FF0000\">" + tenLop + "</font> khỏi danh sách!", "Xóa lớp",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_DSLop_ListBox();
            }
        }

        private void mnuItemKieuXem_Click(object sender, EventArgs e)
        {
            if (sender == mnuItemKieuXem_LargeIcon) lstVwSinhVien.View = View.LargeIcon;
            else if (sender == mnuItemKieuXem_Details) lstVwSinhVien.View = View.Details;
            else if (sender == mnuItemKieuXem_SmallIcon) lstVwSinhVien.View = View.SmallIcon;
            else if (sender == mnuItemKieuXem_List) lstVwSinhVien.View = View.List;
            else lstVwSinhVien.View = View.Tile;
            foreach (ToolStripMenuItem i in mnuItemKieuXem.DropDownItems)
                i.Checked = (ToolStripMenuItem)sender == i;
            for (int i = 0; i < lstVwSinhVien.Items.Count; i++)
            {
                lstVwSinhVien.Items[i].BackColor = i % 2 == 0 ? Color.White :
                    (ToolStripMenuItem)sender == mnuItemKieuXem_Details ?Color.LightGray : Color.White;
                for (int j = 0; j < lstVwSinhVien.Items[i].SubItems.Count; j++)
                    lstVwSinhVien.Items[i].SubItems[j].BackColor = i % 2 == 0 ? Color.White :
                        (ToolStripMenuItem)sender == mnuItemKieuXem_Details ? Color.LightGray : Color.White;
            }
        }

        private void lstVwSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIndex_SinhVien.Text = lstVwSinhVien.SelectedItems.Count > 0 ? lstVwSinhVien.SelectedIndices[0] + 1 + " / " + lstVwSinhVien.Items.Count : "";
            mnuItemXemSuaSinhVien.Enabled = lstVwSinhVien.SelectedItems.Count > 0;
            mnuItemXoaSinhVien.Enabled = lstVwSinhVien.SelectedItems.Count > 0;
            mnuItemInSinhVien.Enabled = lstVwSinhVien.SelectedItems.Count > 0;
        }

        private void btnTimKiem_SinhVien_Click(object sender, EventArgs e)
        {
            frmTimKiem_SinhVien f = new frmTimKiem_SinhVien();
            if (f.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = f.dtResult;
                load_SinhVien_ListView(new DataView(dt));
                if (dt.Rows.Count == 0) MessageBoxEx.Show("<font color=\"#FF0000\">Không tìm thấy sinh viên nào phù hợp điều kiện!</font>", "Tìm kiếm câu hỏi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstVwSinhVien_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            string strSort = "";
            switch (e.Column)
            {
                case 0: strSort = "MSSV"; break;
                case 1: strSort = "Ten"; break;
                case 2: strSort = "NgaySinh"; break;
                case 3: strSort = "GioiTinh"; break;
                case 4: strSort = "DiaChi"; break;
                case 5: strSort = "DiemCaoNhat"; break;
            }
            strSort += " " + lstVwSinhVien.Columns[e.Column].Tag.ToString();
            dvSinhViens.Sort = strSort;
            lstVwSinhVien.Columns[e.Column].Tag = lstVwSinhVien.Columns[e.Column].Tag.ToString().Equals("asc") ? "desc" : "asc";
            load_SinhVien_ListView(dvSinhViens);
        }

        private void conMnuSinhVien_Opening(object sender, CancelEventArgs e)
        {
            mnuItemXemSuaSinhVien.Enabled = lstVwSinhVien.SelectedItems.Count > 0;
            mnuItemXoaSinhVien.Enabled = lstVwSinhVien.SelectedItems.Count > 0;
        }

        private void btnThem_SinhVien_Click(object sender, EventArgs e)
        {
            frmThem_SinhVien f = new frmThem_SinhVien();
            if (f.ShowDialog() == DialogResult.OK)
            {
                lstLop.SelectedValue = f.maLop_daThem;
                objBL_SinhVien = new BL_SinhVien(null, f.maLop_daThem);
                load_SinhVien_ListView(new DataView(objBL_SinhVien.getSinhVien_theo_Lop()));
                foreach (ListViewItem li in lstVwSinhVien.Items)
                    if (li.Text.Equals(f.mSSS_daThem))
                    {
                        lstVwSinhVien.Focus();
                        li.Selected = true;
                        li.Focused = true;
                        break;
                    }
            }
        }

        private void mnuItemXemSuaSinhVien_Click(object sender, EventArgs e)
        {
            if (new frmXemSua_SinhVien(lstVwSinhVien.SelectedItems[0].Text).ShowDialog() == DialogResult.OK)
                load_SinhVien_ListView(new DataView(new BL_SinhVien(null, lstLop.SelectedValue.ToString()).getSinhVien_theo_Lop()));
        }

        private void mnuItemXoaSinhVien_Click(object sender, EventArgs e)
        {
            string mSSV = lstVwSinhVien.SelectedItems[0].Text;
            string tenSV = lstVwSinhVien.SelectedItems[0].SubItems[1].Text;
            if (MessageBoxEx.Show("Bạn có chắc chắn muốn xóa sinh viên <font color=\"#FF0000\">" + tenSV + "</font> khỏi danh sách?<br />Chọn No để hủy bỏ.", "Xóa sinh viên",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            objBL_SinhVien = new BL_SinhVien(mSSV);
            DataTable dt = objBL_SinhVien.getSinhVien_theo_Ma();
            dt.Rows[0].Delete();
            objBL_SinhVien = new BL_SinhVien(dt);
            if (objBL_SinhVien.updateSinhVien() == 0)
                MessageBoxEx.Show("Xóa sinh viên <font color=\"#FF0000\">" + tenSV + "</font> thất bại!", "Xóa sinh viên",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBoxEx.Show("Đã xóa sinh viên <font color=\"#FF0000\">" + tenSV + "</font> khỏi danh sách!", "Xóa sinh viên",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.Delete(Directory.GetCurrentDirectory() + "/imageSV/" + mSSV + ".PNG");
                string maLop = lstLop.SelectedValue.ToString();
                objBL_Lop = new BL_Lop(maLop);
                DataTable dtLop = objBL_Lop.getLop_theo_Ma();
                dtLop.Rows[0]["SiSo"] = Convert.ToInt32(dtLop.Rows[0]["SiSo"]) - 1;
                objBL_Lop = new BL_Lop(dtLop);
                objBL_Lop.updateLop();
                lblIndex_SinhVien.Text = "";
                objBL_SinhVien = new BL_SinhVien(null, maLop);
                load_SinhVien_ListView(new DataView(objBL_SinhVien.getSinhVien_theo_Lop()));
            }
        }

        private void btnIn_CauHoi_Click(object sender, EventArgs e)
        {
            ds.Tables["CauHoi"].Clear();
            objBL_CauHoi = new BL_CauHoi(Convert.ToInt32(lstChuong.SelectedValue));
            DataTable dtCauHoi = objBL_CauHoi.getCauHois_theoChuong();
            foreach (DataRow r in dtCauHoi.Rows)
            {
                DataRow row = ds.Tables["CauHoi"].NewRow();
                for (int i = 0; i < 8; i++) row[i] = r[i];
                ds.Tables["CauHoi"].Rows.Add(row);
            }
            load_Chuong_Report();
            new frmReport(ds, 1).ShowDialog();
        }

        private void mnuItemInCauHoi_Click(object sender, EventArgs e)
        {
            ds.Tables["CauHoi"].Clear();
            objBL_CauHoi = new BL_CauHoi(dgVwCauHoi.CurrentRow.Cells[0].Value.ToString());
            DataTable dtCauHoi = objBL_CauHoi.getCauHoi_theoMa();
            DataRow row = ds.Tables["CauHoi"].NewRow();
            for (int i = 0; i < 8; i++) row[i] = dtCauHoi.Rows[0][i];
            ds.Tables["CauHoi"].Rows.Add(row);
            load_Chuong_Report();
            new frmReport(ds, 2).ShowDialog();
        }

        private void load_Chuong_Report()
        {
            ds.Tables["Chuong"].Clear();
            objBL_Chuong = new BL_Chuong(Convert.ToInt32(dgVwCauHoi.CurrentRow.Cells[0].Value));
            DataTable dtChuong = objBL_Chuong.getChuong_theo_maChuong();
            DataRow row = ds.Tables["Chuong"].NewRow();
            for (int i = 0; i < 2; i++) row[i] = dtChuong.Rows[0][i];
            ds.Tables["Chuong"].Rows.Add(row);
        }

        private void mnuItemInSinhVien_Click(object sender, EventArgs e)
        {
            ds.Tables["SinhVien"].Clear();
            objBL_SinhVien = new BL_SinhVien(lstVwSinhVien.SelectedItems[0].Text);
            DataTable dtSV = objBL_SinhVien.getSinhVien_theo_Ma();
            DataRow row = ds.Tables["SinhVien"].NewRow();
            for (int i = 0; i < 8; i++) row[i] = dtSV.Rows[0][i];
            ds.Tables["SinhVien"].Rows.Add(row);
            load_Lop_Report();
            new frmReport(ds, 4).ShowDialog();
        }

        private void btnIn_SinhVien_Click(object sender, EventArgs e)
        {
            ds.Tables["SinhVien"].Clear();
            objBL_SinhVien = new BL_SinhVien(null, lstLop.SelectedValue.ToString());
            DataView dvSV = new DataView(objBL_SinhVien.getSinhVien_theo_Lop());
            dvSV.Sort = "Ten asc";
            foreach (DataRowView r in dvSV)
            {
                DataRow row = ds.Tables["SinhVien"].NewRow();
                for (int i = 0; i < 8; i++) row[i] = r[i];
                ds.Tables["SinhVien"].Rows.Add(row);
            }
            load_Lop_Report();
            new frmReport(ds, 3).ShowDialog();
        }

        private void load_Lop_Report()
        {
            ds.Tables["Lop"].Clear();
            objBL_Lop = new BL_Lop(lstLop.SelectedValue.ToString());
            DataTable dtLop = objBL_Lop.getLop_theo_Ma();
            DataRow row = ds.Tables["Lop"].NewRow();
            for (int i = 0; i < 4; i++) row[i] = dtLop.Rows[0][i];
            ds.Tables["Lop"].Rows.Add(row);
        }
    }
}
