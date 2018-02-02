using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Xe
    {
        public Xe(string so_Xe,string hieu_Xe, string doi_Xe,string so_Cho_Ngoi)
        {
            this.So_Xe = so_Xe;
            this.Hieu_Xe = hieu_Xe;
            this.Doi_Xe = doi_Xe;
            this.So_Cho_Ngoi = so_Cho_Ngoi;
        }
        public Xe (DataRow row)
        {
            this.So_Xe = row["So_Xe"].ToString();
            this.Hieu_Xe = row["Hieu_Xe"].ToString();
            this.Doi_Xe = row["Doi_Xe"].ToString();
            this.So_Cho_Ngoi = row["So_Cho_Ngoi"].ToString();
        }

        public Xe()
        {
            // TODO: Complete member initialization
        }
        private string so_Cho_Ngoi;

        public string So_Cho_Ngoi
        {
            get { return so_Cho_Ngoi; }
            set { so_Cho_Ngoi = value; }
        }
        
        private string doi_Xe;

        public string Doi_Xe
        {
            get { return doi_Xe; }
            set { doi_Xe = value; }
        }

        private string hieu_Xe;

        public string Hieu_Xe
        {
            get { return hieu_Xe; }
            set { hieu_Xe = value; }
        }

        private string so_Xe;

        public string So_Xe
        {
            get { return so_Xe; }
            set { so_Xe = value; }
        }
    }
}
