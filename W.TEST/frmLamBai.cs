using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BusinessLogicTier;
using System.Collections;
using System.IO;

namespace W.TEST
{
    public partial class frmLamBai : Form
    {
        private int chuong, viTri = 0, nopBai = 0;
        private string mSSV;
        private ArrayList ranCauHoi = new ArrayList();
        private string[] chon = new string[60], ganco = new string[60];
        private string[,] ranDapAn = new string[60, 4];
        private BL_CauHoi objBL_CauHoi;
        private DataTable dt;
        //Download source code tại Sharecode.vn
        public frmLamBai(int chuong, string ten, string mSSV, string lop)
        {
            InitializeComponent();
            this.chuong = chuong;
            this.mSSV = mSSV;
            lblMSSV_HoTen.Text = mSSV + " - " + ten;
            lblLop.Text = lop;
            picSV.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/imageSV/" + mSSV + ".PNG");
            lblMSSV_HoTen.BackColor = Color.Transparent;
            lblLop.BackColor = Color.Transparent;
            lblMon.BackColor = Color.Transparent;
            lblTime.BackColor = Color.Transparent;
            lblMocTime1.BackColor = Color.Transparent;
            lblMocTime2.BackColor = Color.Transparent;
        }

        private void frmLamBai_Load(object sender, EventArgs e)
        {
            objBL_CauHoi = new BL_CauHoi(chuong);
            dt = objBL_CauHoi.getCauHois();
            Random ran = new Random();
            while (ranCauHoi.Count < 60)
            {
                int i = ran.Next(0, dt.Rows.Count);
                if (!ranCauHoi.Contains(i))
                    ranCauHoi.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                for (int j = 0; j < 4; )
                {
                    int k = ran.Next(0, 4);
                    string str = "";
                    switch (k)
                    {
                        case 0: str = "A"; break;
                        case 1: str = "B"; break;
                        case 2: str = "C"; break;
                        case 3: str = "D"; break;
                    }
                    bool trung = false;
                    for (int l = 0; l < j; l++)
                        if (ranDapAn[i, l].Equals(str))
                        {
                            trung = true;
                            break;
                        }
                    if (trung) continue;
                    ranDapAn[i, j++] = str;
                }
                loadCauHoi(1);
            }
        }

        private void loadCauHoi(int type)
        {
            btnCauKeTiep.Enabled = viTri == 59 ? false : true;
            btnCauTruoc.Enabled = viTri == 0 ? false : true;
            lblCauHoi.Text = lblCauHoi.Text.Remove(lblCauHoi.Text.IndexOf("/60."));
            lblCauHoi.Text = lblCauHoi.Text.Remove(lblCauHoi.Text.IndexOf(" ") + 1);
            lblCauHoi.Text += (viTri + 1) + "/60. ";
            lblCauHoi.Text += dt.Rows[(Int32)ranCauHoi[viTri]]["CauHoi"].ToString();
            int rowCauHoi = lblCauHoi.Text.Length / 123;
            lblBorderCauHoi.Location = new System.Drawing.Point(12, 45 + 20 * rowCauHoi);
            pnDapAn.Location = new System.Drawing.Point(43, 70 + 20 * rowCauHoi);
            lblA.Text = dt.Rows[(Int32)ranCauHoi[viTri]][ranDapAn[viTri, 0].ToString()].ToString();
            int rowA = lblA.Text.Length / 106;
            lblBorderA.Location = new System.Drawing.Point(44, 40 + 20 * rowA);
            radB.Location = new System.Drawing.Point(21, 93 + 20 * rowA);
            lblB.Location = new System.Drawing.Point(41, 78 + 20 * rowA);
            lblBorderB.Location = new System.Drawing.Point(44, 105 + 20 * rowA);
            lblC.Location = new System.Drawing.Point(41, 146 + 20 * rowA);
            radC.Location = new System.Drawing.Point(21, 158 + 20 * rowA);
            lblBorderC.Location = new System.Drawing.Point(44, 170 + 20 * rowA);
            radD.Location = new System.Drawing.Point(21, 223 + 20 * rowA);
            lblD.Location = new System.Drawing.Point(41, 210 + 20 * rowA);
            lblBorderD.Location = new System.Drawing.Point(44, 235 + 20 * rowA);

            lblB.Text = dt.Rows[(Int32)ranCauHoi[viTri]][ranDapAn[viTri, 1].ToString()].ToString();
            int rowB = lblB.Text.Length / 106 + rowA;
            lblBorderB.Location = new System.Drawing.Point(44, 105 + 20 * rowB);
            lblC.Location = new System.Drawing.Point(41, 146 + 20 * rowB);
            radC.Location = new System.Drawing.Point(21, 158 + 20 * rowB);
            lblBorderC.Location = new System.Drawing.Point(44, 170 + 20 * rowB);
            radD.Location = new System.Drawing.Point(21, 223 + 20 * rowB);
            lblD.Location = new System.Drawing.Point(41, 210 + 20 * rowB);
            lblBorderD.Location = new System.Drawing.Point(44, 235 + 20 * rowB);

            lblC.Text = dt.Rows[(Int32)ranCauHoi[viTri]][ranDapAn[viTri, 2].ToString()].ToString();
            int rowC = lblC.Text.Length / 106 + rowB;
            lblBorderC.Location = new System.Drawing.Point(44, 170 + 20 * rowC);
            radD.Location = new System.Drawing.Point(21, 223 + 20 * rowC);
            lblD.Location = new System.Drawing.Point(41, 210 + 20 * rowC);
            lblBorderD.Location = new System.Drawing.Point(44, 235 + 20 * rowC);

            lblD.Text = dt.Rows[(Int32)ranCauHoi[viTri]][ranDapAn[viTri, 3].ToString()].ToString();
            int rowD = lblD.Text.Length / 106 + rowC;
            lblBorderD.Location = new System.Drawing.Point(44, 235 + 20 * rowD);
            if (type == 2)
                for(int i=0;i<4;i++)
                    if(dt.Rows[(Int32)ranCauHoi[viTri]]["DapAn"].ToString().Equals(ranDapAn[viTri,i]))
                        switch (i)
                        {
                            case 0: lblA.ForeColor = Color.Red; break;
                            case 1: lblB.ForeColor = Color.Red; break;
                            case 2: lblC.ForeColor = Color.Red; break;
                            case 3: lblD.ForeColor = Color.Red; break;
                        }
            radA.Checked = false;
            radB.Checked = false;
            radC.Checked = false;
            radD.Checked = false;
            for (int i = 0; i < 4; i++)
                if (ranDapAn[viTri, i].Equals(chon[viTri]))
                {
                    switch (i)
                    {
                        case 0: radA.Checked = true; break;
                        case 1: radB.Checked = true; break;
                        case 2: radC.Checked = true; break;
                        case 3: radD.Checked = true; break;
                    }
                    break;
                }
            chkCoHieu.Checked = ganco[viTri] != null ? true : false;
        }

        private void btnCauTruoc_Click(object sender, EventArgs e)
        {
            if ((viTri == 59 && (Button)sender == btnCauKeTiep) || (viTri == 0 && (Button)sender == btnCauTruoc))
                return;
            if ((Button)sender == btnCauTruoc)
                viTri--;
            else
                viTri++;
            if ((lblA.ForeColor == lblB.ForeColor) && (lblB.ForeColor == lblC.ForeColor) && (lblC.ForeColor == lblD.ForeColor))
            {
                btnChonCau.Enabled = true;
                loadCauHoi(1);
            }
            else
            {
                lblA.ForeColor = Color.White;
                lblB.ForeColor = Color.White;
                lblC.ForeColor = Color.White;
                lblD.ForeColor = Color.White;
                loadCauHoi(2);
            }
        }

        private void btnChonCau_Click(object sender, EventArgs e)
        {
            lblCauHoi.Visible = false;
            lblBorderCauHoi.Visible = false;
            pnDapAn.Visible = false;
            grbChonCau.Visible = true;
            btnCauTruoc.Enabled = false;
            btnCauKeTiep.Enabled = false;
            btnChonCau.Enabled = false;
            chkCoHieu.Checked = false;
            foreach (Label lbl in pn1_15.Controls)
                if (lbl.Name[0].Equals('c'))
                    lbl.Text = chon[Convert.ToInt32(lbl.Name.Substring(7)) - 1] == null ? "Chưa làm" : "";
                else
                    lbl.Text = ganco[Convert.ToInt32(lbl.Name.Substring(5)) - 1];
            foreach (Label lbl in pn16_30.Controls)
                if (lbl.Name[0].Equals('c'))
                    lbl.Text = chon[Convert.ToInt32(lbl.Name.Substring(7)) - 1] == null ? "Chưa làm" : "";
                else
                    lbl.Text = ganco[Convert.ToInt32(lbl.Name.Substring(5)) - 1];
            foreach (Label lbl in pn31_45.Controls)
                if (lbl.Name[0].Equals('c'))
                    lbl.Text = chon[Convert.ToInt32(lbl.Name.Substring(7)) - 1] == null ? "Chưa làm" : "";
                else
                    lbl.Text = ganco[Convert.ToInt32(lbl.Name.Substring(5)) - 1];
            foreach (Label lbl in pn46_60.Controls)
                if (lbl.Name[0].Equals('c'))
                    lbl.Text = chon[Convert.ToInt32(lbl.Name.Substring(7)) - 1] == null ? "Chưa làm" : "";
                else
                    lbl.Text = ganco[Convert.ToInt32(lbl.Name.Substring(5)) - 1];
        }

        private void radChonCau_CheckedChange(object sender, EventArgs e)
        {
            grbChonCau.Visible = false;
            lblCauHoi.Visible = true;
            lblBorderCauHoi.Visible = true;
            pnDapAn.Visible = true;
            viTri = Convert.ToInt32(((RadioButton)sender).Text) - 1;
            btnCauTruoc.Enabled = true;
            btnCauKeTiep.Enabled = true;
            loadCauHoi(1);
            ((RadioButton)sender).Checked = false;
        }

        private void radA_Click(object sender, EventArgs e)
        {
            if ((lblA.ForeColor == lblB.ForeColor) && (lblB.ForeColor == lblC.ForeColor) && (lblC.ForeColor == lblD.ForeColor))
                chon[viTri] = ranDapAn[viTri, Convert.ToInt32(((RadioButton)sender).Tag)].ToString();
            else
                for (int i = 0; i < 4; i++)
                    if (ranDapAn[viTri, i].Equals(chon[viTri]))
                    {
                        switch (i)
                        {
                            case 0: radA.Checked = true; break;
                            case 1: radB.Checked = true; break;
                            case 2: radC.Checked = true; break;
                            case 3: radD.Checked = true; break;
                        }
                        break;
                    }
        }

        private void btnCauTruoc_EnabledChanged(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = ((Button)sender).Enabled ? Color.Yellow : Color.Khaki;
        }

        private void chkCoHieu_Click(object sender, EventArgs e)
        {
            ganco[viTri] = chkCoHieu.Checked ? "Có" : null;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            prgTime.Value++;
            lblTime.Text = (prgTime.Value / 60) + " / 60 phút (" + prgTime.Value / 36 + "%)";
            if (prgTime.Value == prgTime.Maximum)
            {
                tmr.Stop();
                chamDiem();
                btnNopBai_LuyenTapLai.Text = "Luyện tập lại";
            }
        }

        private bool kiemTra_nopBai()
        {
            for (int i = 0; i < 60; i++)
                if (chon[i] == null)
                    return false;
            return true;
        }

        private void grbChonCau_VisibleChanged(object sender, EventArgs e)
        {
            if (!grbChonCau.Visible)
                nopBai = 0;
        }

        private void btnNopBai_LuyenTapLai_Click(object sender, EventArgs e)
        {
            if (btnNopBai_LuyenTapLai.Text.Equals("Nộp bài và kết thúc"))
            {
                if (nopBai == 1)
                {
                    if (MessageBox.Show("Xác nhận lần thứ hai: Bạn muốn kết thúc bài làm và nộp bài?", "Nộp bài",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        chamDiem();
                        btnNopBai_LuyenTapLai.Text = "Luyện tập lại";
                        tmr.Stop();
                    }
                    return;
                }
                if (!kiemTra_nopBai())
                {
                    MessageBox.Show("Để kết thúc bài thi sớm, bạn phải trả lời tất cả các câu hỏi.", "Nộp bài",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (prgTime.Value < 600)
                {
                    MessageBox.Show("Chỉ cho phép nộp bài khi sau 10 phút trở lên tính từ lúc làm bài.", "Nộp bài",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Xác nhận lần thứ nhất: Bạn muốn kết thúc bài làm và nộp bài?\nNếu bạn quyết định nộp bài, bấm nút nộp bài thêm một lần nữa để xác nhận.",
                    "Nộp bài", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                nopBai = 1;
                btnChonCau_Click(null, null);
            }
            else
                this.DialogResult = DialogResult.Retry;
        }

        private void chamDiem()
        {
            int cauDung = 0;
            for (int i = 0; i < 60; i++)
            {
                if (chon[i] == null) continue;
                if (dt.Rows[(Int32)ranCauHoi[i]]["DapAn"].ToString().Equals(chon[i]))
                    cauDung++;
            }
            pnLamBai.Visible = false;
            pnChamDiem.Visible = true;
            lblKetQua.Text += String.Format("{0:0.0} điểm", (double)cauDung * 10 / 60);
            capNhatDiem(Math.Round((double)cauDung * 10 / 60, 1));
            btnXemDapAn.Visible = cauDung * 10 / 60 >= 7;
        }

        private void capNhatDiem(double diem)
        {
            DataTable dt = new BL_SinhVien(mSSV).getSinhVien_theo_Ma();
            if (dt.Rows[0]["DiemCaoNhat"].ToString() == "" || Convert.ToDouble(dt.Rows[0]["DiemCaoNhat"]) < diem)
                dt.Rows[0]["DiemCaoNhat"] = diem;
            new BL_SinhVien(dt).updateSinhVien();
        }

        private void btnXemDapAn_Click(object sender, EventArgs e)
        {
            viTri = 0;
            btnChonCau.Enabled = false;
            chkCoHieu.Click += new EventHandler(chkDapAn_Click);
            pnChamDiem.Visible = false;
            pnLamBai.Visible = true;
            grbChonCau.Visible = false;
            lblCauHoi.Visible = true;
            lblBorderCauHoi.Visible = true;
            pnDapAn.Visible = true;
            loadCauHoi(2);
        }

        private void chkDapAn_Click(object sender, EventArgs e)
        {
            chkCoHieu.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
