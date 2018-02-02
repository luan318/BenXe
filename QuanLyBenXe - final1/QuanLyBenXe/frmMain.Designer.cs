namespace QuanLyBenXe
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TsL_TaiKhoan = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup_GioiThieu = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup_QuanLyKhachHang = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup_DatVe = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup_QuanLyChuyenXe = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup_QuanLyNhanVien = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_DanhSachNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_QuanLyNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_QuanLyNhom = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup_ThongKe = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.SkinsLink = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsL_TaiKhoan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(922, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TsL_TaiKhoan
            // 
            this.TsL_TaiKhoan.Name = "TsL_TaiKhoan";
            this.TsL_TaiKhoan.Size = new System.Drawing.Size(118, 17);
            this.TsL_TaiKhoan.Text = "toolStripStatusLabel1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 22);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(922, 521);
            this.splitContainerControl1.SplitterPosition = 288;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup_GioiThieu;
            this.navBarControl1.Appearance.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.navBarControl1.Appearance.Background.Options.UseBackColor = true;
            this.navBarControl1.Appearance.Background.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.Background.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup_GioiThieu,
            this.navBarGroup_QuanLyKhachHang,
            this.navBarGroup_DatVe,
            this.navBarGroup_QuanLyChuyenXe,
            this.navBarGroup_QuanLyNhanVien,
            this.navBarGroup_ThongKe});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem_DanhSachNhanVien,
            this.navBarItem8,
            this.navBarItem10,
            this.navBarItem11,
            this.navBarItem_QuanLyNhanVien,
            this.navBarItem_QuanLyNhom,
            this.navBarItem2});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 288;
            this.navBarControl1.Size = new System.Drawing.Size(288, 521);
            this.navBarControl1.TabIndex = 2;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup_GioiThieu
            // 
            this.navBarGroup_GioiThieu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup_GioiThieu.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.navBarGroup_GioiThieu.Appearance.Options.UseFont = true;
            this.navBarGroup_GioiThieu.Appearance.Options.UseForeColor = true;
            this.navBarGroup_GioiThieu.Caption = "GIỚI THIỆU";
            this.navBarGroup_GioiThieu.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup_GioiThieu.Hint = "Giới Thiệu";
            this.navBarGroup_GioiThieu.LargeImage = global::QuanLyBenXe.Properties.Resources.bus;
            this.navBarGroup_GioiThieu.Name = "navBarGroup_GioiThieu";
            this.navBarGroup_GioiThieu.SmallImage = global::QuanLyBenXe.Properties.Resources.bus_side_view;
            this.navBarGroup_GioiThieu.SmallImageSize = new System.Drawing.Size(30, 30);
            toolTipTitleItem3.Appearance.Image = global::QuanLyBenXe.Properties.Resources.bus_side_view;
            toolTipTitleItem3.Appearance.Options.UseImage = true;
            toolTipTitleItem3.Image = global::QuanLyBenXe.Properties.Resources.bus_side_view;
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.navBarGroup_GioiThieu.SuperTip = superToolTip3;
            // 
            // navBarGroup_QuanLyKhachHang
            // 
            this.navBarGroup_QuanLyKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup_QuanLyKhachHang.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.navBarGroup_QuanLyKhachHang.Appearance.Options.UseFont = true;
            this.navBarGroup_QuanLyKhachHang.Appearance.Options.UseForeColor = true;
            this.navBarGroup_QuanLyKhachHang.Caption = "QUẢN LÝ KHÁCH HÀNG";
            this.navBarGroup_QuanLyKhachHang.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup_QuanLyKhachHang.Name = "navBarGroup_QuanLyKhachHang";
            this.navBarGroup_QuanLyKhachHang.SmallImage = global::QuanLyBenXe.Properties.Resources.users_group;
            this.navBarGroup_QuanLyKhachHang.SmallImageSize = new System.Drawing.Size(30, 30);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "DANH SÁCH KHÁCH HÀNG";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.click1);
            // 
            // navBarGroup_DatVe
            // 
            this.navBarGroup_DatVe.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup_DatVe.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.navBarGroup_DatVe.Appearance.Options.UseFont = true;
            this.navBarGroup_DatVe.Appearance.Options.UseForeColor = true;
            this.navBarGroup_DatVe.Caption = "ĐẶT VÉ";
            this.navBarGroup_DatVe.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem10),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.navBarGroup_DatVe.Name = "navBarGroup_DatVe";
            this.navBarGroup_DatVe.SmallImage = global::QuanLyBenXe.Properties.Resources.train_ticket;
            this.navBarGroup_DatVe.SmallImageSize = new System.Drawing.Size(30, 30);
            // 
            // navBarItem10
            // 
            this.navBarItem10.Caption = "CHỌN CHUYẾN";
            this.navBarItem10.Name = "navBarItem10";
            this.navBarItem10.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Timxe);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "HỦY VÉ";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // navBarGroup_QuanLyChuyenXe
            // 
            this.navBarGroup_QuanLyChuyenXe.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup_QuanLyChuyenXe.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.navBarGroup_QuanLyChuyenXe.Appearance.Options.UseFont = true;
            this.navBarGroup_QuanLyChuyenXe.Appearance.Options.UseForeColor = true;
            this.navBarGroup_QuanLyChuyenXe.Caption = "QUẢN LÝ CHUYẾN XE";
            this.navBarGroup_QuanLyChuyenXe.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11)});
            this.navBarGroup_QuanLyChuyenXe.Name = "navBarGroup_QuanLyChuyenXe";
            this.navBarGroup_QuanLyChuyenXe.SmallImage = global::QuanLyBenXe.Properties.Resources.bus;
            this.navBarGroup_QuanLyChuyenXe.SmallImageSize = new System.Drawing.Size(30, 30);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "QUẢN LÝ XE";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.QLxe);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "QUẢN LÝ CHUYẾN ĐI";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.DSchuyen);
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "QUẢN LÝ TUYẾN";
            this.navBarItem11.Name = "navBarItem11";
            this.navBarItem11.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem11_LinkClicked);
            // 
            // navBarGroup_QuanLyNhanVien
            // 
            this.navBarGroup_QuanLyNhanVien.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup_QuanLyNhanVien.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.navBarGroup_QuanLyNhanVien.Appearance.Options.UseFont = true;
            this.navBarGroup_QuanLyNhanVien.Appearance.Options.UseForeColor = true;
            this.navBarGroup_QuanLyNhanVien.Caption = "QUẢN LÝ NHÂN VIÊN";
            this.navBarGroup_QuanLyNhanVien.Expanded = true;
            this.navBarGroup_QuanLyNhanVien.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_DanhSachNhanVien),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_QuanLyNhanVien),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_QuanLyNhom)});
            this.navBarGroup_QuanLyNhanVien.Name = "navBarGroup_QuanLyNhanVien";
            this.navBarGroup_QuanLyNhanVien.SmallImage = global::QuanLyBenXe.Properties.Resources.businessman_having_a_connection;
            this.navBarGroup_QuanLyNhanVien.SmallImageSize = new System.Drawing.Size(30, 30);
            // 
            // navBarItem_DanhSachNhanVien
            // 
            this.navBarItem_DanhSachNhanVien.Caption = "DANH SÁCH NHÂN VIÊN";
            this.navBarItem_DanhSachNhanVien.Name = "navBarItem_DanhSachNhanVien";
            this.navBarItem_DanhSachNhanVien.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_DanhSachNhanVien_LinkClicked);
            // 
            // navBarItem_QuanLyNhanVien
            // 
            this.navBarItem_QuanLyNhanVien.Caption = "QUẢN LÝ NHÂN VIÊN";
            this.navBarItem_QuanLyNhanVien.Name = "navBarItem_QuanLyNhanVien";
            this.navBarItem_QuanLyNhanVien.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_QuanLyNhanVien_LinkClicked);
            // 
            // navBarItem_QuanLyNhom
            // 
            this.navBarItem_QuanLyNhom.Caption = "QUẢN LÝ NHÓM";
            this.navBarItem_QuanLyNhom.Name = "navBarItem_QuanLyNhom";
            this.navBarItem_QuanLyNhom.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_QuanLyNhom_LinkClicked);
            // 
            // navBarGroup_ThongKe
            // 
            this.navBarGroup_ThongKe.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup_ThongKe.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.navBarGroup_ThongKe.Appearance.Options.UseFont = true;
            this.navBarGroup_ThongKe.Appearance.Options.UseForeColor = true;
            this.navBarGroup_ThongKe.Caption = "THỐNG KÊ";
            this.navBarGroup_ThongKe.Expanded = true;
            this.navBarGroup_ThongKe.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8)});
            this.navBarGroup_ThongKe.Name = "navBarGroup_ThongKe";
            this.navBarGroup_ThongKe.SmallImage = global::QuanLyBenXe.Properties.Resources.analytics;
            this.navBarGroup_ThongKe.SmallImageSize = new System.Drawing.Size(30, 30);
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "THỐNG KÊ";
            this.navBarItem8.Name = "navBarItem8";
            this.navBarItem8.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem8_LinkClicked);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelControl1.Appearance.Options.UseFont = true;
            this.panelControl1.Appearance.Options.UseForeColor = true;
            this.panelControl1.AutoSize = true;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(629, 521);
            this.panelControl1.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barSubItem2,
            this.SkinsLink});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Hệ Thống";
            this.barSubItem1.Glyph = global::QuanLyBenXe.Properties.Resources.properties_16x16;
            this.barSubItem1.Id = 1;
            this.barSubItem1.LargeGlyph = global::QuanLyBenXe.Properties.Resources.properties_32x32;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đổi  mật khẩu";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Đăng xuất";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thoát";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.F3));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Themes";
            this.barSubItem2.Glyph = global::QuanLyBenXe.Properties.Resources.palette_16x16;
            this.barSubItem2.Id = 5;
            this.barSubItem2.LargeGlyph = global::QuanLyBenXe.Properties.Resources.palette_32x32;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.SkinsLink)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // SkinsLink
            // 
            this.SkinsLink.Caption = "Skins";
            this.SkinsLink.Id = 6;
            this.SkinsLink.Name = "SkinsLink";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(922, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 565);
            this.barDockControlBottom.Size = new System.Drawing.Size(922, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 543);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(922, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 543);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 565);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Vé";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_GioiThieu;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_QuanLyKhachHang;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_QuanLyChuyenXe;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_QuanLyNhanVien;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_DanhSachNhanVien;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_DatVe;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_ThongKe;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
//private DongHoHeThong.UserControl1 userControl11;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_QuanLyNhanVien;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_QuanLyNhom;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarLinkContainerItem SkinsLink;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ToolStripStatusLabel TsL_TaiKhoan;
    }
}