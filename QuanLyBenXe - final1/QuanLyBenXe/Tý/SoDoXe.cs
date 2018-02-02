using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using DAO;

namespace QuanLyBenXe
{
    public partial class SoDoXe : UserControl
    {
        
        LoadDS ab=new LoadDS();
         public readonly string TemplateFilenam = System.IO.Directory.GetCurrentDirectory() + @"\demo.docx";
        
        int soluongve=0;
        public SoDoXe()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        public void SoDoXe_Load(object sender, EventArgs e)
        {
           // soluongve = 0;
           // label16.Text = "0";
            TaoSoDoXe a = new TaoSoDoXe();
            soluongve = 0;
            panel1.Controls.Add(panel2);
            panel2.Dock = DockStyle.Fill;
            if (ab.laysoxe(DatVeXe.maCX) == 15)
            {
                a.loadSodoxe123(panel3, ab.laysoxe(DatVeXe.maCX) + 1, DatVeXe.maCX);
            }
            else {
                a.loadSodoxe40(panel3, ab.laysoxe(DatVeXe.maCX) + 1, DatVeXe.maCX);
            } dataGridView1.Visible = false;
            lblMCX.Text = DatVeXe.maCX;
            label14.Text = DatVeXe.soXE;
            label7.Text = DatVeXe.nGay;
            label12.Text = DatVeXe.tenTuyen11;
            label8.Text = DatVeXe.gIo;
            label18.Text = DateTime.Now.ToShortDateString();
            int[]cccc=TaoSoDoXe.TenChoNgoi1;
            int tamw = 0;
            while(cccc[tamw]!=0)
            {
                if(cccc[tamw]==-1)
                {
                    tamw++;
                    continue;
                }
                soluongve++;
                tamw++;
            }
            
            CultureInfo cultr = new CultureInfo("vi-VN");
            //string cu = (DatVeXe.Giave * soluongve).ToString();
            label16.Text = (DatVeXe.Giave*soluongve).ToString("c",cultr);
            soluongve = 0;
          //  textBox1.Text = TaoSoDoXe.TenChoNgoi;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        string idve;
        private void button1_Click(object sender, EventArgs e)
        {

            SoDoXe_Load(sender, e);
            TXS_QLBX abca = new TXS_QLBX();
            int[] cccc = TaoSoDoXe.TenChoNgoi1;
            //int mn = max;
           

            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                {
                    try
                    {
                        abca.insertKhach(lblMCX.Text, textBox1.Text, textBox2.Text);
                        idve = layidcuave(lblMCX.Text, textBox1.Text, textBox2.Text);
                        int i = 0;
                        while (cccc[i] != 0)
                        {
                            if (cccc[i] == -1)
                            {
                                i++;
                                continue;
                            }
                            abca.insertVEXE(lblMCX.Text, label14.Text, cccc[i].ToString(),idve);
                            i++;
                        }

                        soluongve = 0;
                        MessageBox.Show("Cám ơn bạn đã sử dụng dịch vụ của chúng tôi", "Thanks", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //TaoSoDoXe.TenChoNgoi1 = new int[45];
                    //cccc = null;


                    // soluongve = 0;
                    button2.Enabled = true;
                        panel3.Controls.Clear();
                       // a.loadSodoxe123(panel3, ab.laysoxe(DatVeXe.maCX) + 1, DatVeXe.maCX);
                       SoDoXe_Load(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("Chua chon cho ngoi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                    
            }           
        }

     
        string layidcuave(string idchuyen,string ten,string sdt)
        {
            
            dataGridView1.DataSource = ab.layidve(idchuyen, ten, sdt);
            string mu = dataGridView1.Rows[0].Cells[0].Value.ToString();
            
                try
                {
                    mu = dataGridView1.Rows[0].Cells["IdVe"].Value.ToString();
                }
                catch {  }
            
            return mu;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void panel3_Click(object sender, EventArgs e)
        {
            SoDoXe_Load(sender, e);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
          private void replace(string stubtoreplace, string text, word.Document wordocument)
        {
            var ranger = wordocument.Content;
            ranger.Find.ClearFormatting();
            ranger.Find.Execute(FindText: stubtoreplace, ReplaceWith: text);
        }
          private void asdf(object sender, EventArgs e)
          {
            button2.Enabled = false;
              FolderBrowserDialog fbd = new FolderBrowserDialog();
              if (fbd.ShowDialog() == DialogResult.OK)
              {
                  //string ssss = "banve1";
                  var machuyen = lblMCX.Text;
                  var tenchuyen = label12.Text;
                  var tenkhach = textBox1.Text;
                  var sodt = textBox2.Text;
                  // var soghe = label4.Text;
                  var ngaydi = label7.Text;
                  var gio = label8.Text;
                  var bks = label14.Text;
                  var tongtien = label16.Text;
                  var ngaydatve = label18.Text;
                  var wordApp = new word.Application();
                  var worddocument = wordApp.Documents.Open(TemplateFilenam);

                  replace("«machuyen»", machuyen, worddocument);
                  replace("«tentuyen»", tenchuyen, worddocument);
                  replace("«tenkhach»", tenkhach, worddocument);
                  replace("«sdt»", sodt, worddocument);
                  //replace("«sg»", soghe, worddocument);
                  replace("«nd»", ngaydi, worddocument);
                  replace("«g»", gio, worddocument);
                  replace("«sx»", bks, worddocument);
                  replace("«tt»", tongtien, worddocument);
                  replace("«nm»", ngaydatve, worddocument);
                  //SaveFileDialog fsave = new SaveFileDialog();
                  //fsave.Filter = "(tat ca)|*.*|(tep ecel)|*.docx";
                  //fsave.ShowDialog();
                  //worddocument.SaveAs(@"\ccaa.docx");

                  worddocument.SaveAs(fbd.SelectedPath + @"\" + idve + ".docx");
                  MessageBox.Show("Thanh cong");
              }
          }
    }
}
