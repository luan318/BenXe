using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DAO;

namespace QuanLyBenXe
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static string taikhoang;
        public static string matkhau;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            int kt = BUS_DangNhap.Instance.KiemTraDangNhap(txtb_TaiKhoan.Text, txtb_MatKhau.Text);
            if (kt == 1)
            {
                taikhoang = txtb_TaiKhoan.Text;
                matkhau = txtb_MatKhau.Text;
                frmMain f = new frmMain();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else if (kt == 0)
                XtraMessageBox.Show("Tài Khoản đã bị khóa!", "Thông Báo");
            else
                XtraMessageBox.Show("Sai Tài Khoảng hoặc Mật Khẩu!", "Thông Báo");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}