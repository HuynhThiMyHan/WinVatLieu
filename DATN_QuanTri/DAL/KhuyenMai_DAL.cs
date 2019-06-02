using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhuyenMai_DAL
    {
        KHUYENMAITableAdapter km = new KHUYENMAITableAdapter();
        public DataTable loadDL()
        {
            return km.GetData();
        }

        public int themKM(String MaKM,String TenKM,DateTime NgayBD,DateTime NgayKT,String HTKM)
        {
            return km.ThemKM(MaKM, TenKM, NgayBD, NgayKT, HTKM);
        }

        public int xoaKM(String MaKM, String TenKM, DateTime NgayBD, DateTime NgayKT, String HTKM)
        {
            return km.XoaKM(MaKM, TenKM, NgayBD, NgayKT, HTKM);
        }
    }
}
