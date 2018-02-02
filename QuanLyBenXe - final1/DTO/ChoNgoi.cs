using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChoNgoi
    {

        public ChoNgoi(string idChuyen,string soxe,string tenchongoi)
        {
            this.IdChuyen = idChuyen;
            this.So_Xe = soxe;
            this.TenChoNgoi = tenchongoi;
        }
        
        string idChuyen;

        public string IdChuyen
        {
            get { return idChuyen; }
            set { idChuyen = value; }
        }
        string so_Xe;

        public string So_Xe
        {
            get { return so_Xe; }
            set { so_Xe = value; }
        }
        string tenChoNgoi;

        public string TenChoNgoi
        {
            get { return tenChoNgoi; }
            set { tenChoNgoi = value; }
        }
    }
}
