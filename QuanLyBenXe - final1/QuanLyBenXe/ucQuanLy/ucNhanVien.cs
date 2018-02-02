using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace QuanLyBenXe
{
    public partial class ucNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        BindingSource BdS_NV = new BindingSource();
        public ucNhanVien()
        {
            InitializeComponent();
        }
        
        private void ucNhanVien_Load(object sender, EventArgs e)
        {
           
            load_NhanVien();

            gv_NhanVien.Columns[0].Caption = "Id Nhân Viên";
            gv_NhanVien.Columns[1].Caption = "Tài Khoảng";
            gv_NhanVien.Columns[2].Visible = false;
            gv_NhanVien.Columns[3].Caption = "Hoạt Động";

            gv_NhanVien.OptionsDetail.EnableMasterViewMode = false;
            gv_NhanVien.OptionsBehavior.Editable = false;
            binding_NhanVien();
            even();
           
        }
        
        //Even
        public void even()
        {
            btn_Them.Click += new EventHandler(btn_Them_Click);
            btn_Xoa.Click += new EventHandler(btn_Xoa_Click);
            btn_Sua.Click += new EventHandler(btn_Sua_Click);
            btn_Reset.Click += new EventHandler(btn_Reset_Click);
        }


        //1. Binding thông tin từ GridView
        private void binding_NhanVien()
        {
                txtb_TenTaiKhoan.DataBindings.Add("Text", gc_NhanVien.DataSource, "TaiKhoan", true, DataSourceUpdateMode.Never);
                cb_HoatDong.DataBindings.Add("Checked", gc_NhanVien.DataSource, "HoatDong", true, DataSourceUpdateMode.Never);
        }

        //2. Load_NhanVien
        private void load_NhanVien()
        {
            BdS_NV.DataSource = BUS_NhanVien.Instance.load_NhanVien();
            gc_NhanVien.DataSource= BdS_NV;
        }

        //3. Thêm Nhân Viên
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txtb_TenTaiKhoan.Text;
            bool hd = cb_HoatDong.Checked == true ? true : false;
            if (BUS_NhanVien.Instance.check_KhoaChinh(TaiKhoan) == true)
            {
                BUS_NhanVien.Instance.insert_NhanVien(TaiKhoan, "1", hd);
                load_NhanVien();
            }
            else { XtraMessageBox.Show("Tài khoản đã tồn tại!"); }
        }

        //4. Xóa Nhân Viên
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gv_NhanVien.GetFocusedRowCellValue("id_nhan_vien").ToString());
            string TaiKhoan = gv_NhanVien.GetFocusedRowCellValue("TaiKhoan").ToString();
            if (TaiKhoan != frmLogin.taikhoang)
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa tài khoản " + TaiKhoan, "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS_NhanVien.Instance.check_RangBuoc(id);
                    BUS_NhanVien.Instance.detete_NhanVien(id);
                    XtraMessageBox.Show("Xóa Thành Công!", "Chúc Mừng :)");
                    load_NhanVien();
                }
            }
            else { XtraMessageBox.Show("Tài khoản đang sử dụng!"); }
        }

        //5. Sửa Nhân Viên
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            bool HoatDong;
            if (cb_HoatDong.Checked == true)
                HoatDong = true;
            else HoatDong = false;
            int id = int.Parse(gv_NhanVien.GetFocusedRowCellValue("id_nhan_vien").ToString());
            if (BUS_NhanVien.Instance.update_NhanVien(id, HoatDong) == true)
                XtraMessageBox.Show("Sửa thành công!", "Chúc Mừng :)");
            load_NhanVien();
        }

        //6. Reset Mật Khẩu Về Mặc Định
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gv_NhanVien.GetFocusedRowCellValue("id_nhan_vien").ToString());
            if (BUS_NhanVien.Instance.reset_pass_NhanVien(id, "1") == true)
                frmLogin.matkhau = "1";
                XtraMessageBox.Show("Reset thành công!", "Chúc Mừng :)");
        }

        private void loaitaikhoan(int IdNhanVien)
        {
             //dataGridView1.DataSource = BUS_NhanVien.Instance.check_LoaiTaiKhoan(1);
             List<string> x = BUS_NhanVien.Instance.check_LoaiTaiKhoan(IdNhanVien);
             foreach (string l in x)
             {
                 label1.Text += l + " ";
             }
        }

        private void gv_NhanVien_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int id = int.Parse(gv_NhanVien.GetFocusedRowCellValue("id_nhan_vien").ToString());
            label1.Text="Quyen: ";
            loaitaikhoan(id);
        }

    }
}
