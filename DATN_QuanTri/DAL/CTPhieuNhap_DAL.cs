using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
  public  class CTPhieuNhap_DAL
    {
        CT_PHIEUNHAPTableAdapter ctpn = new CT_PHIEUNHAPTableAdapter();

        public DataTable loadCTPN()
        {
            return ctpn.GetData();
        }

        public int themCTPN(String mapn,String mapd,String mahang,String mamau,int sl)
        {
            return ctpn.ThemCTPN(mapn, mapd, mahang, mamau, sl);
        }
    }
}
