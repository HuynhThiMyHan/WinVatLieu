using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public class HoaDon_BLL
    {
        HoaDon_DAL hd = new HoaDon_DAL();

        public DataTable loadHD()
        {
            return hd.loadHD();
        }

        public int suaHD(String mahd, String makh, DateTime ngaylap, Double giamgia, String tenkh, String diachi, String sdt, Double tongtien, String tinhtrang)
        {
            return hd.suaHD(mahd, makh, ngaylap, giamgia, tenkh, diachi, sdt, tongtien, tinhtrang);
        }
    }
}
