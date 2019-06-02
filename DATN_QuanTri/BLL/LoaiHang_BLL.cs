using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
 public   class LoaiHang_BLL
    {
        LoaiHang_DAL lh = new LoaiHang_DAL();
        public DataTable loaddL()
        {
            return lh.loadDL();
        }
        //public String Kt_Trung(String MaLoai, String TenLoai)
        //{
        //    return lh.kt_trung(MaLoai,TenLoai);
        //}

        public int themlh(String MaLoai, String TenLoai)
        {
            return lh.themlh(MaLoai, TenLoai);
        }
        public int xoalh(String MaLoai, String TenLoai)
        {
            return lh.xoalh(MaLoai, TenLoai);
        }

       
    }
}
