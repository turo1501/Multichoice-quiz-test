namespace W.TEST
{
    partial class frmXemSua_CauHoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboChuong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboDapAn = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.txtD = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtCauHoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtMa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnTroVe = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // cboChuong
            // 
            this.cboChuong.DisplayMember = "Text";
            this.cboChuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboChuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuong.Enabled = false;
            this.cboChuong.FocusHighlightEnabled = true;
            this.cboChuong.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cboChuong, true);
            this.cboChuong.ItemHeight = 16;
            this.cboChuong.Location = new System.Drawing.Point(98, 382);
            this.cboChuong.Name = "cboChuong";
            this.cboChuong.Size = new System.Drawing.Size(470, 22);
            this.cboChuong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboChuong.TabIndex = 23;
            // 
            // cboDapAn
            // 
            this.cboDapAn.DisplayMember = "Text";
            this.cboDapAn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDapAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDapAn.Enabled = false;
            this.cboDapAn.FocusHighlightEnabled = true;
            this.cboDapAn.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cboDapAn, true);
            this.cboDapAn.ItemHeight = 16;
            this.cboDapAn.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.cboDapAn.Location = new System.Drawing.Point(98, 354);
            this.cboDapAn.Name = "cboDapAn";
            this.cboDapAn.Size = new System.Drawing.Size(470, 22);
            this.cboDapAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboDapAn.TabIndex = 22;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "A";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "B";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "C";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "D";
            // 
            // txtD
            // 
            // 
            // 
            // 
            this.txtD.Border.Class = "TextBoxBorder";
            this.txtD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtD.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtD, true);
            this.txtD.Location = new System.Drawing.Point(98, 304);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(470, 44);
            this.txtD.TabIndex = 21;
            this.txtD.Tag = "Đáp án D";
            // 
            // txtB
            // 
            // 
            // 
            // 
            this.txtB.Border.Class = "TextBoxBorder";
            this.txtB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtB.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtB, true);
            this.txtB.Location = new System.Drawing.Point(98, 204);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(470, 44);
            this.txtB.TabIndex = 19;
            this.txtB.Tag = "Đáp án B";
            // 
            // txtC
            // 
            // 
            // 
            // 
            this.txtC.Border.Class = "TextBoxBorder";
            this.txtC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtC.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtC, true);
            this.txtC.Location = new System.Drawing.Point(98, 254);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(470, 44);
            this.txtC.TabIndex = 20;
            this.txtC.Tag = "Đáp án C";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(12, 387);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(52, 17);
            this.labelX8.TabIndex = 9;
            this.labelX8.Text = "Chương:";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(12, 359);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(80, 17);
            this.labelX7.TabIndex = 8;
            this.labelX7.Text = "Đáp án đúng:";
            // 
            // txtA
            // 
            // 
            // 
            // 
            this.txtA.Border.Class = "TextBoxBorder";
            this.txtA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtA.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtA, true);
            this.txtA.Location = new System.Drawing.Point(98, 154);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(470, 44);
            this.txtA.TabIndex = 18;
            this.txtA.Tag = "Đáp án A";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(12, 306);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(61, 17);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "Đáp án D:";
            // 
            // txtCauHoi
            // 
            // 
            // 
            // 
            this.txtCauHoi.Border.Class = "TextBoxBorder";
            this.txtCauHoi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCauHoi.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtCauHoi, true);
            this.txtCauHoi.Location = new System.Drawing.Point(98, 38);
            this.txtCauHoi.Multiline = true;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.ReadOnly = true;
            this.txtCauHoi.Size = new System.Drawing.Size(470, 110);
            this.txtCauHoi.TabIndex = 17;
            this.txtCauHoi.Tag = "Câu hỏi";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 206);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(60, 17);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "Đáp án B:";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 256);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(61, 17);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "Đáp án C:";
            // 
            // txtMa
            // 
            // 
            // 
            // 
            this.txtMa.Border.Class = "TextBoxBorder";
            this.txtMa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMa.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtMa, true);
            this.txtMa.Location = new System.Drawing.Point(98, 10);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(470, 22);
            this.txtMa.TabIndex = 15;
            this.txtMa.Tag = "Mã câu hỏi";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 156);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(60, 17);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Đáp án A:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 40);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(51, 17);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "Câu hỏi:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 17);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "Mã câu hỏi:";
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.highlighter.SetHighlightOnFocus(this.btnSua, true);
            this.btnSua.Image = global::W.TEST.Properties.Resources.Gnome_Logviewer_32;
            this.btnSua.Location = new System.Drawing.Point(173, 420);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 40);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTroVe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTroVe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTroVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.highlighter.SetHighlightOnFocus(this.btnTroVe, true);
            this.btnTroVe.Image = global::W.TEST.Properties.Resources.Go_Back_32;
            this.btnTroVe.Location = new System.Drawing.Point(321, 420);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(85, 40);
            this.btnTroVe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTroVe.TabIndex = 26;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Enabled = false;
            this.highlighter.SetHighlightOnFocus(this.btnLuu, true);
            this.btnLuu.Image = global::W.TEST.Properties.Resources.Save_32;
            this.btnLuu.Location = new System.Drawing.Point(248, 420);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(67, 40);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmXemSua_CauHoi
            // 
            this.CancelButton = this.btnTroVe;
            this.ClientSize = new System.Drawing.Size(579, 472);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cboChuong);
            this.Controls.Add(this.cboDapAn);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtCauHoi);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXemSua_CauHoi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin câu hỏi";
            this.Load += new System.EventHandler(this.frmXemSua_CauHoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cboChuong;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboDapAn;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtD;
        private DevComponents.DotNetBar.Controls.TextBoxX txtB;
        private DevComponents.DotNetBar.Controls.TextBoxX txtC;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtA;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCauHoi;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMa;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnTroVe;
        private DevComponents.DotNetBar.ButtonX btnLuu;
    }
}