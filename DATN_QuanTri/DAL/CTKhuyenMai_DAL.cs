using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class CTKhuyenMai_DAL
    {
        CTKHUYENMAITableAdapter ctkm = new CTKHUYENMAITableAdapter();
        public DataTable loadDL()
        {
            return ctkm.GetData();
        }

        public int themctkm(String makm,String mahang,String mamau,String sptang,int soluong,String giabangiam)
        {
            return ctkm.ThemCTKM(makm, mahang, mamau, sptang, soluong,Double.Parse( giabangiam));
        }

        public int xoactkm(String makm, String mahang, String mamau, String sptang, int soluong, String giabangiam)
        {
            return ctkm.XoaCTKM(makm, mahang, mamau, sptang, soluong, Double.Parse(giabangiam));
        }
    }
}
