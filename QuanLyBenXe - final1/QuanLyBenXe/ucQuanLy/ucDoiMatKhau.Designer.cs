namespace QuanLyBenXe
{
    partial class ucDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDoiMatKhau));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtb_MatKhauMoi2 = new DevExpress.XtraEditors.TextEdit();
            this.txtb_MatKhauMoi1 = new DevExpress.XtraEditors.TextEdit();
            this.txtb_MatKhauCu = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_MatKhauMoi2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_MatKhauMoi1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_MatKhauCu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_DoiMatKhau);
            this.panelControl1.Controls.Add(this.txtb_MatKhauMoi2);
            this.panelControl1.Controls.Add(this.txtb_MatKhauMoi1);
            this.panelControl1.Controls.Add(this.txtb_MatKhauCu);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(689, 372);
            this.panelControl1.TabIndex = 0;
            // 
            // txtb_MatKhauMoi2
            // 
            this.txtb_MatKhauMoi2.Location = new System.Drawing.Point(257, 131);
            this.txtb_MatKhauMoi2.Name = "txtb_MatKhauMoi2";
            this.txtb_MatKhauMoi2.Properties.PasswordChar = '*';
            this.txtb_MatKhauMoi2.Size = new System.Drawing.Size(205, 20);
            this.txtb_MatKhauMoi2.TabIndex = 3;
            // 
            // txtb_MatKhauMoi1
            // 
            this.txtb_MatKhauMoi1.Location = new System.Drawing.Point(257, 95);
            this.txtb_MatKhauMoi1.Name = "txtb_MatKhauMoi1";
            this.txtb_MatKhauMoi1.Properties.PasswordChar = '*';
            this.txtb_MatKhauMoi1.Size = new System.Drawing.Size(205, 20);
            this.txtb_MatKhauMoi1.TabIndex = 2;
            // 
            // txtb_MatKhauCu
            // 
            this.txtb_MatKhauCu.Location = new System.Drawing.Point(257, 59);
            this.txtb_MatKhauCu.Name = "txtb_MatKhauCu";
            this.txtb_MatKhauCu.Properties.PasswordChar = '*';
            this.txtb_MatKhauCu.Size = new System.Drawing.Size(205, 20);
            this.txtb_MatKhauCu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(75, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(75, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(75, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu cũ";
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btn_DoiMatKhau.Image")));
            this.btn_DoiMatKhau.Location = new System.Drawing.Point(278, 194);
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.Size = new System.Drawing.Size(113, 41);
            this.btn_DoiMatKhau.TabIndex = 4;
            this.btn_DoiMatKhau.Text = "Lưu";
            // 
            // ucDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucDoiMatKhau";
            this.Size = new System.Drawing.Size(689, 372);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_MatKhauMoi2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_MatKhauMoi1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_MatKhauCu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_DoiMatKhau;
        private DevExpress.XtraEditors.TextEdit txtb_MatKhauMoi2;
        private DevExpress.XtraEditors.TextEdit txtb_MatKhauMoi1;
        private DevExpress.XtraEditors.TextEdit txtb_MatKhauCu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
