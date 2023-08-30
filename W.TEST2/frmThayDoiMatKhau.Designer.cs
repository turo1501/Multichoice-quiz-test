namespace W.TEST
{
    partial class frmThayDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThayDoiMatKhau));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtMKCu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMKMoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMKMoi_2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTroVe = new DevComponents.DotNetBar.ButtonX();
            this.btnChapNhan = new DevComponents.DotNetBar.ButtonX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
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
            this.labelX1.Size = new System.Drawing.Size(77, 17);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mật khẩu cũ:";
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
            this.labelX2.Size = new System.Drawing.Size(84, 17);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mật khẩu mới:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 68);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(111, 17);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Nhập lại mật khẩu:";
            // 
            // txtMKCu
            // 
            // 
            // 
            // 
            this.txtMKCu.Border.Class = "TextBoxBorder";
            this.txtMKCu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMKCu.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtMKCu, true);
            this.txtMKCu.Location = new System.Drawing.Point(135, 10);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(227, 22);
            this.txtMKCu.TabIndex = 0;
            this.txtMKCu.Tag = "Mật khẩu cũ";
            this.txtMKCu.UseSystemPasswordChar = true;
            // 
            // txtMKMoi
            // 
            // 
            // 
            // 
            this.txtMKMoi.Border.Class = "TextBoxBorder";
            this.txtMKMoi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMKMoi.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtMKMoi, true);
            this.txtMKMoi.Location = new System.Drawing.Point(135, 38);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(227, 22);
            this.txtMKMoi.TabIndex = 1;
            this.txtMKMoi.Tag = "Mật khẩu mới";
            this.txtMKMoi.UseSystemPasswordChar = true;
            // 
            // txtMKMoi_2
            // 
            // 
            // 
            // 
            this.txtMKMoi_2.Border.Class = "TextBoxBorder";
            this.txtMKMoi_2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMKMoi_2.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtMKMoi_2, true);
            this.txtMKMoi_2.Location = new System.Drawing.Point(135, 66);
            this.txtMKMoi_2.MaxLength = 20;
            this.txtMKMoi_2.Name = "txtMKMoi_2";
            this.txtMKMoi_2.Size = new System.Drawing.Size(227, 22);
            this.txtMKMoi_2.TabIndex = 2;
            this.txtMKMoi_2.Tag = "Mật khẩu mới lần nữa";
            this.txtMKMoi_2.UseSystemPasswordChar = true;
            // 
            // btnTroVe
            // 
            this.btnTroVe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTroVe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTroVe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTroVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.highlighter.SetHighlightOnFocus(this.btnTroVe, true);
            this.btnTroVe.Image = global::W.TEST.Properties.Resources.Go_Back_32;
            this.btnTroVe.Location = new System.Drawing.Point(203, 104);
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
            this.btnChapNhan.Location = new System.Drawing.Point(86, 104);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(111, 40);
            this.btnChapNhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChapNhan.TabIndex = 3;
            this.btnChapNhan.Text = "Chấp nhận";
            this.btnChapNhan.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // frmThayDoiMatKhau
            // 
            this.AcceptButton = this.btnChapNhan;
            this.CancelButton = this.btnTroVe;
            this.ClientSize = new System.Drawing.Size(375, 156);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.txtMKMoi_2);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThayDoiMatKhau";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMKCu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMKMoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMKMoi_2;
        private DevComponents.DotNetBar.ButtonX btnTroVe;
        private DevComponents.DotNetBar.ButtonX btnChapNhan;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
    }
}