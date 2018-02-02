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
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyBenXe
{
    public partial class Thongke : UserControl
    {
        LoadDS a = new LoadDS();
        CultureInfo cultr = new CultureInfo("vi-VN");
        public Thongke()
        {
            InitializeComponent();
            dataGridView2.Visible = false;
        }
        int thanhtien = 0;
        public void load()
        {
            dataGridView2.DataSource = a.loadcaigido();
            gridControl1.DataSource = a.loadcaigido();
            tinhthanhtien(a.hotro());
            textBox1.Text = thanhtien.ToString("c", cultr);
            thanhtien = 0;
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            load();
            // gridView1_RowStyle(sender, e);
            dateTimePicker1.CalendarMonthBackground = Color.AntiqueWhite;
            
        }
        void tinhthanhtien(DataTable a)
        {

            dataGridView1.DataSource = a;
            thanhtien = 0;
            int n = dataGridView1.RowCount;
            for (int i = 0; i < n-1; i++)
            {
                thanhtien += int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
        }


        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            //if (e.RowHandle >= 0)
            //{
            //    if (e.RowHandle % 2 == 0)
            //    {
            //        e.Appearance.BackColor = Color.AntiqueWhite;
            //    }
            //}
            try
            {
                string category = gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns["Số vé đã bán"]);
                if (int.Parse(category) > 10)
                    e.Appearance.BackColor = Color.BlueViolet;
                if (int.Parse(category) > 5)
                    e.Appearance.BackColor = Color.AntiqueWhite;
                
            }
            catch { }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = a.loadthongke(dateTimePicker1.Value.ToShortDateString());
            gridControl1.DataSource = a.loadthongke(dateTimePicker1.Value.ToShortDateString());
            tinhthanhtien(a.hotro1(dateTimePicker1.Value.ToShortDateString()));
            textBox1.Text = thanhtien.ToString("c", cultr);
            thanhtien = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog fsave = new SaveFileDialog();
            fsave.Filter = "(tat ca)|*.*|(tep ecel)|*.xlsx";
            fsave.ShowDialog();
            if(fsave.FileName !="")
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                Excel._Worksheet sheet = null;
                try
                {
                    sheet = wb.ActiveSheet;
                    sheet.Name = "Thống kê báo cáo";
                    sheet.Cells[1, 1] = "STT";
                    sheet.Cells[1, 2] = "Mã Chuyến";
                    sheet.Cells[1, 3] = "Tên tuyến";
                    sheet.Cells[1, 4] = "Ngày";
                    sheet.Cells[1, 5] = "Số vé đã bán";
                    sheet.Cells[1, 6] = "Thành Tiền";
                     

                    for (int j = 2; j <dataGridView2.RowCount+1;j++ )
                    {
                //        for (int i = 1; i < 6; i++)
                            //{
                //            sheet.Cells[j, i] = dataGridView2.Rows[j-1].Cells[i - 1].Value.ToString();
                        //    sheet.Cells[2, i].HorizontalAlingment = Excel.XlHAlign.xlHAlignCenter;
                        //    sheet.Cells[2, i].Font.Bold = true;
                        //    sheet.Cells[2, i].Borders.Weight = Excel.XlBorderWeight.xlThin;
                        //}
                        sheet.Cells[j, 1] = (j - 1).ToString();
                        int k=2;
                        while(true)
                        {
                            try { sheet.Cells[j, k] = dataGridView2.Rows[j - 2].Cells[k - 1].Value.ToString();
                            k++;
                            }
                            catch { break; }
                        }

                    } sheet.Cells[dataGridView2.RowCount+1, 5] = "Thành Tiền";
                    sheet.Cells[dataGridView2.RowCount+1, 6] = textBox1.Text;
                    //for(int i=0;i<dataGridView2.RowCount;i++)
                    //{
                    //    ListViewItem item=dataGridView2.Item
                    //}
                    wb.SaveAs(fsave.FileName);
                    MessageBox.Show("Thanh cong");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    app.Quit();
                    wb = null;
                }
            }
            else
            {
                MessageBox.Show("Chuw chon");
            }
        }
    }
}
