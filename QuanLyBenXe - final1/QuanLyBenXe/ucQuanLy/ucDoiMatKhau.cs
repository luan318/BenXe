using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using BUS;
namespace QuanLyBenXe
{
    public partial class ucDoiMatKhau : UserControl
    {
        public ucDoiMatKhau()
        {
            InitializeComponent();
            btn_DoiMatKhau.Click += new EventHandler(btn_DoiMatKhau_Click);
        }

        public bool KiemTraHopLe(string MatKhau1, string MatKhau2, string MatKhau3)
        {
            if (MatKhau1 == "")
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu cũ");
            }
            else
            {
                if (MatKhau1 != frmLogin.matkhau)
                    XtraMessageBox.Show("Mật khẩu cũ chưa chính xác");
                else
                {
                    if (MatKhau2 != "")
                    {
                        if (MatKhau2 != MatKhau3)
                            XtraMessageBox.Show("Nhập lại mật khẩu mới chưa chính xác!");
                        else return true;
                    }
                    else
                        XtraMessageBox.Show("Chưa nhập mật khẩu mới!");
                }
            }

            return false;
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            if (KiemTraHopLe(txtb_MatKhauCu.Text, txtb_MatKhauMoi1.Text, txtb_MatKhauMoi2.Text) == true)
            {
                BUS_NhanVien.Instance.update_pass_NhanVien(frmLogin.taikhoang, txtb_MatKhauMoi1.Text);
                XtraMessageBox.Show("Thành công!", "Chúc mừng :)");
            }
        }
    }
}
