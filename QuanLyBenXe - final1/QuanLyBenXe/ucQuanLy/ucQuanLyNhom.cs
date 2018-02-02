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
using DAO;
namespace QuanLyBenXe
{
    public partial class ucQuanLyNhom : DevExpress.XtraEditors.XtraUserControl
    {
        BindingSource BdS_N = new BindingSource();
        public ucQuanLyNhom()
        {
            InitializeComponent();
        }

        private void ucQuanLyNhom_Load(object sender, EventArgs e)
        {
            load_Nhom();
            load_PhanQuyen(1);
            
            binding_Nhom();
            UI();
            even();

        }
        public void even()
        {
            btn_Luu.Click += new EventHandler(btn_Luu_Click);
            btn_Reload.Click += new EventHandler(btn_Reload_Click);

            //gv_NhomNguoiDung.RowClick += new EventHandler(gv_NhomNguoiDung_RowClick);
        }


    private void UI()
        {
            gv_NhomNguoiDung.OptionsBehavior.Editable = false;
            //gv_PhanQuyen.Columns[0].OptionsColumn.AllowEdit = false;
            //gv_PhanQuyen.Columns[1].OptionsColumn.ReadOnly = true;
            //gv_PhanQuyen.OptionsBehavior.Editable = false;
            gv_PhanQuyen.Columns[0].Visible = false;
            gv_PhanQuyen.Columns[2].Visible = false;
            gv_PhanQuyen.Columns[1].OptionsColumn.AllowEdit = false;
            gv_PhanQuyen.Columns[3].OptionsColumn.AllowEdit = false;
        }

        //1. load nhom  nguoi dung
        private void load_Nhom()
        {
            BdS_N.DataSource = BUS_NhomNguoiDung.Instance.load_NhomNguoiDung();
            gc_NhomNguoiDung.DataSource = BdS_N;
        }
        
        //2. Load Phan QUyen
        private void load_PhanQuyen(int IdNhom)
        {
            gc_PhanQuyen.DataSource = BUS_QuanLyNhom.Instance.load_PhanQuyen(IdNhom);
            gv_PhanQuyen.Columns["ten_nhom_nguoi_dung"].Visible = false;

        }

        //3. Row Click Nhom ngu0i dung
        private void gv_NhomNguoiDung_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int idNhom = int.Parse(gv_NhomNguoiDung.GetFocusedRowCellValue("id_nhom_nguoi_dung").ToString());
            load_PhanQuyen(idNhom);
        }


        //4. Button Luu
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < this.gv_PhanQuyen.RowCount; j++)
            {
                    try
                    {
                        bool x = Convert.ToBoolean(gv_PhanQuyen.GetRowCellValue(j, "quyen"));
                        int idNhom = int.Parse(gv_PhanQuyen.GetRowCellValue(j,"id_nhom_nguoi_dung").ToString());
                        int idManHinh = int.Parse(gv_PhanQuyen.GetRowCellValue(j,"id_man_hinh").ToString());
                        BUS_QuanLyNhom.Instance.update_Quyen(idNhom, idManHinh, x);
                    }
                    catch { XtraMessageBox.Show("Lưu k thành công!", "Chúc Mừng :)"); }
            }
            XtraMessageBox.Show("Lưu thành công!", "Chúc Mừng :)");
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            gv_NhomNguoiDung_RowClick(sender,null);
        }

        //5. Binding Thông Tin
        private void binding_Nhom()
        {
            txtb_IdNom.DataBindings.Add("Text", gc_NhomNguoiDung.DataSource, "id_nhom_nguoi_dung", true, DataSourceUpdateMode.Never);
            txtb_TenNhom.DataBindings.Add("Text", gc_NhomNguoiDung.DataSource, "ten_nhom_nguoi_dung", true, DataSourceUpdateMode.Never);
        }

        //6. Thêm Nhóm Người Dùng
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string TenNhom = txtb_TenNhom.Text;
            if (BUS_NhomNguoiDung.Instance.check_KhoaChinh(TenNhom) == true)
            {
                BUS_NhomNguoiDung.Instance.insert_NhomNguoiDung(TenNhom);
                int x = BUS_NhomNguoiDung.Instance.find_IdNhom(TenNhom);
                BUS_NhomNguoiDung.Instance.insert_PhanQuyenNhom(x);
                load_Nhom();
            }
            else XtraMessageBox.Show("Nhóm Đã Tồn Tại", "Thông Báo");
        }

        //7. Xóa Nhóm Người Dùng
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(gv_NhomNguoiDung.GetFocusedRowCellValue("id_nhom_nguoi_dung").ToString());
            string TenNhom = gv_NhomNguoiDung.GetFocusedRowCellValue("ten_nhom_nguoi_dung").ToString();
            if (XtraMessageBox.Show("Bạn có muốn xóa nhóm người dùng: " + TenNhom, "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes&&TenNhom!="Admin")
            {
                BUS_NhomNguoiDung.Instance.check_RangBuoc(Id);
                BUS_NhomNguoiDung.Instance.delete_NhomNguoiDung(Id);
                XtraMessageBox.Show("Xóa Thành Công!", "Chúc Mừng :)");
                load_Nhom();
            }
        }

        //8. Sửa Nhóm Người Dùng
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(gv_NhomNguoiDung.GetFocusedRowCellValue("id_nhom_nguoi_dung").ToString());
            string TenNhom = txtb_TenNhom.Text;
            BUS_NhomNguoiDung.Instance.update_NhomNguoiDung(Id, TenNhom);
            load_Nhom();
        }

    }
}
