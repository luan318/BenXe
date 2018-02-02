using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Data;
using System.Drawing;


namespace DAO
{
    public    class TaoSoDoXe
    {
        
        public static string TenChoNgoi = string.Empty;
        public static int[] TenChoNgoi1=new int[45];
      
        
        public void loadSodoxe(Control ctr,int a,string c)
        {
            //TenChoNgoi1 = null;
            TenChoNgoi1 = new int[45];
            DataTable data = DataProvider.Instance.ExcuteQuery("exec USP_TenChoNgoi @idChuyen='"+c+"'"); 
            
            Button cubtn = new Button() { Width = 0, Location = new Point(0, 100) };
            int tam = 0;
            string[] flag=new string[20];
            while(true)
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

            //MessageBox.Show(flag[3]);

            for(int i=0;i<a;i++)
            {                
                Button btn = new Button() { Width = 100, Height = 100, Location = new Point(cubtn.Location.X + cubtn.Width, cubtn.Location.Y) };
                btn.Tag = i.ToString();
                btn.BackColor = Color.Silver;
                if (i == 0)
                {

                    btn.Text = "Tài xế";
                    btn.Enabled = false;

                }
                else
                {
                    btn.Text = i.ToString();
                  
                }
                for (int m = 0; m < tam;m++ )
                {
                    if (btn.Text == flag[m])
                        btn.BackColor = Color.Blue;
                }
                    ctr.Controls.Add(btn);
                    btn.Click += btn_Click;
                cubtn = btn;
            }
        }
        int tam = 0;
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if (btn.BackColor == Color.Blue)
            {
                MessageBox.Show("Ghế này đã được đặt");
            }
            if(btn.BackColor==Color.Silver)
            {
                btn.BackColor = Color.Red;
                TenChoNgoi += " " +btn.Tag.ToString();
                TenChoNgoi1[tam] = int.Parse(btn.Tag.ToString());
                tam++;
            }
         
            //nen tao doi tuong chuyen xe
            //dua thong ting huong doi tuong vao
        }
    

        //luuu
        public void loadSodoxe123(Control ctr, int a, string c)
        {          
            DataTable data = DataProvider.Instance.ExcuteQuery("exec USP_TenChoNgoi @idChuyen='" + c + "'");
            Button cubtn = new Button() { Width = 0, Location = new Point(0, 100) };
            int tam = 0;
            string[] flag = new string[45];
            while (true)
            {
                try
                {
                    flag[tam] = data.Rows[tam++].ItemArray[0].ToString();
                }
                catch
                {
                    break;
                }
            }
            for (int i = 0; i < a; i++)
            {
                Button btn1 = new Button();
                btn1.Tag = i.ToString();
                btn1.BackColor = Color.Silver;
                if(i==0)
                {
                    btn1.Location = new System.Drawing.Point(20, 20);
                    btn1.Size = new System.Drawing.Size(75, 72);
                    btn1.Text = "Tài Xế";
                    btn1.Enabled = false;
                }
                else
                {
                    btn1.Text = i.ToString();

                }

                if (i == 1)
                {
                    btn1.Location = new System.Drawing.Point(181, 20);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 2)
                {
                    btn1.Location = new System.Drawing.Point(311, 20);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 3)
                {
                    btn1.Location = new System.Drawing.Point(20, 142);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 4)
                {
                    btn1.Location = new System.Drawing.Point(114, 142);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 5)
                {
                    btn1.Location = new System.Drawing.Point(311, 142);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 6)
                {
                    btn1.Location = new System.Drawing.Point(20, 233);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 7)
                {
                    btn1.Location = new System.Drawing.Point(114, 233);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 8)
                {
                    btn1.Location = new System.Drawing.Point(311, 233);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 9)
                {
                    btn1.Location = new System.Drawing.Point(20, 327);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 10)
                {
                    btn1.Location = new System.Drawing.Point(114, 327);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 11)
                {
                    btn1.Location = new System.Drawing.Point(311, 327);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 12)
                {
                    btn1.Location = new System.Drawing.Point(20, 416);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 13)
                {
                    btn1.Location = new System.Drawing.Point(114, 416);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 14)
                {
                    btn1.Location = new System.Drawing.Point(213, 416);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 15)
                {
                    btn1.Location = new System.Drawing.Point(311, 416);
                    btn1.Size = new System.Drawing.Size(75, 72);
                }
               


                for (int m = 0; m < tam; m++)
                {
                    if (btn1.Text == flag[m])
                        btn1.BackColor = Color.Blue;
                }
                ctr.Controls.Add(btn1);
                btn1.Click += btn1_Click;
                
            }
        }
        int tam1 = 0;
        void btn1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Button btn = sender as Button;

            if (btn.BackColor == Color.Blue)
            {
                MessageBox.Show("Ghế này đã được đặt");
            }
            else if (btn.BackColor == Color.Silver)
            {
                btn.BackColor = Color.Red;
                TenChoNgoi += " " + btn.Tag.ToString();
                TenChoNgoi1[tam1] = int.Parse(btn.Tag.ToString());
                tam1++;
            }
            else
            {
                try
                {
                    btn.BackColor = Color.Silver;

                    int i = timvt(TenChoNgoi1, int.Parse(btn.Tag.ToString()));
                    TenChoNgoi1[i] = -1;
                }
                catch { }
            }
        }
       
        int timvt(int[] a,int x)
        {
            for (int i = 0; i < 45; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }
        #region huy
        public void loadSodoxehuyve(Control ctr, int a, string c,string d)
        {


            DataTable data = DataProvider.Instance.ExcuteQuery("exec USP_TenChoNgoi @idChuyen='" + c + "'");
            DataTable data1 = DataProvider.Instance.ExcuteQuery("select tenchongoi from ChoNgoi where chongoi.idve='"+d+"' and IdChuyen='"+c+"'");
            Button cubtn = new Button() { Width = 0, Location = new Point(0, 100) };
            int tam = 0;
            string[] flag = new string[45];
            string[] flag1 = new string[45];
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
            int tamdamua = 0;
            while (true)
            {
                try
                {
                    //flag += " "+data.Rows[tam++].ItemArray[0].ToString();
                    flag1[tamdamua] = data1.Rows[tamdamua++].ItemArray[0].ToString();
                }
                catch
                {
                    break;
                }
            }
            // ctr.Click+=ctr_Click;
            //MessageBox.Show(flag[3]);

            for (int i = 0; i < a; i++)
            {
                Button btn2 = new Button();
                btn2.Tag = i.ToString();
                btn2.BackColor = Color.Silver;
                if (i == 0)
                {
                    btn2.Location = new System.Drawing.Point(20, 20);
                    btn2.Size = new System.Drawing.Size(75, 72);
                    btn2.Text = "Tài Xế";
                    btn2.Enabled = false;
                }
                else
                {
                    btn2.Text = i.ToString();

                }

                if (i == 1)
                {
                    btn2.Location = new System.Drawing.Point(181, 20);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 2)
                {
                    btn2.Location = new System.Drawing.Point(311, 20);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 3)
                {
                    btn2.Location = new System.Drawing.Point(20, 142);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 4)
                {
                    btn2.Location = new System.Drawing.Point(114, 142);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 5)
                {
                    btn2.Location = new System.Drawing.Point(311, 142);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 6)
                {
                    btn2.Location = new System.Drawing.Point(20, 233);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 7)
                {
                    btn2.Location = new System.Drawing.Point(114, 233);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 8)
                {
                    btn2.Location = new System.Drawing.Point(311, 233);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 9)
                {
                    btn2.Location = new System.Drawing.Point(20, 327);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 10)
                {
                    btn2.Location = new System.Drawing.Point(114, 327);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 11)
                {
                    btn2.Location = new System.Drawing.Point(311, 327);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 12)
                {
                    btn2.Location = new System.Drawing.Point(20, 416);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 13)
                {
                    btn2.Location = new System.Drawing.Point(114, 416);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 14)
                {
                    btn2.Location = new System.Drawing.Point(213, 416);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }
                if (i == 15)
                {
                    btn2.Location = new System.Drawing.Point(311, 416);
                    btn2.Size = new System.Drawing.Size(75, 72);
                }



                for (int m = 0; m < tam; m++)
                {
                    if (btn2.Text == flag[m])
                        btn2.BackColor = Color.Blue;
                }
                if (tamdamua != 0)
                {
                    for (int m = 0; m < tamdamua; m++)
                    {
                        if (btn2.Text == flag1[m])
                            btn2.BackColor = Color.Red;
                    }
                }
                    ctr.Controls.Add(btn2);
                btn2.Click += btn2_Click;

            }
        }

        void btn2_Click(object sender, EventArgs e)
        {
            btn1_Click(sender, e);
        }
        #endregion

        public void loadSodoxe40(Control ctr, int a, string c)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("exec USP_TenChoNgoi @idChuyen='" + c + "'");
            Button cubtn = new Button() { Width = 0, Location = new Point(0, 100) };
            int tam = 0;
            string[] flag = new string[45];
            while (true)
            {
                try
                {
                    flag[tam] = data.Rows[tam++].ItemArray[0].ToString();
                }
                catch
                {
                    break;
                }
            }
            for (int i = 0; i < a; i++)
            {
                Button btn3 = new Button();
                btn3.Tag = i.ToString();
                btn3.BackColor = Color.Silver;
                if (i == 0)
                {
                    btn3.Location = new System.Drawing.Point(20, 20);
                    btn3.Size = new System.Drawing.Size(45, 34);
                    btn3.Text = "Tài Xế";
                    btn3.Enabled = false;
                }
                else
                {
                    btn3.Text = i.ToString();

                }

                if (i == 1)
                {
                    btn3.Location = new System.Drawing.Point(44, 110);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }
                if (i == 2)
                {
                    btn3.Location = new System.Drawing.Point(139, 110);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }
                ///12322
                if (i == 3)
                {
                    btn3.Location = new  System.Drawing.Point(234, 110);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                // button4
                // 
                if (i == 4)
                {
                    btn3.Location = new System.Drawing.Point(44, 170);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                // button5
                // 
                if (i == 5)
                {
                    btn3.Location = new System.Drawing.Point(139, 170);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                if (i == 6)
                {
                    btn3.Location = new System.Drawing.Point(234, 170);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                // button7
                // 
                if (i == 7)
                {
                    btn3.Location = new System.Drawing.Point(44, 226);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                // button8
                // 
                if (i == 8)
                {
                    btn3.Location = new System.Drawing.Point(139, 226);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button9
                // 
                if (i == 9)
                {
                    btn3.Location = new System.Drawing.Point(234, 226);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                // button10
                // 
                if (i == 10)
                {
                    btn3.Location = new System.Drawing.Point(44, 279);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                // button11
                // 
                if (i == 11)
                {
                    btn3.Location = new System.Drawing.Point(139, 279);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button12
                // 
                if (i == 12)
                {
                    btn3.Location =  new System.Drawing.Point(234, 279);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button13
                // 
                if (i == 13)
                {
                    btn3.Location = new System.Drawing.Point(44, 335);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                // button14
                // 
                if (i == 14)
                {
                    btn3.Location = new System.Drawing.Point(139, 335);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                // button15
                // 
                if (i == 15)
                {
                    btn3.Location = new System.Drawing.Point(234, 335);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                if (i == 16)
                {
                    btn3.Location = new System.Drawing.Point(44, 389);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                if (i == 17)
                {
                    btn3.Location = new System.Drawing.Point(92, 389);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                // button18
                // 
                if (i == 18)
                {
                    btn3.Location = new System.Drawing.Point(234, 389);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button19
                // 
                if (i == 19)
                {
                    btn3.Location = new System.Drawing.Point(139, 389);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button20
                // 
                if (i == 20)
                {
                    btn3.Location = new System.Drawing.Point(187, 389);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                if (i == 21)
                {
                    btn3.Location = new System.Drawing.Point(337, 110);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                // button22
                // 
                if (i == 22)
                {
                    btn3.Location = new System.Drawing.Point(432, 110);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button23
                // 
                if (i == 23)
                {
                    btn3.Location = new System.Drawing.Point(337, 170);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                if (i == 24)
                {
                    btn3.Location = new System.Drawing.Point(432, 170);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button25
                // 
                if (i == 25)
                {
                    btn3.Location = new System.Drawing.Point(337, 226);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button26
                // 
                if (i == 26)
                {
                    btn3.Location = new System.Drawing.Point(432, 226);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button27
                // 
                if (i == 27)
                {
                    btn3.Location = new System.Drawing.Point(337, 279);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button28
                // 
                if (i == 28)
                {
                    btn3.Location = new System.Drawing.Point(432, 279);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button29
                // 
                if (i == 29)
                {
                    btn3.Location = new System.Drawing.Point(337, 335);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                if (i == 30)
                {
                    btn3.Location = new System.Drawing.Point(432, 335);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                if (i == 31)
                {
                    btn3.Location = new System.Drawing.Point(337, 389);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                if (i == 32)
                {
                    btn3.Location = new System.Drawing.Point(385, 389);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button33
                // 
                if (i == 33)
                {
                    btn3.Location = new System.Drawing.Point(432, 389);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button34
                // 
                if (i == 34)
                {
                    btn3.Location = new System.Drawing.Point(480, 389);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                if (i == 35)
                {
                    btn3.Location = new System.Drawing.Point(527, 110);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button36
                // 
                if (i == 36)
                {
                    btn3.Location = new System.Drawing.Point(527, 170);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                if (i == 37)
                {
                    btn3.Location = new System.Drawing.Point(527, 226);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// 
                if (i == 38)
                {
                    btn3.Location = new System.Drawing.Point(527, 279);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button39
                // 
                if (i == 39)
                {
                    btn3.Location = new System.Drawing.Point(527, 335);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }// button40
                // 
                if (i == 40)
                {
                    btn3.Location = new System.Drawing.Point(527, 389);
                    btn3.Size = new System.Drawing.Size(45, 34);
                }



                for (int m = 0; m < tam; m++)
                {
                    if (btn3.Text == flag[m])
                        btn3.BackColor = Color.Blue;
                }
                ctr.Controls.Add(btn3);
                btn3.Click += btn3_Click;

            }
        }

        void btn3_Click(object sender, EventArgs e)
        {
            btn1_Click(sender, e);
        }
       
       

    }
}
