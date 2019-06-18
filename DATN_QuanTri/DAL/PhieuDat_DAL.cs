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
        public int themPD(String mapd, String mancc, String manv, String ngaydat,  String tinhtrang)
        {
            return pd.ThemPD(mapd, mancc, manv,DateTime.Parse(ngaydat),  tinhtrang);
        }
        public int Capnhat_thanhtienPD(String mapd,Double thanhtien)
        {
            return pd.CapNhat_thanhtienPD(thanhtien, mapd);
        }

    
    }
}
