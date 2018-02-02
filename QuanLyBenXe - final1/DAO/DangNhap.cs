using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DangNhap
    {
        private static DangNhap instance;

        public static DangNhap Instance
        {
            get { if (instance==null)instance=new DangNhap(); return instance; }
            set { instance = value; }
        }
        private DangNhap() { }

        public bool login(string user,string pass)
        {
            string query = "USP_DangNhap @user , @pass ";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] {user,pass });

            return result.Rows.Count>0;
        }
    }
}
