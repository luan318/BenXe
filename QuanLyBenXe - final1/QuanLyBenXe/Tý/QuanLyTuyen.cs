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
using System.Globalization;

namespace QuanLyBenXe
{
    public partial class QuanLyTuyen : UserControl
    {
        TXS_QLBX a = new TXS_QLBX();
        LoadDS b = new LoadDS();
      //  int flag = 0;
        public QuanLyTuyen()
        {
            InitializeComponent();
          //  comboBox1.Visible = false;
            comboBox1.DataSource = b.LoadTuyenXe();
            comboBox1.DisplayMember = "IdTuyen";
            comboBox1.ValueMember = "IdTuyen";

            comboBox2.DataSource = b.LoadTuyenXe();
            comboBox2.DisplayMember = "IdTuyen";
            comboBox2.ValueMember = "IdTuyen";

        }
        
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (kt(textBox1,textBox2,textBox3,textBox4)==false)
                MessageBox.Show("Phải nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                try
                {
                    if (a.insertTuyenXe(textBox1.Text, textBox3.Text, textBox4.Text, int.Parse(textBox2.Text)) == true)
                    {
                        MessageBox.Show("thanh cong");
                        dataGridView1.DataSource = b.LoadTuyenXe();
                    }
                    else MessageBox.Show("that bai");
                }
                catch
                {
                    MessageBox.Show("Mã tuyến tồn tại hoặc tuyến này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void QuanLyTuyen_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = b.LoadTuyenXe();
            
            panel1.Controls.Add(panelManin);
            panelManin.Dock = DockStyle.Fill;
            panelThem.Visible = false;
            panel2.Visible = false;
            panelxoa.Visible = false;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;
            textBox1.Focus();
            
        }
        bool kt(TextBox a,TextBox b,TextBox c,TextBox d)
        {
            if (a.Text == string.Empty || b.Text == string.Empty || c.Text == string.Empty || d.Text == string.Empty)
                return false;
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
         //       textBox1.Visible = false;
                //comboBox1.Visible = true;
                try
                {
                    if (a.updateTuyenXe(comboBox1.SelectedValue.ToString(), textdddisua.Text, textdddensua.Text, int.Parse(textgiavesua.Text)) == true)
                    {
                        MessageBox.Show("Thực hiện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = b.LoadTuyenXe();
                    }
                    else { MessageBox.Show("Thực hiện thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    //flag = 1;

                    return;
                }
                catch { MessageBox.Show("Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //textBox1.Text = dataGridView1["Column1", e.RowIndex].Value.ToString();
            //textBox2.Text = dataGridView1["Column5", e.RowIndex].Value.ToString();
            //textBox3.Text = dataGridView1["Column3", e.RowIndex].Value.ToString();
            //textBox4.Text = dataGridView1["Column4", e.RowIndex].Value.ToString();
            comboBox1.SelectedValue = dataGridView1["Column1", e.RowIndex].Value;
            comboBox2.SelectedValue = dataGridView1["Column1", e.RowIndex].Value;
        }

        private void buttonMHthem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panelThem.Visible = true;
            panel1.Controls.Add(panelThem);
            panelThem.Dock = DockStyle.Fill;
        }

        private void buttonmhsua_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Visible = true;
            
            panel1.Controls.Add(panel2);
            panel2.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panelxoa.Visible = true;
            panel1.Controls.Add(panelxoa);
            panelxoa.Dock = DockStyle.Fill;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(a.deletetuyen(comboBox2.SelectedValue.ToString())==true)
                {
                    MessageBox.Show("Thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dataGridView1.DataSource = b.LoadTuyenXe();
                    comboBox2.DataSource = b.LoadTuyenXe();
                    comboBox2.DisplayMember = "IdTuyen";
                    comboBox2.ValueMember = "IdTuyen";
                }else{MessageBox.Show("Thất bại","Thông báo");}
            }
            catch { MessageBox.Show("Tuyến này đang hoạt động, Bạn cần xóa hết các chuyến xe liên quan", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
        
        }

        

       
    }
}
