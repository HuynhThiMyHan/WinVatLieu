using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class PhieuNhap_DAL
    {
        PHIEUNHAPTableAdapter pn = new PHIEUNHAPTableAdapter();

        public DataTable loadPN()
        {
            return pn.GetData();
        }

        public int thempn(String mapn,String mancc,String manv,DateTime ngaynhap,Double tongtien,String tinhtrang)
        {
            return pn.ThemPN(mapn, mancc, manv, ngaynhap, tongtien, tinhtrang);
        }
    }
}
