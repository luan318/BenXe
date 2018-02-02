using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class BUS_DangNhap
    {
        private static BUS_DangNhap instance;

        public static BUS_DangNhap Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_DangNhap();
                return instance;
            }
        }

        QLBXDataContext db = new QLBXDataContext();

        //1. Kiểm tra đăng nhập
        public int KiemTraDangNhap(string TaiKhoan, string MatKhau)
        {
            var nv = db.pro_KiemTraDangNhap(TaiKhoan, MatKhau).FirstOrDefault();
            if (nv != null)
            {
                if (nv.HoatDong == true)
                    return 1; //Tài khoan, mat khau hop le.
                return 0;//Tài khoan bi khoa.
            }
            return -1;//sai ten tai khoan hoac mat khau.
        }


        //2. kiem tra quyen
        public object KiemTraQuyen(string TaiKhoan)
        {
            var l = db.pro_KiemTraQuyen(TaiKhoan);
            return l;
        }
    }
}
