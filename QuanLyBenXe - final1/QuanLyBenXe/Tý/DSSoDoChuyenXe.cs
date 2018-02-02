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

namespace QuanLyBenXe
{
    public partial class DSSoDoChuyenXe : UserControl
    {
        LoadDS a = new LoadDS();
        TXS_QLBX b = new TXS_QLBX();
        void data()
        {
            gridControl1.DataSource = a.loadxe();
            comboBox1.DataSource = a.loadxe();
            comboBox1.DisplayMember = "So_Xe";
            comboBox1.ValueMember = "So_Xe";
        }
        public DSSoDoChuyenXe()
        {
            InitializeComponent();
            
        }

        private void DSSoDoChuyenXe_Load(object sender, EventArgs e)
        {
            data();
            panelthem.Visible = panelxoa.Visible = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(panelmain);
            panelmain.Dock = DockStyle.Fill;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            panelthem.Visible = true;
            panelmain.Visible = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(panelthem);
            panelthem.Dock = DockStyle.Fill;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            panelxoa.Visible = true;
            panelmain.Visible = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(panelxoa);
            panelxoa.Dock = DockStyle.Fill;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            panelthem.Visible = false;
            panelmain.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(panelmain);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            panelxoa.Visible = false;
            panelmain.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(panelmain);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text==string.Empty||textBox2.Text==string.Empty||textBox3.Text==string.Empty||textBox4.Text==string.Empty)
                {
                    MessageBox.Show("Nhập đủ thông số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(b.insertXe(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text)==true)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        data();
                    }
                    else { MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            catch { MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (b.deletexe(comboBox1.SelectedValue.ToString()) == true)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data();
                }
                else { MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            catch { MessageBox.Show("Thất bại do xe này đang có chuyến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
