using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public class PhieuDat_BLL
    {
        PhieuDat_DAL pd = new PhieuDat_DAL();
        public DataTable loadPD()
        {
            return pd.loadPD();
        }

        public int themPD(String mapd, String mancc, String manv, String ngaydat, String tinhtrang)
        {
            return pd.themPD(mapd, mancc, manv, ngaydat,  tinhtrang);
        }
        public int Capnhat_thanhtienPD(String mapd, Double thanhtien)
        {
            return pd.Capnhat_thanhtienPD(mapd, thanhtien);
        }

    }
}
