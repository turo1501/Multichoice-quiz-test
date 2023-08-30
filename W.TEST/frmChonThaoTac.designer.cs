namespace W.TEST
{
    partial class frmChonThaoTac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonThaoTac));
            this.btnAdmin = new DevComponents.DotNetBar.ButtonX();
            this.btnLamBaiThi = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdmin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Image = global::W.TEST.Properties.Resources.Admin_min_icon;
            this.btnAdmin.Location = new System.Drawing.Point(150, 135);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(148, 40);
            this.btnAdmin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Đăng nhập Admin";
            this.btnAdmin.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnLamBaiThi
            // 
            this.btnLamBaiThi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLamBaiThi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLamBaiThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamBaiThi.Image = global::W.TEST.Properties.Resources.DVD2_copy_icon;
            this.btnLamBaiThi.Location = new System.Drawing.Point(304, 134);
            this.btnLamBaiThi.Name = "btnLamBaiThi";
            this.btnLamBaiThi.Size = new System.Drawing.Size(106, 41);
            this.btnLamBaiThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLamBaiThi.TabIndex = 4;
            this.btnLamBaiThi.Text = "Làm bài thi";
            this.btnLamBaiThi.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnLamBaiThi.Click += new System.EventHandler(this.btnLamBaiThi_Click);
            // 
            // frmChonThaoTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::W.TEST.Properties.Resources.thaotac;
            this.ClientSize = new System.Drawing.Size(413, 262);
            this.Controls.Add(this.btnLamBaiThi);
            this.Controls.Add(this.btnAdmin);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChonThaoTac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Thao Tác Chương Trình";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChonThaoTac_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnAdmin;
        private DevComponents.DotNetBar.ButtonX btnLamBaiThi;

    }
}