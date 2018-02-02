using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_NhomNguoiDung
    {
        private static BUS_NhomNguoiDung instance;

        public static BUS_NhomNguoiDung Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_NhomNguoiDung();
                return instance;
            }
        }

        QLBXDataContext db = new QLBXDataContext();

        //1. Load Danh Sách Nhóm Người Dùng
        public List<NhomNguoiDung> load_NhomNguoiDung()
        {
            return db.NhomNguoiDungs.ToList();
        }

        //2. Thêm Nhóm Người Dùng
        public bool insert_NhomNguoiDung(string TenNhom)
        {
            NhomNguoiDung nnd = new NhomNguoiDung();
            nnd.ten_nhom_nguoi_dung = TenNhom;

            db.NhomNguoiDungs.InsertOnSubmit(nnd);
            db.SubmitChanges();
            return true;
        }

        //2.1 Them Phan Quyen Nhom Moi
        public bool insert_PhanQuyenNhom(int idNhom)
        {
            db.pro_ThemPhanQuyenNhom(idNhom);
            return true;
        }

        //2.2 Kiem Tra Khoa Chinh
        public bool check_KhoaChinh(string TenNhom)
        {
            return (db.NhomNguoiDungs.Where(p => p.ten_nhom_nguoi_dung == TenNhom).FirstOrDefault() == null) ? true : false;
        }

        //2.3 Tim idNhom
        public int find_IdNhom(string TenNhom)
        {
            var x = db.NhomNguoiDungs.Single(p => p.ten_nhom_nguoi_dung == TenNhom);
            return x.id_nhom_nguoi_dung;
        }

        //3. Xóa Nhóm Người Dùng
        public bool delete_NhomNguoiDung(int idNhom)
        {
            NhomNguoiDung nnd = db.NhomNguoiDungs.Single(p => p.id_nhom_nguoi_dung == idNhom);
            db.NhomNguoiDungs.DeleteOnSubmit(nnd);
            db.SubmitChanges();
            return true;
        }

        //4. Sua Nhom
        public bool update_NhomNguoiDung(int idNhom, string TenNhom)
        {
            NhomNguoiDung nnd = db.NhomNguoiDungs.Single(p => p.id_nhom_nguoi_dung == idNhom);
            nnd.ten_nhom_nguoi_dung = TenNhom;

            db.SubmitChanges();
            return true;
        }

        //3.1 Xóa Ràng Buộc
        #region rang buoc
        //Kiem Tra Ràng Buộc
        public bool check_RangBuoc(int idNhom)
        {
            var pqn = db.PhanQuyenNhoms.Where(p => p.id_nhom_nguoi_dung == idNhom);
            var pqnd = db.PhanQuyenNguoiDungs.Where(p => p.id_nhom_nguoi_dung == idNhom);
            if (pqn != null)
                delete_PhanQuyenNhom(idNhom);
            if (pqnd != null)
                delete_PhanQuyenNguoiDung(idNhom);
            return true;
        }

        //Xóa Phân Quyền Nhóm
        public bool delete_PhanQuyenNhom(int idNhom)
        {
            var pqn = db.PhanQuyenNhoms.Where(p => p.id_nhom_nguoi_dung == idNhom);
            db.PhanQuyenNhoms.DeleteAllOnSubmit(pqn);
            db.SubmitChanges();
            return true;
        }
        //Xóa Phân Quyền Người Dùng
        public bool delete_PhanQuyenNguoiDung(int idNhom)
        {
            var pqnd = db.PhanQuyenNguoiDungs.Where(p => p.id_nhom_nguoi_dung == idNhom);
            db.PhanQuyenNguoiDungs.DeleteAllOnSubmit(pqnd);
            db.SubmitChanges();
            return true;
        }
        #endregion



        //Sửa Thông Tin Nhóm Người Dùng

        //

    }
}
