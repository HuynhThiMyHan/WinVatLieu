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

        public int capnhatHD(String mahd, DateTime ngaylap, Double giamgia, Double tongtien, String tenkh, String tinhtrang)
        {
            return hd.capnhat(mahd, ngaylap, giamgia, tongtien, tenkh, tinhtrang);
        }
    }
}
