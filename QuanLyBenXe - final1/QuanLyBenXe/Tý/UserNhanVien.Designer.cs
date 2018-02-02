namespace QuanLyBenXe
{
    partial class UserNhanVien
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
            this.gridDanhSachNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDanhSachNhanVien
            // 
            this.gridDanhSachNhanVien.AllowDrop = true;
            this.gridDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDanhSachNhanVien.Location = new System.Drawing.Point(0, 0);
            this.gridDanhSachNhanVien.MainView = this.gridView1;
            this.gridDanhSachNhanVien.Name = "gridDanhSachNhanVien";
            this.gridDanhSachNhanVien.Size = new System.Drawing.Size(553, 457);
            this.gridDanhSachNhanVien.TabIndex = 0;
            this.gridDanhSachNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridDanhSachNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // UserNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridDanhSachNhanVien);
            this.Name = "UserNhanVien";
            this.Size = new System.Drawing.Size(553, 457);
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridDanhSachNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
