using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace BLL
{
    public class NhaCungCap_BLL
    {
        NhaCungCap_DAL ncc = new NhaCungCap_DAL();
        public DataTable loadDulieu_NCC()
        {
            return ncc.loadDuLieu_NCC();
        }
        public int ThemNCC(String MaNCC, String TenNCC, String DiaChi, String SDT)
        {
            return ncc.themNCC(MaNCC, TenNCC, DiaChi, SDT);
        }
        public int XoaNCC(String MaNCC, String TenNCC, String DiaChi, String SDT)
        {
            return ncc.xoaNCC(MaNCC, TenNCC, DiaChi, SDT);
        }

        //public String KT_Trung(String MaNCC, String TenNCC, String DiaChi, String SDT)
        //{
        //    return ncc.kt_Trung(MaNCC);
        //}
        // public int SuaNCC(String MaNCC, String TenNCC, String DiaChi, String SDT)
        //{
        //    return SuaNCC(MaNCC, TenNCC, DiaChi, SDT);
        //}
    }
}
