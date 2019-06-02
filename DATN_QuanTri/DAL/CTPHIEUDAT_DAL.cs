using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class CTPHIEUDAT_DAL
    {
        CT_PHIEUDATTableAdapter ctpd = new CT_PHIEUDATTableAdapter();
        public DataTable loadCTPD()
        {
            return ctpd.GetData();
        }

       public int themctpd(String mapd,String mahang,String mamau,int soluong,Double gianhap)
        {
            return ctpd.ThemCTPD(mapd, mahang, mamau, soluong, gianhap);
        }
    }
}
