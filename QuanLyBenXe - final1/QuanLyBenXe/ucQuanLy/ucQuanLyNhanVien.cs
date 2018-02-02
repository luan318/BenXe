using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace QuanLyBenXe
{
    public partial class ucQuanLyNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        BindingSource nnd = new BindingSource();

        public ucQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void ucQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            load_combobox();
            load_gridview1(-1);
            UI();
            even();
        }

        public void even()
        {
            btn_R.Click += new EventHandler(btn_R_Click);
            btn_L.Click += new EventHandler(btn_L_Click);
        }

        private void UI()
        {
            gridView1.OptionsDetail.EnableMasterViewMode = false;
            gridView2.OptionsDetail.EnableMasterViewMode = false;
            gridView1.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.Editable = false;
        }


        #region combobox
        //load combobox
        private bool load_combobox()
        {
            nnd.DataSource = BUS_QuanLyNhanVien.Instance.load_NhomNguoiDung();
            lookUpEdit1.Properties.DataSource = nnd;
            lookUpEdit1.Properties.PopulateColumns();
            DevExpress.XtraEditors.Controls.LookUpColumnInfoCollection columns = lookUpEdit1.Properties.Columns;
            columns[0].Caption = "Id";
            columns[1].Caption = "Tên Nhóm";
            lookUpEdit1.Properties.ImmediatePopup = true;
            return true;
        }
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int x = int.Parse(lookUpEdit1.EditValue.ToString());
            load_gridview1(x);
            load_gridview2(x);
        }
        #endregion

        #region gridview
        //1. load gridview nhan vien chua theo nhom
        private bool load_gridview1(int x)
        {
            gridControl1.DataSource = BUS_QuanLyNhanVien.Instance.load_NhanVienKhongTheoNhom(x);
            gridView1.Columns[2].Visible = false;
            return true;
        }


        //2. load gridview nhan vien da phan quyen nhom
        private bool load_gridview2(int x)
        {
            gridControl2.DataSource=BUS_QuanLyNhanVien.Instance.load_NhanVienTheoNhom(x);
            gridView2.Columns[2].Visible = false;
            return true;
        }
        #endregion

        private void btn_R_Click(object sender, EventArgs e)
        {
            int IdNguoiDung = int.Parse(gridView1.GetFocusedRowCellValue("id_nhan_vien").ToString());
            int IdNhom = int.Parse(lookUpEdit1.EditValue.ToString());
            BUS_QuanLyNhanVien.Instance.insert_PhanQuyenNguoiDung(IdNguoiDung, IdNhom);
            lookUpEdit1_EditValueChanged(sender, e);
        }

        private void btn_L_Click(object sender, EventArgs e)
        {
            int IdNguoiDung = int.Parse(gridView2.GetFocusedRowCellValue("id_nhan_vien").ToString());
            int IdNhom = int.Parse(lookUpEdit1.EditValue.ToString());
            BUS_QuanLyNhanVien.Instance.delete_PhanQuyenNguoiDung(IdNguoiDung, IdNhom);
            lookUpEdit1_EditValueChanged(sender, e);

        }
    }
}
