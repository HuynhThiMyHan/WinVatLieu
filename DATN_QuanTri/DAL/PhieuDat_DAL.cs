using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class PhieuDat_DAL
    {
        PHIEUDATTableAdapter pd = new PHIEUDATTableAdapter();
        public DataTable loadPD()
        {
            return pd.GetData();
        }
        public int themPD(String mapd, String mancc, String manv, String ngaydat, float tongtien, String tinhtrang)
        {
            return pd.ThemPD(mapd, mancc, manv,DateTime.Parse(ngaydat), tongtien, tinhtrang);
        }
        
    }
}
