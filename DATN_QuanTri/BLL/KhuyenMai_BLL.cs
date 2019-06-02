using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
   public class KhuyenMai_BLL
    {
        KhuyenMai_DAL km = new KhuyenMai_DAL();
        public DataTable loadDL()
        {
            return km.loadDL();
        }

        public int themKM(String MaKM, String TenKM, DateTime NgayBD, DateTime NgayKT, String HTKM)
        {
            return km.themKM(MaKM, TenKM, NgayBD, NgayKT, HTKM);
        }

        public int xoaKM(String MaKM, String TenKM, DateTime NgayBD, DateTime NgayKT, String HTKM)
        {
            return km.xoaKM(MaKM, TenKM, NgayBD, NgayKT, HTKM);
        }
    }
}
