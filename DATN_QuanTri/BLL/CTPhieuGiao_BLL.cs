using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public class CTPhieuGiao_BLL
    {
        CTPhieuGiao_DAL ctpg = new CTPhieuGiao_DAL();
        public DataTable loadCTPG()
        {
            return ctpg.loadCTPG();
        }
        public int themctpg(String mapg, String mahang, String mamau, float dongia, int soluong)
        {
            return ctpg.themctpg(mapg, mahang, mamau, dongia, soluong);
        }
    }
}
