using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_QuanLyNhom
    {
        private static BUS_QuanLyNhom instance;

        public static BUS_QuanLyNhom Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_QuanLyNhom();
                return instance;
            }
        }

        QLBXDataContext db = new QLBXDataContext();

        //1. load phan quyen
        public object load_PhanQuyen(int idNhom)
        {
            var mm = db.pro_show_PhanQuyen(idNhom);
            return mm;
        }


        //2. update quyen
        public bool update_Quyen(int idNhom, int idManHinh, bool Quyen)
        {
            PhanQuyenNhom pqn = db.PhanQuyenNhoms.Single(p => p.id_nhom_nguoi_dung == idNhom && p.id_man_hinh == idManHinh);
            pqn.quyen = Quyen;
            db.SubmitChanges();
            return true;
        }
    }
}
