namespace QuanLyBenXe
{
    partial class ucNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNhanVien));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.gc_NhanVien = new DevExpress.XtraGrid.GridControl();
            this.gv_NhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtb_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_HoatDong = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_HoatDong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Reset);
            this.panelControl2.Controls.Add(this.btn_Sua);
            this.panelControl2.Controls.Add(this.btn_Xoa);
            this.panelControl2.Controls.Add(this.btn_Them);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(706, 63);
            this.panelControl2.TabIndex = 0;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.ImageIndex = 2;
            this.btn_Reset.Location = new System.Drawing.Point(403, 16);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(115, 34);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Reset Mật Khẩu";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageIndex = 1;
            this.btn_Sua.Location = new System.Drawing.Point(280, 16);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(84, 34);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageIndex = 0;
            this.btn_Xoa.Location = new System.Drawing.Point(149, 16);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(84, 34);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            // 
            // btn_Them
            // 
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageIndex = 3;
            this.btn_Them.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(27, 16);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(84, 34);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            // 
            // gc_NhanVien
            // 
            this.gc_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_NhanVien.Location = new System.Drawing.Point(0, 125);
            this.gc_NhanVien.MainView = this.gv_NhanVien;
            this.gc_NhanVien.Name = "gc_NhanVien";
            this.gc_NhanVien.Size = new System.Drawing.Size(706, 329);
            this.gc_NhanVien.TabIndex = 1;
            this.gc_NhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_NhanVien});
            // 
            // gv_NhanVien
            // 
            this.gv_NhanVien.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gv_NhanVien.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gv_NhanVien.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.gv_NhanVien.GridControl = this.gc_NhanVien;
            this.gv_NhanVien.Name = "gv_NhanVien";
            this.gv_NhanVien.OptionsView.ShowDetailButtons = false;
            this.gv_NhanVien.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_NhanVien_RowClick);
            // 
            // txtb_TenTaiKhoan
            // 
            this.txtb_TenTaiKhoan.Location = new System.Drawing.Point(108, 24);
            this.txtb_TenTaiKhoan.Name = "txtb_TenTaiKhoan";
            this.txtb_TenTaiKhoan.Size = new System.Drawing.Size(100, 21);
            this.txtb_TenTaiKhoan.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên Tài Khoản";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Controls.Add(this.cb_HoatDong);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.txtb_TenTaiKhoan);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 63);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(706, 62);
            this.panelControl3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // cb_HoatDong
            // 
            this.cb_HoatDong.Location = new System.Drawing.Point(302, 25);
            this.cb_HoatDong.Name = "cb_HoatDong";
            this.cb_HoatDong.Properties.Caption = "Hoạt Động";
            this.cb_HoatDong.Size = new System.Drawing.Size(75, 19);
            this.cb_HoatDong.TabIndex = 2;
            // 
            // ucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gc_NhanVien);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Name = "ucNhanVien";
            this.Size = new System.Drawing.Size(706, 454);
            this.Load += new System.EventHandler(this.ucNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_HoatDong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gc_NhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_NhanVien;
        private System.Windows.Forms.TextBox txtb_TenTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.CheckEdit cb_HoatDong;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_Reset;
        private DevExpress.XtraEditors.SimpleButton btn_Sua;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
    }
}
