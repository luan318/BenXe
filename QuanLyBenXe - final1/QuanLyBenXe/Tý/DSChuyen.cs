using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DAO;

namespace QuanLyBenXe
{
    public partial class DSChuyen : UserControl
    {
        LoadDS a = new LoadDS();
        TXS_QLBX b = new TXS_QLBX();
        public DSChuyen()
        {
            InitializeComponent();
            loadcombo();            
            
        }
        void loadcombo()
        {
            comboBox1.DataSource = a.LoadTuyenXe();

            comboBox1.DisplayMember = "TenTuyen";
            comboBox1.ValueMember = "IdTuyen";
            comboBox2.DataSource = a.loadxe();
            comboBox2.DisplayMember = "So_Xe";
            comboBox2.ValueMember = "So_Xe";

            comboIdChuyn.DataSource = a.loadidchuyen();
            comboIdChuyn.DisplayMember = "IdChuyen";
            comboIdChuyn.ValueMember = "IdChuyen";

            comboBoxIdtuyen.DataSource = a.LoadTuyenXe();
            comboBoxIdtuyen.DisplayMember = "TenTuyen";
            comboBoxIdtuyen.ValueMember = "IdTuyen";

            comboBox3.DataSource = a.loadxe();
            comboBox3.DisplayMember = "So_Xe";
            comboBox3.ValueMember = "So_Xe";

            comboBox4.DataSource = a.loadidchuyen();
            comboBox4.DisplayMember = "IdChuyen";
            comboBox4.ValueMember = "IdChuyen";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ab = numericUpDown1.Value.ToString() + "h" + numericUpDown2.Value.ToString();
            int kt = DateTime.Compare(Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()), DateTime.Now);
            if (kt < 0)
            {
                MessageBox.Show("Không thể thêm chuyến có ngày trong quá khứ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (b.insertChuyenXe(comboBox1.SelectedValue.ToString(), comboBox2.SelectedValue.ToString(), dateTimePicker1.Value.ToShortDateString(), ab) == true)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grid.DataSource = a.LoadChuyen();
                //DSChuyen_Load(sender, e);
            }
            else MessageBox.Show("Thất bại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DSChuyen_Load(object sender, EventArgs e)
        {
            loadcombo();
            panel1.Controls.Clear();
            panelmain.Visible = true;
            grid.DataSource = a.LoadChuyen();
            
            comboBox1.DataSource = a.LoadTuyenXe();

            
            comboBox1.SelectedIndex = 0;
            panelThem.Visible = false;
            panelsua.Visible = false;
            panelXoa.Visible = false;
            panel1.Controls.Add(panelmain);
            panelmain.Dock = DockStyle.Fill;



        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panelmain.Visible = false;
            panelThem.Visible = true;
            panel1.Controls.Add(panelThem);
            panelThem.Dock = DockStyle.Fill;
        }

        private void simplesua_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panelmain.Visible = false;
            panelsua.Visible = true;
            panel1.Controls.Add(panelsua);
            panelsua.Dock = DockStyle.Fill;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DSChuyen_Load(sender, e);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {


            string ab = numericUpDowngio.Value.ToString() + "h" + numericUpDownphut.Value.ToString();
            try
            {
                if (b.updatechuyenxe(comboBoxIdtuyen.SelectedValue.ToString(), comboBox3.SelectedValue.ToString(), dateTimePicker2.Value.ToShortDateString(), ab, comboIdChuyn.SelectedValue.ToString()) == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid.DataSource = a.LoadChuyen();
                }
                else { MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show("Sửa thất bại rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void simplexoa_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();
            panelmain.Visible = false;
            panelXoa.Visible = true;
            panel1.Controls.Add(panelXoa);
            panelXoa.Dock = DockStyle.Fill;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (b.deletechuyenxe(comboBox4.SelectedValue.ToString()) == true)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid.DataSource = a.LoadChuyen();
                }
                else MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { if(MessageBox.Show("Vé đã được bán, Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if(b.deleteChuyen(comboBox4.SelectedValue.ToString()) == true)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid.DataSource = a.LoadChuyen();
                }
            }
            }
        }
        string cccc;
        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            if (e.RowHandle >= 0)
            {
                if (e.RowHandle % 2 == 0)
                {
                    e.Appearance.BackColor = Color.AntiqueWhite;
                }
            }
            //string ngay=grid.GetRowCellDisplayText(e.RowHandle,grid)
           
            string category = gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns["Ngày Đi"]);
            //DateTime clcl=DateTime.Parse(gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns["Ngày Đi"]));
            cccc = category.Trim();
            try
            {
                string[] nga = cccc.Split('/');

                //string ngay1 = string.Join(nga[1],"/" ,nga[0],"/", nga[2]);
                CultureInfo ctr = new CultureInfo("en-US");

                string ngay1 = nga[1].ToString() + "/" + nga[0].ToString() + "/" + nga[2].ToString();

                DateTime abcc =  Convert.ToDateTime(cccc);
                int re = DateTime.Compare(abcc, DateTime.Now);
                if(re<0)

                e.Appearance.BackColor = Color.Pink;
               
            }
            catch { }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            comboIdChuyn.SelectedValue = gridView1.GetFocusedRowCellValue("Mã Chuyến").ToString();
            comboBox4.SelectedValue = gridView1.GetFocusedRowCellValue("Mã Chuyến").ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     


       

      

        
    }
}
