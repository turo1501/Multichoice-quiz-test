namespace W.TEST
{
    partial class frmThem_Lop
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txtMa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGVCN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTroVe = new DevComponents.DotNetBar.ButtonX();
            this.btnChapNhan = new DevComponents.DotNetBar.ButtonX();
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
            this.labelX1.Size = new System.Drawing.Size(45, 17);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã lớp:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 40);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(49, 17);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên lớp:";
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
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
            this.txtMa.Location = new System.Drawing.Point(63, 10);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(288, 22);
            this.txtMa.TabIndex = 0;
            this.txtMa.Tag = "Mã lớp";
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTen.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtTen, true);
            this.txtTen.Location = new System.Drawing.Point(63, 38);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(288, 22);
            this.txtTen.TabIndex = 1;
            this.txtTen.Tag = "Tên lớp";
            // 
            // txtGVCN
            // 
            // 
            // 
            // 
            this.txtGVCN.Border.Class = "TextBoxBorder";
            this.txtGVCN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGVCN.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtGVCN, true);
            this.txtGVCN.Location = new System.Drawing.Point(63, 66);
            this.txtGVCN.Name = "txtGVCN";
            this.txtGVCN.Size = new System.Drawing.Size(288, 22);
            this.txtGVCN.TabIndex = 2;
            this.txtGVCN.Tag = "GVCN";
            // 
            // btnTroVe
            // 
            this.btnTroVe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTroVe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTroVe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTroVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.highlighter.SetHighlightOnFocus(this.btnTroVe, true);
            this.btnTroVe.Image = global::W.TEST.Properties.Resources.Go_Back_32;
            this.btnTroVe.Location = new System.Drawing.Point(197, 110);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(85, 40);
            this.btnTroVe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTroVe.TabIndex = 4;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChapNhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.highlighter.SetHighlightOnFocus(this.btnChapNhan, true);
            this.btnChapNhan.Image = global::W.TEST.Properties.Resources.Tick_32;
            this.btnChapNhan.Location = new System.Drawing.Point(80, 110);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(111, 40);
            this.btnChapNhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChapNhan.TabIndex = 3;
            this.btnChapNhan.Text = "Chấp nhận";
            this.btnChapNhan.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 68);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(44, 17);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "GVCN:";
            // 
            // frmThem_Lop
            // 
            this.AcceptButton = this.btnChapNhan;
            this.CancelButton = this.btnTroVe;
            this.ClientSize = new System.Drawing.Size(363, 162);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.txtGVCN);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThem_Lop";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chương mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGVCN;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMa;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnTroVe;
        private DevComponents.DotNetBar.ButtonX btnChapNhan;
    }
}