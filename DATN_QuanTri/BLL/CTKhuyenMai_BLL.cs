using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
  public  class CTKhuyenMai_BLL
    {
        CTKhuyenMai_DAL ctkm = new CTKhuyenMai_DAL();
        public DataTable loadDL()
        {
            return ctkm.loadDL();
        }

        public int themCTKM(String makm, String mahang, String mamau, String sptang, int soluong, String giabangiam)
        {
            return ctkm.themctkm(makm, mahang, mamau, sptang, soluong, giabangiam);
        }
        public int xoCTKM(String makm, String mahang, String mamau, String sptang, int soluong, String giabangiam)
        {
            return ctkm.xoactkm(makm, mahang, mamau, sptang, soluong, giabangiam);
        }
    }
}
