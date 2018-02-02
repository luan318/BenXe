using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using DevExpress.XtraBars.Helpers;

namespace QuanLyBenXe
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            TsL_TaiKhoan.Text = "Chào " + frmLogin.taikhoang;
            SkinHelper.InitSkinPopupMenu(SkinsLink);
            disable();
            kiemtraquyen();
        }

        private void disable()
        {
            navBarGroup_GioiThieu.Visible = false;
            navBarGroup_QuanLyKhachHang.Visible = false;
            navBarGroup_DatVe.Visible = false;
            navBarGroup_QuanLyChuyenXe.Visible = false;
            navBarGroup_QuanLyNhanVien.Visible = false;
            navBarGroup_ThongKe.Visible = false;
        }
        public void kiemtraquyen()
        {
            using (QLBXDataContext db = new QLBXDataContext())
            {
                var kt = db.pro_KiemTraQuyen(frmLogin.taikhoang);
                foreach (var i in kt)
                {
                    int key = i.id_man_hinh;
                    switch (key)
                    {
                        case 1:
                            navBarGroup_GioiThieu.Visible = true;
                            break;
                        case 2:
                            navBarGroup_QuanLyKhachHang.Visible = true;
                            break;
                        case 3:
                            navBarGroup_DatVe.Visible = true;
                            break;
                        case 4:
                            navBarGroup_QuanLyChuyenXe.Visible = true;
                            break;
                        case 5:
                            navBarGroup_QuanLyNhanVien.Visible = true;
                            break;
                        case 6:
                            navBarGroup_ThongKe.Visible = true;
                            break;
                    }
                }
            }
        }

        #region Tí BD
        private void click1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucKhacHang uchk = new ucKhacHang();
            uchk.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uchk);
        }
        void loadsodoxe()
        {
            List<Xe> Xelist= Taoxe.Instance.loadxe();
            foreach(Xe item in Xelist)
            {

                Button btn = new Button() { Width = 50, Height = 50 };


            }
        }

        

       // private void loadS

        private void QLxe(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //panelControl1.Controls.Clear();
            //DSChiecXe dsxe = new DSChiecXe();
            //dsxe.Dock = DockStyle.Fill;
            //panelControl1.Controls.Add(dsxe);
            panelControl1.Controls.Clear();
            DSSoDoChuyenXe ds = new DSSoDoChuyenXe();
            ds.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(ds);

        }

        private void DSchuyen(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            DSChuyen dschuyen = new DSChuyen();
            dschuyen.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(dschuyen);
        }

        private void dsChuyen(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
          
        }

        private void Timxe(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            DatVeXe a = new DatVeXe();
            a.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(a);
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            QuanLyTuyen a = new QuanLyTuyen();
            a.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(a);
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            Thongke a = new Thongke();
            a.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(a);
        }
        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            doive a = new doive();
            a.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(a);
        }

        #endregion



        //TL
        #region Quản lý nhân viên, phân quyền
        private void navBarItem_DanhSachNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
           ucNhanVien a= new ucNhanVien();
            a.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(a);
        }


        private void navBarItem_QuanLyNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucQuanLyNhanVien a = new ucQuanLyNhanVien();
            a.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(a);
        }

        private void navBarItem_QuanLyNhom_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucQuanLyNhom a = new ucQuanLyNhom();
            a.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(a);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucDoiMatKhau a = new ucDoiMatKhau();
            a.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(a);
        }

        #endregion

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }


    }
}
