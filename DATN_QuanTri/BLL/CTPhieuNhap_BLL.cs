using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
  public  class CTPhieuNhap_BLL
    {
        CTPhieuNhap_DAL ctpn = new CTPhieuNhap_DAL();
       
        
        public DataTable loadCTPN()
        {
            return ctpn.loadCTPN();
        }
        public int themCTPN(String mapn, String mahang, String mamau, int sl, Double dongia)
        {
            return ctpn.themCTPN(mapn, mahang, mamau, sl, dongia);
        }

        public String demMaPN(String mapn)
        {
            return ctpn.demMaPN(mapn).ToString();
        }

        public String tongtien(String mapn)
        {
            return ctpn.tongtien(mapn).ToString();
        }
    }
}
