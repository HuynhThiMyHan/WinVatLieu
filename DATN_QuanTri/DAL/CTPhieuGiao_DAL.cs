using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class CTPhieuGiao_DAL
    {
        CTPHIEUGIAOTableAdapter ctpg = new CTPHIEUGIAOTableAdapter();
        public DataTable loadCTPG()
        {
            return ctpg.GetData();
        }
        public int themctpg(String mapg,String mahang, String mamau, float dongia,int soluong)
        {
            return ctpg.ThemCTPG(mapg, mahang, mamau, dongia, soluong);
        }
    }
}
