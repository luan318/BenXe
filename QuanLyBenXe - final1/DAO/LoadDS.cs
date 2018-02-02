using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class LoadDS
    {
        public DataTable LoadDSNhanVien()
        {
            string query = "select TenDN as 'Tên nhân viên', MatKhau as 'Mật khẩu' from dbo.NhanVien";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result;
            //gridDanhSachNhanVien.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
        public DataTable loadxe()
        {
            string q = "select * from Xe";
            DataTable r = DataProvider.Instance.ExcuteQuery(q);
            return r;
        }
        public DataTable hotro()
        {
            string q = "select COUNT(TenChoNgoi)*GiaVe from TuyenXe,ChuyenXe,ChoNgoi where TuyenXe.IdTuyen=ChuyenXe.IdTuyen and ChuyenXe.IdChuyen=ChoNgoi.IdChuyen group by TenChoNgoi,GiaVe";
            DataTable r = DataProvider.Instance.ExcuteQuery(q);
            return r;
        }
        public DataTable hotro1(string a)
        {
            string q = "select COUNT(TenChoNgoi)*GiaVe from TuyenXe,ChuyenXe,ChoNgoi where TuyenXe.IdTuyen=ChuyenXe.IdTuyen and ChuyenXe.IdChuyen=ChoNgoi.IdChuyen and NgayDi='"+a+"' group by TenChoNgoi,GiaVe";
            DataTable r = DataProvider.Instance.ExcuteQuery(q);
            return r;
        }
        public DataTable loadcaigido()
        {
            string q = "select  ChuyenXe.IdChuyen,TenTuyen,NgayDi,COUNT(ChoNgoi.TenChoNgoi) as 'Số vé đã bán',COUNT(ChoNgoi.TenChoNgoi)*TuyenXe.GiaVe as 'Thành tiền' from ChuyenXe,ChoNgoi,TuyenXe  where ChuyenXe.IdChuyen=ChoNgoi.IdChuyen and TuyenXe.IdTuyen=ChuyenXe.IdTuyen group by ChuyenXe.IdChuyen,TuyenXe.GiaVe,TenTuyen,NgayDi";
            DataTable r = DataProvider.Instance.ExcuteQuery(q);
            return r;
        }
        public DataTable loadthongke(string a)
        {
            string q = "select  ChuyenXe.IdChuyen,TenTuyen,NgayDi,COUNT(ChoNgoi.TenChoNgoi) as 'Số vé đã bán',COUNT(ChoNgoi.TenChoNgoi)*TuyenXe.GiaVe as 'Thành tiền' from ChuyenXe,ChoNgoi,TuyenXe  where ChuyenXe.IdChuyen=ChoNgoi.IdChuyen and TuyenXe.IdTuyen=ChuyenXe.IdTuyen and ngaydi='"+a+"' group by ChuyenXe.IdChuyen,TuyenXe.GiaVe,TenTuyen,NgayDi";
            DataTable r = DataProvider.Instance.ExcuteQuery(q);
            return r;
        }
        public DataTable loadidchuyen()
        {
            string q = "select * from ChuyenXe";
            DataTable r = DataProvider.Instance.ExcuteQuery(q);
            return r;
        }
        public DataTable LoadTuyenXe()
        {
            string quyeru = "select * from TuyenXe";
            DataTable re = DataProvider.Instance.ExcuteQuery(quyeru);
            return re;
        }
        public int laysoxe(string abc)
        {
            string query = ("select So_Cho_Ngoi from Xe where So_Xe=(select so_xe from ChuyenXe where IdChuyen='" + abc + "')");
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return int.Parse(data.Rows[0].ItemArray[0].ToString());
        }
        public DataTable LoadKhach()
        {
            //string q = "select TenTuyen,TenHanhKhach,SDTHanhKhach,NgayDi,Gio from BanVe,ChuyenXe,TuyenXe where BanVe.IdChuyen=ChuyenXe.IdChuyen and TuyenXe.IdTuyen=ChuyenXe.IdTuyen";
            string q = "select TuyenXe.TenTuyen as 'Tuyến Xe',TenHanhKhach as 'Tên khách',SDTHanhKhach as 'SĐT',NgayDi as 'Ngày đi',Gio as 'Giờ',COUNT(TenChoNgoi) as N'Số vé đã mua',COUNT(TenChoNgoi)*TuyenXe.GiaVe as N'Thành tiền' from BanVe,ChoNgoi,ChuyenXe,TuyenXe where BanVe.IdVe=ChoNgoi.idve and ChoNgoi.IdChuyen=ChuyenXe.IdChuyen and ChuyenXe.IdTuyen=TuyenXe.IdTuyen group by TenHanhKhach,TuyenXe.GiaVe,TuyenXe.TenTuyen,SDTHanhKhach,NgayDi,Gio";
            DataTable data = DataProvider.Instance.ExcuteQuery(q);
            return data;
        }
        public DataTable LoadDSXe()
        {
            string query = "select So_Xe as 'Biển kiểm soát', Hieu_Xe as 'Hiệu xe', Doi_Xe as 'Năm sản xuất', So_Cho_Ngoi as 'Số chỗ ngồi' from dbo.Xe";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result;
        }
        public DataTable LoadChuyen()
        {
            string query = "select IdChuyen as 'Mã Chuyến', TenTuyen as 'Tuyến Xe',NgayDi as 'Ngày Đi',Gio as 'Giờ',So_Xe as 'Biển kiểm soát' from TuyenXe,ChuyenXe where TuyenXe.IdTuyen=ChuyenXe.IdTuyen";
            DataTable resutl = DataProvider.Instance.ExcuteQuery(query);
            return resutl;
        }
        #region
        public void loadsodoxe(Control ctr)
        {
            //int x = 50, y = 50;
            //   int x=0;
            //List<Xe> Xelist = Taoxe.Instance.loadxe();
            //Button cubtn = new Button() { Width = 0, Location = new Point(0, 0) };
            //foreach (Xe item in Xelist)
            //{

            //    Button btn = new Button() { Width = 100, Height = 100, Location = new Point(cubtn.Location.X + cubtn.Width, cubtn.Location.Y) };
            //    btn.Text = item.So_Xe;
            //    btn.Click += btn_Click;
            //    ctr.Controls.Add(btn);

            //    cubtn = btn;

            //}
        }
        public DataTable layidve(string idchuyen,string tenhhk,string sdt)
        {
            string q = "select IdVe from BanVe where IdChuyen='"+idchuyen+"' and TenHanhKhach=N'"+tenhhk+"' and SDTHanhKhach = '"+sdt+"'";
            DataTable ad=DataProvider.Instance.ExcuteQuery(q);
            
            return ad;
           
        }


        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Text = "da xhon";
        }
        #endregion

        #region load xe
        public DataTable LoadDsTuyen()
        {
            string quyry = "select TenTuyen,IdTuyen from TuyenXe";
            //string quyry = "select ChuyenXe.IdTuyen,TuyenXe.TenTuyen from TuyenXe,ChuyenXe where TuyenXe.IdTuyen=ChuyenXe.IdTuyen";
            DataTable result = DataProvider.Instance.ExcuteQuery(quyry);
            return result;
        }

        public DataTable LoadTimChuyen(string a)
        {
          //  string quyry = "select TenTuyen,Ngay,ThoiDiem.Gio,ChiTietTuyen.IdTuyen from ChiTietTuyen,ThoiDiem,TuyenXe where ChiTietTuyen.IdThoiDiem=ThoiDiem.IdThoiDiem and TuyenXe.IdTuyen=ChiTietTuyen.IdTuyen";
            string quyry = "select ChuyenXe.IdChuyen,TuyenXe.TenTuyen,So_Xe,NgayDi,Gio,GiaVe from TuyenXe,ChuyenXe where TuyenXe.IdTuyen=ChuyenXe.IdTuyen and NgayDi>'"+a+"'";
            DataTable result = DataProvider.Instance.ExcuteQuery(quyry);
            return result;
        }
        //public DataTable LoadDk(string a)
        //{
        //    string query = "select TenTuyen,Ngay,ThoiDiem.Gio from ChiTietTuyen,ThoiDiem,TuyenXe where ChiTietTuyen.IdThoiDiem=ThoiDiem.IdThoiDiem and TuyenXe.IdTuyen=ChiTietTuyen.IdTuyen and TuyenXe.TenTuyen LIKE N'%" + a + "%'";
        //    //string query = "SELECT * FROM TuyenXe WHERE TenTuyen LIKE N'%" + a + "%'";
        //    DataTable result = DataProvider.Instance.ExcuteQuery(query);
        //    return result;
        //}
        //public DataTable LoadDKngay(string a)
        //{
        //    string query = "select TenTuyen,Ngay,ThoiDiem.Gio from ChiTietTuyen,ThoiDiem,TuyenXe where ChiTietTuyen.IdThoiDiem=ThoiDiem.IdThoiDiem and TuyenXe.IdTuyen=ChiTietTuyen.IdTuyen and convert(datetime,Ngay,21) = convert(datetime,'"+a+"',21) ";
        //    DataTable Result = DataProvider.Instance.ExcuteQuery(query);
        //    return Result;
        //}
        public DataTable LoadDKngayvachuyen(string a,string b)
        {
            //string query = "select TenTuyen,Ngay,ThoiDiem.Gio from ChiTietTuyen,ThoiDiem,TuyenXe where ChiTietTuyen.IdThoiDiem=ThoiDiem.IdThoiDiem and TuyenXe.IdTuyen=ChiTietTuyen.IdTuyen and (convert(datetime,Ngay,21) = convert(datetime,'" + a + "',21) or TuyenXe.TenTuyen LIKE N'%" + b + "%')";
            string query = "select IdChuyen,TenTuyen,So_Xe,NgayDi,Gio from TuyenXe,ChuyenXe where TuyenXe.IdTuyen=ChuyenXe.IdTuyen and (convert(datetime,NgayDi,21) = convert(datetime,'" + a + "',21)  or TuyenXe.TenTuyen LIKE N'" + b + "')";
            DataTable Result = DataProvider.Instance.ExcuteQuery(query);
            return Result;
        }
        public DataTable loadhanhkhachdk(string a)
        {
            //string q = "select TenTuyen,TenHanhKhach,SDTHanhKhach,NgayDi,Gio from BanVe,ChuyenXe,TuyenXe where (BanVe.IdChuyen=ChuyenXe.IdChuyen and TuyenXe.IdTuyen=ChuyenXe.IdTuyen)  and SDTHanhKhach like '%"+a+"%'";
            string q = "select TuyenXe.TenTuyen as 'Tuyến Xe',TenHanhKhach as 'Tên khách',SDTHanhKhach as 'SĐT',NgayDi as 'Ngày đi',Gio as 'Giờ',COUNT(TenChoNgoi) as N'Số vé đã mua',COUNT(TenChoNgoi)*TuyenXe.GiaVe as N'Thành tiền' from BanVe,ChoNgoi,ChuyenXe,TuyenXe where BanVe.IdVe=ChoNgoi.idve and ChoNgoi.IdChuyen=ChuyenXe.IdChuyen and ChuyenXe.IdTuyen=TuyenXe.IdTuyen and SDTHanhKhach like '%"+a+"%' group by TenHanhKhach,TuyenXe.GiaVe,TuyenXe.TenTuyen,SDTHanhKhach,NgayDi,Gio";
            DataTable res = DataProvider.Instance.ExcuteQuery(q);
            return res;
        }

        public DataTable LoadKhach1()
        {
            //string q = "select TenTuyen,TenHanhKhach,SDTHanhKhach,NgayDi,Gio from BanVe,ChuyenXe,TuyenXe where BanVe.IdChuyen=ChuyenXe.IdChuyen and TuyenXe.IdTuyen=ChuyenXe.IdTuyen";
            string q = "select BanVe.IdVe,TuyenXe.TenTuyen as 'Tuyến Xe',TenHanhKhach,SDTHanhKhach as 'SĐT',COUNT(TenChoNgoi) as N'Số vé đã mua',COUNT(TenChoNgoi)*TuyenXe.GiaVe as N'Thành tiền' from BanVe,ChoNgoi,ChuyenXe,TuyenXe where BanVe.IdVe=ChoNgoi.idve and ChoNgoi.IdChuyen=ChuyenXe.IdChuyen and ChuyenXe.IdTuyen=TuyenXe.IdTuyen group by TenHanhKhach,TuyenXe.GiaVe,TuyenXe.TenTuyen,SDTHanhKhach,BanVe.IdVe";
            DataTable data = DataProvider.Instance.ExcuteQuery(q);
            return data;
        }
        public DataTable LoadTenChoNgoi(string a)
        {
            string q = "select TenChoNgoi from ChoNgoi,BanVe where ChoNgoi.IdVe=BanVe.IdVe and BanVe.IdVe='"+a+"'";
            DataTable r = DataProvider.Instance.ExcuteQuery(q);
            return r;
        }
       

        #endregion
    }
}
