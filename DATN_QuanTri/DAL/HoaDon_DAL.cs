using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
   public class HoaDon_DAL
    {
        HOADONTableAdapter hd = new HOADONTableAdapter();
        public DataTable loadHD()
        {
            return hd.GetData();
        }
       public int capnhat(String mahd, DateTime ngaylap,Double giamgia, Double tongtien, String tenkh,String tinhtrang)
        {
            return hd.CapNhatHD(mahd, ngaylap, giamgia, tongtien, tenkh, tinhtrang);
        }

    }
}
