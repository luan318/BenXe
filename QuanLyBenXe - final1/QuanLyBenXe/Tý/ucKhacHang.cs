using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Controls;

namespace QuanLyBenXe
{
    public partial class ucKhacHang : UserControl
    {

        LoadDS a = new LoadDS();
        public ucKhacHang()
        {
            InitializeComponent();
           // gridLookUpEdit2.Enabled = false;
            nhu();
          //  dataGridView1.DataSource = a.LoadKhach();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = a.loadhanhkhachdk(textBox1.Text);
            
        }

        void loadcombo()
        {
            //gridLookUpEdit2.Enabled = true;
            if (gridLookUpEdit1.EditValue.ToString() != "Chọn vé cần hủy:")
            {
            gridLookUpEdit2.Properties.DataSource = a.LoadTenChoNgoi(gridLookUpEdit1.EditValue.ToString());
            gridLookUpEdit2.Properties.DisplayMember = "TenChoNgoi";
            gridLookUpEdit2.Properties.ValueMember = "TenChoNgoi";
            gridLookUpEdit2.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            //dòng này để gridcontrol trong GridlookupEdit tự động resize các column để không thừa không         thiếu nội dung
            gridLookUpEdit2.Properties.ImmediatePopup = true;
            // dòng này tự động mở popup khi search có kết quả
            gridLookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //GridControl View = sender as GridControl;
            //GridControl View = sender as gridView1;
            //doi mau row chan
           
            
            //if (e.RowHandle >= 0)
            //{
            //    if (e.RowHandle % 2 == 0)
            //    {
            //        e.Appearance.BackColor = Color.AntiqueWhite;
            //    }
            //}
           
            
            
            
            //Doi mau cell cua colummn Status, neu co gia tri Actived thi co mau xanh, neu co gia tri N/A thi co mau hong`
        //    if (e.Column.FieldName == "SĐT")
            {
                string category = gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns["Số vé đã mua"]);
                if (int.Parse(category) > 2)
                    e.Appearance.BackColor = Color.AntiqueWhite;
                if (int.Parse(category) > 3)
                    e.Appearance.BackColor = Color.Pink;
                if (int.Parse(category) > 4)
                    e.Appearance.BackColor = Color.Red;
             
            }
        }



        private void gridLookUpEdit1View_Click(object sender, EventArgs e)
        {
            
            //gridLookUpEdit1View_RowClick(sender, e);
            gridLookUpEdit2.Enabled = true;

            gridLookUpEdit2.Properties.DataSource = a.LoadTenChoNgoi(gridLookUpEdit1.EditValue.ToString());
            gridLookUpEdit2.Properties.DisplayMember = "TenChoNgoi";
            gridLookUpEdit2.Properties.ValueMember = "TenChoNgoi";
            gridLookUpEdit2.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            //dòng này để gridcontrol trong GridlookupEdit tự động resize các column để không thừa không         thiếu nội dung
            gridLookUpEdit2.Properties.ImmediatePopup = true;
            // dòng này tự động mở popup khi search có kết quả
            gridLookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ucKhacHang_Load(sender, e);
        }

        private void gridLookUpEdit1View_RowClick(object sender, EventArgs e)
        {
            //gridLookUpEdit2.Enabled = true;
          //  gridLookUpEdit1View_Click(sender, e);
            gridLookUpEdit2.Properties.DataSource = a.LoadTenChoNgoi(gridLookUpEdit1.EditValue.ToString());
            gridLookUpEdit2.Properties.DisplayMember = "TenChoNgoi";
            gridLookUpEdit2.Properties.ValueMember = "TenChoNgoi";
            gridLookUpEdit2.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            //dòng này để gridcontrol trong GridlookupEdit tự động resize các column để không thừa không         thiếu nội dung
            gridLookUpEdit2.Properties.ImmediatePopup = true;
            // dòng này tự động mở popup khi search có kết quả
            gridLookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
           
        }

        private void ucKhacHang_Load(object sender, EventArgs e)
        {
            panelluu.Visible = false;


            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridLookUpEdit1.EditValue.ToString() != "Chọn vé cần hủy:")
            {
                panelluu.Visible = true;
                panelHuy.Visible = false;
                loadcombo();
            }
            else MessageBox.Show("Chưa chọn khách muốn hủy vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        TXS_QLBX xoa = new TXS_QLBX();
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if(xoa.deleteKhach(gridLookUpEdit1.EditValue.ToString(),gridLookUpEdit2.EditValue.ToString())==true)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nhu();
                    gridLookUpEdit2.Properties.DataSource = a.LoadTenChoNgoi(gridLookUpEdit1.EditValue.ToString());
                    gridLookUpEdit2.Properties.DisplayMember = "TenChoNgoi";
                    gridLookUpEdit2.Properties.ValueMember = "TenChoNgoi";
                    gridLookUpEdit2.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
                    //dòng này để gridcontrol trong GridlookupEdit tự động resize các column để không thừa không         thiếu nội dung
                    gridLookUpEdit2.Properties.ImmediatePopup = true;
                    // dòng này tự động mở popup khi search có kết quả
                    gridLookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

                }
                else MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Chưa chọn ghế muốn hủy vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void nhu()
        {
            gridControl1.DataSource = a.LoadKhach();
            gridLookUpEdit1.Properties.DataSource = a.LoadKhach1();
            gridLookUpEdit1.Properties.DisplayMember = "TenHanhKhach";
            gridLookUpEdit1.Properties.ValueMember = "IdVe";
            gridLookUpEdit1.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            //dòng này để gridcontrol trong GridlookupEdit tự động resize các column để không thừa không         thiếu nội dung
            gridLookUpEdit1.Properties.ImmediatePopup = true;
            // dòng này tự động mở popup khi search có kết quả
            gridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelHuy.Visible = true;
            panelluu.Visible = false;
            
        }

    }
}
