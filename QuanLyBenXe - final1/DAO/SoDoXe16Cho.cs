using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public partial class SoDoXe16Cho : UserControl
    {
        public SoDoXe16Cho()
        {
            InitializeComponent();
        }

        public void loadSodoxe(string c)
        {
            //TenChoNgoi1 = null;
            DataTable data = DataProvider.Instance.ExcuteQuery("exec USP_TenChoNgoi @idChuyen='" + c + "'");

           
            int tam = 0;
            string[] flag = new string[20];
            while (true)
            {
                try
                {
                    //flag += " "+data.Rows[tam++].ItemArray[0].ToString();
                    flag[tam] = data.Rows[tam++].ItemArray[0].ToString();
                }
                catch
                {
                    break;
                }
            }
            vedadat(flag, tam);



        }

        void vedadat(string[] flag, int tam)
        {
            for (int m = 0; m < tam; m++)
            {
                if (ghe1.Text == flag[m])
                    ghe1.BackColor = Color.Blue;
                if (ghe2.Text == flag[m])
                    ghe2.BackColor = Color.Blue;
                if (ghe3.Text == flag[m])
                    ghe3.BackColor = Color.Blue;
                if (ghe4.Text == flag[m])
                    ghe4.BackColor = Color.Blue;
                if (ghe5.Text == flag[m])
                    ghe5.BackColor = Color.Blue;
                if (ghe6.Text == flag[m])
                    ghe6.BackColor = Color.Blue;
                if (ghe7.Text == flag[m])
                    ghe7.BackColor = Color.Blue;
                if (ghe8.Text == flag[m])
                    ghe8.BackColor = Color.Blue;
                if (ghe9.Text == flag[m])
                    ghe9.BackColor = Color.Blue;
                if (ghe10.Text == flag[m])
                    ghe10.BackColor = Color.Blue;
                if (ghe11.Text == flag[m])
                    ghe11.BackColor = Color.Blue;
                if (ghe12.Text == flag[m])
                    ghe12.BackColor = Color.Blue;
                if (ghe13.Text == flag[m])
                    ghe13.BackColor = Color.Blue;
                if (ghe14.Text == flag[m])
                    ghe14.BackColor = Color.Blue;
                if (ghe15.Text == flag[m])
                    ghe15.BackColor = Color.Blue;
            }
        }

        private void SoDoXe16Cho_Load(object sender, EventArgs e)
        {
            ghe1.BackColor = Color.Blue ;
            ghe2.BackColor = Color.Silver;
            ghe3.BackColor = Color.Silver;
            ghe4.BackColor = Color.Silver;
            ghe5.BackColor = Color.Silver;
            ghe6.BackColor = Color.Silver;
            ghe7.BackColor = Color.Silver;
            ghe8.BackColor = Color.Silver;
            ghe9.BackColor = Color.Silver;
            ghe10.BackColor = Color.Silver;
            ghe11.BackColor = Color.Silver;
            ghe12.BackColor = Color.Silver;
            ghe13.BackColor = Color.Silver;
            ghe14.BackColor = Color.Silver;
            ghe15.BackColor = Color.Silver;
            ghe1.BackColor = Color.Silver;
            
        }

        
    }
    
}
