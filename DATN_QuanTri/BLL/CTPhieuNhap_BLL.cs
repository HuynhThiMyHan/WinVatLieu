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
        public int themCTPN(String mapn, String mapd, String mahang, String mamau, int sl)
        {
            return ctpn.themCTPN(mapn, mapd, mahang, mamau, sl);
        }
    }
}
