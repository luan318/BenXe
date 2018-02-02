using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TXS_QLBX
    {
        public bool deleteKhach(string a, string b)
        {
            string q = "delete from ChoNgoi where IdVe='"+a+"' and TenChoNgoi='"+b+"'";
            int r = DataProvider.Instance.ExcuteNonQuery(q);
            return r > 0;
        }
        public bool insertVEXE(string a,string b,string c,string d)
        {
            string query = "Insert Into ChoNgoi(IdChuyen,So_Xe,TenChoNgoi,IdVe) Values('"+a+"', '"+b+"', '"+c+"','"+d+"')";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool insertKhach(string a,string b,string c)
        {
            string query = "Insert into BanVe(IdChuyen, TenHanhKhach, SDTHanhKhach) Values('"+a+"', N'"+b+"', '"+c+"')";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool insertTuyenXe(string a,string b,string c,int d)
        {
            string quyery = "insert into TuyenXe values('"+a+"',N'"+b+" - "+c+"', N'"+b+"', N'"+c+"',"+d+")";
            int result = DataProvider.Instance.ExcuteNonQuery(quyery);
            return result > 0;
        }
        public bool updateTuyenXe(string id,string dddi,string ddde,int giave)
        {
            string quyry = "update TuyenXe set TenTuyen=N'"+dddi+" - "+ddde+"',DiaDiemDi=N'"+dddi+"',DiaDiemDen=N'"+ddde+"',GiaVe="+giave+" where IdTuyen='"+id+"'";
            int re = DataProvider.Instance.ExcuteNonQuery(quyry);
            return re > 0;
        }
        public bool insertChuyenXe(string a,string b,string c,string d)
        {
            string q = "Insert into ChuyenXe(IdTuyen, So_Xe, NgayDi, Gio) Values('"+a+"', '"+b+"', '"+c+"', '"+d+"')";
            int re = DataProvider.Instance.ExcuteNonQuery(q);
            return re > 0;
        }
        public bool updatechuyenxe(string idtuyen,string soxe,string ngay,string gio,string idchuyen)
        {
            string q = "update ChuyenXe set IdTuyen='"+idtuyen+"',So_Xe='"+soxe+"',NgayDi='"+ngay+"',Gio='"+gio+"' where IdChuyen='"+idchuyen+"'";
            int r = DataProvider.Instance.ExcuteNonQuery(q);
            return r > 0;
        }
        public bool deletechuyenxe(string a)
        {
            string q = "delete from ChuyenXe where IdChuyen='"+a+"'";
            int r = DataProvider.Instance.ExcuteNonQuery(q);
            return r > 0;
        }
        public bool insertXe(string a, string b, string c, string d)
        {
            string q = "Insert into Xe(So_Xe, Hieu_Xe,Doi_Xe, So_Cho_Ngoi) Values('" + a + "', '" + b + "', '" + c + "', '" + d + "')";
            int re = DataProvider.Instance.ExcuteNonQuery(q);
            return re > 0;
        }
        public bool deletexe(string a)
        {
            string q = "delete from Xe where So_Xe='" + a + "'";
            int r = DataProvider.Instance.ExcuteNonQuery(q);
            return r > 0;
        }
        public bool deleteChuyen(string a)
        {
            string q1 = "delete from ChoNgoi where IdChuyen='"+a+"'";
            string q2 = "delete from banve where IdChuyen='"+a+"'";
            string q3 = "delete from ChuyenXe where IdChuyen='"+a+"'";
            int r1 = DataProvider.Instance.ExcuteNonQuery(q1);
            int r2 = DataProvider.Instance.ExcuteNonQuery(q2);
            int r3 = DataProvider.Instance.ExcuteNonQuery(q3);
            if (r1 > 0 && r2 > 0 && r3 > 0) return true;
            return false;
        }
        public bool deletetuyen(string a)
        {
            string q = "delete from TuyenXe where IdTuyen='"+a+"'";
            int r = DataProvider.Instance.ExcuteNonQuery(q);
            return r > 0;
        }
    }
}
