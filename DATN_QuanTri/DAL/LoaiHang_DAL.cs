using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class LoaiHang_DAL
    {
        LOAIHANGTableAdapter lh = new LOAIHANGTableAdapter();
        public DataTable loadDL()
        {
            return lh.GetData();
        }
        //public String kt_trung(String MaLoai,String TenLoai)
        //{
        //    return lh.KT_Trung(MaLoai).ToString();
        //}
        public int themlh(String MaLoai, String TenLoai)
        {
            return lh.ThemLH(MaLoai, TenLoai);
        }

        public int xoalh(String MaLoai, String TenLoai)
        {
            return lh.XoaLH(MaLoai, TenLoai);
        }

        //public int sualh(String MaLoai, String TenLoai)
        //{
        //    return lh.SuaLH(MaLoai, TenLoai);
        //}
    }
}
