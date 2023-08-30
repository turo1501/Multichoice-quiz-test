namespace W.TEST
{
    partial class frmTimKiem_CauHoi
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txtCauHoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboChuong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboDapAn = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.txtDapAn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.btnTroVe = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
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
            this.labelX1.Size = new System.Drawing.Size(98, 17);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Từ khóa câu hỏi:";
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
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
            this.txtCauHoi.Location = new System.Drawing.Point(116, 10);
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(284, 22);
            this.txtCauHoi.TabIndex = 0;
            // 
            // cboChuong
            // 
            this.cboChuong.DisplayMember = "Text";
            this.cboChuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboChuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuong.FocusHighlightEnabled = true;
            this.cboChuong.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cboChuong, true);
            this.cboChuong.ItemHeight = 16;
            this.cboChuong.Location = new System.Drawing.Point(116, 94);
            this.cboChuong.Name = "cboChuong";
            this.cboChuong.Size = new System.Drawing.Size(284, 22);
            this.cboChuong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboChuong.TabIndex = 3;
            // 
            // cboDapAn
            // 
            this.cboDapAn.DisplayMember = "Text";
            this.cboDapAn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDapAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDapAn.FocusHighlightEnabled = true;
            this.cboDapAn.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cboDapAn, true);
            this.cboDapAn.ItemHeight = 16;
            this.cboDapAn.Items.AddRange(new object[] {
            this.comboItem5,
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.cboDapAn.Location = new System.Drawing.Point(116, 66);
            this.cboDapAn.Name = "cboDapAn";
            this.cboDapAn.Size = new System.Drawing.Size(284, 22);
            this.cboDapAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboDapAn.TabIndex = 2;
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "Ngẫu nhiên";
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
            // txtDapAn
            // 
            // 
            // 
            // 
            this.txtDapAn.Border.Class = "TextBoxBorder";
            this.txtDapAn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDapAn.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtDapAn, true);
            this.txtDapAn.Location = new System.Drawing.Point(116, 38);
            this.txtDapAn.Name = "txtDapAn";
            this.txtDapAn.Size = new System.Drawing.Size(284, 22);
            this.txtDapAn.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.highlighter.SetHighlightOnFocus(this.btnTimKiem, true);
            this.btnTimKiem.Image = global::W.TEST.Properties.Resources.Search_32;
            this.btnTimKiem.Location = new System.Drawing.Point(113, 133);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 40);
            this.btnTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTroVe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTroVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.highlighter.SetHighlightOnFocus(this.btnTroVe, true);
            this.btnTroVe.Image = global::W.TEST.Properties.Resources.Go_Back_32;
            this.btnTroVe.Location = new System.Drawing.Point(216, 133);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(84, 40);
            this.btnTroVe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTroVe.TabIndex = 5;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 71);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(48, 17);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Đáp án:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 99);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(52, 17);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Chương:";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 40);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(96, 17);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Từ khóa đáp án:";
            // 
            // frmTimKiem_CauHoi
            // 
            this.AcceptButton = this.btnTimKiem;
            this.CancelButton = this.btnTroVe;
            this.ClientSize = new System.Drawing.Size(411, 185);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboDapAn);
            this.Controls.Add(this.cboChuong);
            this.Controls.Add(this.txtDapAn);
            this.Controls.Add(this.txtCauHoi);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimKiem_CauHoi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm câu hỏi";
            this.Load += new System.EventHandler(this.frmTimKiem_CauHoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboChuong;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCauHoi;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboDapAn;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDapAn;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnTroVe;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
    }
}