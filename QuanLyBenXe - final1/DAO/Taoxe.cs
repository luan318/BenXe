using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Taoxe
    {
        private static Taoxe instance;

        public static Taoxe Instance
        {
            get { if (instance == null)instance = new Taoxe(); return Taoxe.instance; }
            private set { Taoxe.instance = value; }
        }
        private Taoxe() { }

        public List<Xe> loadxe()
        {
            List<Xe> xelist = new List<Xe>();

            DataTable data = DataProvider.Instance.ExcuteQuery("dbo.USP_DSXe");

            //DataTable data = DataProvider.Instance.ExcuteQuery("select So_Xe,TenTuyen as 'Tuyến Xe',COUNT(BanVe.IdChuyen) as N'Số vé đã đặt' from BanVe,TuyenXe,ChuyenXe where TuyenXe.IdTuyen=ChuyenXe.IdTuyen and BanVe.IdChuyen=ChuyenXe.IdChuyen group by TenTuyen,NgayDi,Gio,So_Xe");

            foreach (DataRow item in data.Rows)
            {
                Xe xe = new Xe(item);
                xelist.Add(xe);
            }

            return xelist;
        }
    }
}
