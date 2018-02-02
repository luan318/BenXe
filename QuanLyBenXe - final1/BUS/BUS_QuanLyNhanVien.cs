using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_QuanLyNhanVien
    {
        private static BUS_QuanLyNhanVien instance;

        public static BUS_QuanLyNhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_QuanLyNhanVien();
                return instance;
            }
        }

        QLBXDataContext db = new QLBXDataContext();

        //1.load nhóm người dùng
        public List<NhomNguoiDung> load_NhomNguoiDung()
        {
            return db.NhomNguoiDungs.ToList();
        }

        //2. load nhan vien theo nhom
        public List<NhanVien> load_NhanVienTheoNhom(int idNhom)
        {
            return db.pro_show_DanhSachNguoiDung_TheoNhom(idNhom).ToList();
        }

        //3. load nhan vien khong theo nhom
        public List<NhanVien> load_NhanVienKhongTheoNhom(int idNhom)
        {
            return db.pro_show_DanhSachNguoiDung_DK(idNhom).ToList();
        }

        //4. Them Nguoi Dùng Vào Nhóm
        public bool insert_PhanQuyenNguoiDung(int IdNguoiDung, int IdNhom)
        {
            db.pro_insert_PhanQuyenNguoiung(IdNguoiDung, IdNhom);
            return true;
        }

        //5. Xoa nguoi dung khỏi nhóm
        public bool delete_PhanQuyenNguoiDung(int IdNguoiDung, int IdNhom)
        {
            db.pro_delete_PhanQuyenNguoiDung(IdNguoiDung, IdNhom);
            return true;
        }
        //6


    }
}

