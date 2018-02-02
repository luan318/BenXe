using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_NhanVien
    {

        private static BUS_NhanVien instance;
        public static BUS_NhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_NhanVien();
                return instance;
            }
        }

        QLBXDataContext db = new QLBXDataContext();




        //1. Hàm Load Danh Sách Toàn Bộ Nhân Viên.
        public List<NhanVien> load_NhanVien()
        {
            return db.NhanViens.ToList();
        }

        //2. Hàm Thêm Nhân Viên.
        public bool insert_NhanVien(string TaiKhoan, string MatKhau, bool HoatDong)
        {
            NhanVien nv = new NhanVien();
            nv.TaiKhoan = TaiKhoan;
            nv.MatKhau = MatKhau;
            nv.HoatDong = HoatDong;

            db.NhanViens.InsertOnSubmit(nv);
            db.SubmitChanges();
            return true;
        }

        //2.2 Kiem Tra Khoa Chinh
        public bool check_KhoaChinh(string TaiKhoan)
        {
            return (db.NhanViens.Where(p => p.TaiKhoan == TaiKhoan).FirstOrDefault() == null) ? true : false;
        }

        //3. Hàm Xóa Nhân Viên.
        public bool detete_NhanVien(int id_nhan_vien)
        {
            var nv = db.NhanViens.Where(p => p.id_nhan_vien == id_nhan_vien).Single();
            db.NhanViens.DeleteOnSubmit(nv);
            db.SubmitChanges();
            return true;
        }

        //3.1 rang buoc
        #region rang buoc
        //Kiem Tra Ràng Buộc
        public bool check_RangBuoc(int idNhanVien)
        {
            var pqnd = db.PhanQuyenNguoiDungs.Where(p => p.id_nhan_vien == idNhanVien);
            if (pqnd != null)
                delete_PhanQuyenNguoiDung(idNhanVien);
                return true;
        }
       
        #endregion

        //4. Hàm Xóa Phân Quyền Nhân Viên
        public bool delete_PhanQuyenNguoiDung(int id_nhan_vien)
        {
            var pq = db.PhanQuyenNguoiDungs.Where(p => p.id_nhan_vien == id_nhan_vien);
            db.PhanQuyenNguoiDungs.DeleteAllOnSubmit(pq);
            db.SubmitChanges();
            return true;
        }

        //5. Hàm Sửa Thông Tin Hoạt Động Nhân Viên.
        public bool update_NhanVien(int id_nhan_vien, bool HoatDong)
        {
            NhanVien nv = db.NhanViens.Single(p => p.id_nhan_vien == id_nhan_vien);
            nv.HoatDong = HoatDong;

            db.SubmitChanges();
            return true;
        }

        //6. Ham Doi Mat Khau Nhan Vien
        public bool update_pass_NhanVien(string TaiKhoan, string MatKhau)
        {
            NhanVien nv = db.NhanViens.Single(p => p.TaiKhoan == TaiKhoan);
            nv.MatKhau = MatKhau;

            db.SubmitChanges();
            return true;
        }

        //7. Hàm Reset Mật Khẩu Nhân Viên.
        public bool reset_pass_NhanVien(int id_nhan_vien, string MatKhau)
        {
            NhanVien nv = db.NhanViens.Single(p => p.id_nhan_vien == id_nhan_vien);

            nv.MatKhau = MatKhau;

            db.SubmitChanges();
            return true;
        }

        //8. Kiem tra loai tai khoan
        public List<string> check_LoaiTaiKhoan(int idNhanVien)
        {
                var v = (from l in db.NhomNguoiDungs
                        from t in db.PhanQuyenNguoiDungs
                        where t.id_nhan_vien == idNhanVien && l.id_nhom_nguoi_dung == t.id_nhom_nguoi_dung
                        select l.ten_nhom_nguoi_dung).ToList();
            return v;
        }
    }
}
