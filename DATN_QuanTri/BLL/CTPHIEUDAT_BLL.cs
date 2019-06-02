using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace BLL
{
   public class CTPHIEUDAT_BLL
    {
        CTPHIEUDAT_DAL ctpd = new CTPHIEUDAT_DAL();
        public DataTable loadCTPD()
        {
            return ctpd.loadCTPD();
        }

        public int themctpd(String mapd, String mahang, String mamau, int soluong, Double gianhap)
        {
            return ctpd.themctpd(mapd, mahang, mamau, soluong, gianhap);
        }
    }
}
