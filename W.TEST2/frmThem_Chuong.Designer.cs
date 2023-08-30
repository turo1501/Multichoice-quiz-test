namespace W.TEST
{
    partial class frmThem_Chuong
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
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.btnTroVe = new DevComponents.DotNetBar.ButtonX();
            this.btnChapNhan = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
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
            this.txtTen.Location = new System.Drawing.Point(93, 38);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(258, 22);
            this.txtTen.TabIndex = 1;
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
            this.txtMa.Location = new System.Drawing.Point(93, 10);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(258, 22);
            this.txtMa.TabIndex = 0;
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
            this.labelX2.Size = new System.Drawing.Size(75, 17);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Tên chương:";
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
            this.labelX1.Size = new System.Drawing.Size(70, 17);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Mã chương:";
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
            this.btnTroVe.Image = global::W.TEST.Properties.Resources.Go_Back_32;
            this.btnTroVe.Location = new System.Drawing.Point(197, 84);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(85, 40);
            this.btnTroVe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTroVe.TabIndex = 3;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChapNhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChapNhan.Image = global::W.TEST.Properties.Resources.Tick_32;
            this.btnChapNhan.Location = new System.Drawing.Point(80, 84);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(111, 40);
            this.btnChapNhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChapNhan.TabIndex = 2;
            this.btnChapNhan.Text = "Chấp nhận";
            this.btnChapNhan.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // frmThem_Chuong
            // 
            this.AcceptButton = this.btnChapNhan;
            this.CancelButton = this.btnTroVe;
            this.ClientSize = new System.Drawing.Size(363, 136);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThem_Chuong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chương mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMa;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.ButtonX btnChapNhan;
        private DevComponents.DotNetBar.ButtonX btnTroVe;
    }
}