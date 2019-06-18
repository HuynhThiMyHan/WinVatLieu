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
       public int suaHD(String mahd,String makh,DateTime ngaylap,Double giamgia,String tenkh,String diachi,String sdt,Double tongtien,String tinhtrang)
        {
            return hd.SuaHD(mahd, makh, ngaylap, giamgia, tenkh, diachi, sdt, tongtien, tinhtrang);
        }

    }
}
