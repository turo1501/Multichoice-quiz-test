namespace W.TEST
{
    partial class frmQuanLyMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyMatKhau));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lnkHienThi = new System.Windows.Forms.LinkLabel();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.btnTroVe = new DevComponents.DotNetBar.ButtonX();
            this.btnThayDoiMK = new DevComponents.DotNetBar.ButtonX();
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
            this.labelX1.Size = new System.Drawing.Size(84, 17);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "ID đăng nhập:";
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
            this.labelX2.Size = new System.Drawing.Size(59, 17);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mật khẩu:";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            this.txtID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtID.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtID, true);
            this.txtID.Location = new System.Drawing.Point(102, 10);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(216, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatKhau.FocusHighlightEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.txtMatKhau, true);
            this.txtMatKhau.Location = new System.Drawing.Point(102, 38);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.ReadOnly = true;
            this.txtMatKhau.Size = new System.Drawing.Size(216, 22);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lnkHienThi
            // 
            this.lnkHienThi.AutoSize = true;
            this.lnkHienThi.DisabledLinkColor = System.Drawing.Color.Blue;
            this.lnkHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHienThi.Location = new System.Drawing.Point(324, 40);
            this.lnkHienThi.Name = "lnkHienThi";
            this.lnkHienThi.Size = new System.Drawing.Size(93, 16);
            this.lnkHienThi.TabIndex = 2;
            this.lnkHienThi.TabStop = true;
            this.lnkHienThi.Text = "Hiện mật khẩu";
            this.lnkHienThi.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkHienThi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHienThi_LinkClicked);
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // btnTroVe
            // 
            this.btnTroVe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTroVe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTroVe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTroVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.highlighter.SetHighlightOnFocus(this.btnTroVe, true);
            this.btnTroVe.Image = global::W.TEST.Properties.Resources.Go_Back_32;
            this.btnTroVe.Location = new System.Drawing.Point(248, 79);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(85, 40);
            this.btnTroVe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTroVe.TabIndex = 3;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // btnThayDoiMK
            // 
            this.btnThayDoiMK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThayDoiMK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.highlighter.SetHighlightOnFocus(this.btnThayDoiMK, true);
            this.btnThayDoiMK.Image = global::W.TEST.Properties.Resources.Change_Password_32;
            this.btnThayDoiMK.Location = new System.Drawing.Point(92, 79);
            this.btnThayDoiMK.Name = "btnThayDoiMK";
            this.btnThayDoiMK.Size = new System.Drawing.Size(155, 40);
            this.btnThayDoiMK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThayDoiMK.TabIndex = 2;
            this.btnThayDoiMK.Text = "Thay đổi mật khẩu";
            this.btnThayDoiMK.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnThayDoiMK.Click += new System.EventHandler(this.btnThayDoiMK_Click);
            // 
            // frmQuanLyMatKhau
            // 
            this.AllowDrop = true;
            this.CancelButton = this.btnTroVe;
            this.ClientSize = new System.Drawing.Size(424, 131);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnThayDoiMK);
            this.Controls.Add(this.lnkHienThi);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyMatKhau";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mật khẩu";
            this.Load += new System.EventHandler(this.frmQuanLyMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
        private System.Windows.Forms.LinkLabel lnkHienThi;
        private DevComponents.DotNetBar.ButtonX btnThayDoiMK;
        private DevComponents.DotNetBar.ButtonX btnTroVe;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
    }
}