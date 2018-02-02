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
using DevExpress.XtraEditors.Controls;

namespace QuanLyBenXe
{
    public partial class doive : UserControl
    {
        LoadDS a = new LoadDS();
        string tcn = "";
        public doive()
        {
            InitializeComponent();
        }

        private void doive_Load(object sender, EventArgs e)
        {
            simpleButton1.Enabled = false;
            dataGridView1.DataSource = a.LoadKhach1();
            gridLookUpEdit3.Properties.DataSource = a.LoadKhach1();
            gridLookUpEdit3.Properties.DisplayMember = "TenHanhKhach";
            gridLookUpEdit3.Properties.ValueMember = "IdVe";
            gridLookUpEdit3.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            gridLookUpEdit3.Properties.ImmediatePopup = true;
            gridLookUpEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            
        }

        private void gridLookUpEdit3View_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }

        private void gridLookUpEdit3View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            MessageBox.Show(gridLookUpEdit3.EditValue.ToString());
        }

        string mcx(string a)
        {
            string b = (string)DataProvider.Instance.ExcuteScalar("select idchuyen from banve where idve='"+a+"'");
            return b;
        }
        string idve = "";
        string idchuyen = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //panel1.Controls.Clear();
            //TaoSoDoXe c = new TaoSoDoXe();
            //c.loadSodoxehuyve(panel1, a.laysoxe(mcx(dataGridView1["IdVe", e.RowIndex].Value.ToString())) + 1, mcx(dataGridView1["IdVe", e.RowIndex].Value.ToString()), dataGridView1["IdVe", e.RowIndex].Value.ToString());
            try
            {
                idve = dataGridView1["IdVe", e.RowIndex].Value.ToString();
                idchuyen = mcx(dataGridView1["IdVe", e.RowIndex].Value.ToString());
                dataGridView2.DataSource = DataProvider.Instance.ExcuteQuery("select tenchongoi from ChoNgoi where chongoi.idve='" + dataGridView1["IdVe", e.RowIndex].Value.ToString() + "' and IdChuyen='" + mcx(dataGridView1["IdVe", e.RowIndex].Value.ToString()) + "'");
            }
            catch { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TXS_QLBX xoa = new TXS_QLBX();
            if (xoa.deleteKhach(idve, tcn) == true)
            { MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { MessageBox.Show("That bai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            doive_Load(sender, e);

         //   idve = dataGridView1["IdVe", e.RowIndex].Value.ToString();
            dataGridView2.DataSource = DataProvider.Instance.ExcuteQuery("select tenchongoi from ChoNgoi where chongoi.idve='" + idve + "' and IdChuyen='" + idchuyen + "'");
            

        }
        
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tcn = dataGridView2[0, e.RowIndex].Value.ToString();
                simpleButton1.Enabled = true;
            }
            catch { }
        }


        

       

        
    }
}
