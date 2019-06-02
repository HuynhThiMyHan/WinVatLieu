using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   
  public class NhaCungCap_DAL
    {
        NHACUNGCAPTableAdapter ncc = new NHACUNGCAPTableAdapter();

        public DataTable loadDuLieu_NCC()
        {
            return ncc.GetData();
        }

        public int themNCC(String MaNCC,String TenNCC,String DiaChi,String SDT)
        {
            return ncc.Insert(MaNCC, TenNCC, DiaChi, SDT);
        }

        public int xoaNCC(String MaNCC, String TenNCC, String DiaChi, String SDT)
        {
            return ncc.XoaNCC(MaNCC,TenNCC,DiaChi,SDT);
        }

        //public int suaNCC(String MaNCC, String TenNCC, String DiaChi, String SDT)
        //{
        //    return ncc.SuaNCC(TenNCC, DiaChi, SDT, MaNCC);
        //}
        //public String kt_Trung(String MaNCC)
        //{
        //    return ncc.KT_Trung(MaNCC).ToString();
        //}
    }
}
