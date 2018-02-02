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
    public partial class DatVeXe : UserControl
    {
        #region static bien
        public static string maCX;
        public static string soXE;
        public static string tenTuyen11;
        public static string nGay;
        public static string gIo;
        public static int Giave;
        #endregion
        LoadDS a = new LoadDS();
        public DatVeXe()
        {
            
            InitializeComponent();
            panel4.Controls.Clear();
            //comboBox1.Text = "All";
        }

        private void DatVeXe_Load(object sender, EventArgs e)
        {
            TaoSoDoXe.TenChoNgoi = string.Empty;
            
         //   panel2.Visible = true;
            panel3.Visible = false;
            
            Giave = 0;
            comboBox1.DataSource = a.LoadDsTuyen();
            comboBox1.DisplayMember = "TenTuyen";
            comboBox1.ValueMember = "TenTuyen";
            dataGridView1.DataSource = a.LoadTimChuyen(DateTime.Now.ToShortDateString());
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            panel4.Controls.Add(panel2);
            panel2.Dock = DockStyle.Fill;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //private void tim()
        //{
        //    LoadDS a = new LoadDS();
        //    dataGridView1.DataSource = a.LoadDk(comboBox1.SelectedValue.ToString());
        //    //dataGridView1.DataSource = dv;
        //}

        //private void tim1()
        //{
        //    LoadDS a = new LoadDS();
        //    dataGridView1.DataSource = a.LoadDKngay(dateTimePicker1.Value.ToString().Substring(0, 10));
        //    //dataGridView1.DataSource = dv;
        //}
        private void tim9Xac()
        {
            LoadDS a = new LoadDS();
            dataGridView1.DataSource = a.LoadDKngayvachuyen(dateTimePicker1.Value.ToString().Substring(0, 10), comboBox1.SelectedValue.ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tim9Xac();
            //label1.Text = dateTimePicker1.Value.ToString().Substring(0,10);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                reloadbien();
                maCX = dataGridView1["IdTuyen", e.RowIndex].Value.ToString();
                tenTuyen11 = dataGridView1["TenTuyen", e.RowIndex].Value.ToString();
                soXE = dataGridView1["Comlun", e.RowIndex].Value.ToString();
                nGay = dataGridView1["Ngay1", e.RowIndex].Value.ToString().Substring(0, 10);
                gIo = dataGridView1["Column1", e.RowIndex].Value.ToString();
                Giave = int.Parse(dataGridView1["GiaVe", e.RowIndex].Value.ToString());
                //Giave = 0;
                //MessageBox.Show(maCX);
                panel4.Controls.Clear();
                // flowLayoutPanel1.Controls.Clear();
                //button1.Visible = false;
                //lblDAT.Visible = true;
                //button2.Visible = true;

                panel2.Visible = false;
                panel3.Visible = true;
                panel4.Controls.Add(panel3);
                panel3.Dock = DockStyle.Fill;

                panel1.Controls.Clear();
                SoDoXe b = new SoDoXe();
                b.Dock = DockStyle.Fill;
                //TaoSoDoXe d = new TaoSoDoXe();
                //d.loadSodoxe(b, 15);
                panel1.Controls.Add(b);
            }
            catch { }
        }

        public void reloadbien()
        {
            TaoSoDoXe.TenChoNgoi1 = new int[45];
            maCX="";
            soXE="";
            tenTuyen11="";
            nGay="";
            gIo="";
            Giave = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reloadbien();
            DatVeXe_Load(sender, e);
            panel1.Controls.Clear();
            dataGridView1.DataSource = a.LoadTimChuyen(DateTime.Now.ToShortDateString());
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            panel1.Controls.Add(dataGridView1);

        }
        
       
    }
}
