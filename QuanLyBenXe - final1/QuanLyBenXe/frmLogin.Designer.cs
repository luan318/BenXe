namespace QuanLyBenXe
{
    partial class frmLogin
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_DangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtb_MatKhau = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtb_TaiKhoan = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pictureEdit2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(184, 193);
            this.panelControl2.TabIndex = 0;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit2.EditValue = global::QuanLyBenXe.Properties.Resources.login;
            this.pictureEdit2.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit2.Size = new System.Drawing.Size(180, 189);
            this.pictureEdit2.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_Thoat);
            this.groupControl2.Controls.Add(this.btn_DangNhap);
            this.groupControl2.Controls.Add(this.panel11);
            this.groupControl2.Controls.Add(this.panel8);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(184, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(321, 193);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Thông Tin Đăng Nhập";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Image = global::QuanLyBenXe.Properties.Resources.logout__3_;
            this.btn_Thoat.Location = new System.Drawing.Point(183, 138);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(92, 34);
            this.btn_Thoat.TabIndex = 10000;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Image = global::QuanLyBenXe.Properties.Resources.exit_to_app_button__2_;
            this.btn_DangNhap.Location = new System.Drawing.Point(67, 138);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(92, 34);
            this.btn_DangNhap.TabIndex = 100;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.txtb_MatKhau);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Location = new System.Drawing.Point(32, 87);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(262, 25);
            this.panel11.TabIndex = 1;
            // 
            // txtb_MatKhau
            // 
            this.txtb_MatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtb_MatKhau.Location = new System.Drawing.Point(35, 0);
            this.txtb_MatKhau.Name = "txtb_MatKhau";
            this.txtb_MatKhau.PasswordChar = '*';
            this.txtb_MatKhau.Size = new System.Drawing.Size(227, 21);
            this.txtb_MatKhau.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.BackgroundImage = global::QuanLyBenXe.Properties.Resources.locked_padlock;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(5, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(30, 25);
            this.panel12.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(5, 25);
            this.panel13.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.txtb_TaiKhoan);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(32, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(262, 25);
            this.panel8.TabIndex = 0;
            // 
            // txtb_TaiKhoan
            // 
            this.txtb_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtb_TaiKhoan.Location = new System.Drawing.Point(35, 0);
            this.txtb_TaiKhoan.Name = "txtb_TaiKhoan";
            this.txtb_TaiKhoan.Size = new System.Drawing.Size(227, 21);
            this.txtb_TaiKhoan.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BackgroundImage = global::QuanLyBenXe.Properties.Resources.user;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(5, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(30, 25);
            this.panel10.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 25);
            this.panel9.TabIndex = 20;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btn_DangNhap;
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(505, 193);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLogin";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtb_MatKhau;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtb_TaiKhoan;
        
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraEditors.SimpleButton btn_Thoat;
        private DevExpress.XtraEditors.SimpleButton btn_DangNhap;
    }
}