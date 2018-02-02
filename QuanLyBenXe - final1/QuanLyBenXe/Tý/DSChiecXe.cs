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
    public partial class DSChiecXe : UserControl
    {
        public DSChiecXe()
        {
            InitializeComponent();
            LoadDS a = new LoadDS();
            gridDSXe.DataSource = a.LoadDSXe();
        }
    }
}
