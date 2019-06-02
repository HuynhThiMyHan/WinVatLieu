using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public class NhanVien_BLL
    {
        NhanVien_DAL nv = new NhanVien_DAL();
        public DataTable loadDL()
        {
            return nv.loadDL();
        }

        public int themNV(String MaNV, String TenNV, String Ngaysinh, String Quyen, String GioiTinh, String hinh, String DiaChi, String CMND, String Email, DateTime ngaytao, String SDT,String mk)
        {
            return nv.themNV(MaNV, TenNV, Ngaysinh, Quyen, GioiTinh, hinh, DiaChi, CMND, Email, ngaytao, SDT,mk);
        }

        public int xoaNV(String MaNV, String TenNV, String Ngaysinh, String Quyen, String GioiTinh, String hinh, String DiaChi, String CMND, String Email, DateTime ngaytao, String SDT,String mk)
        {
            return nv.xoaNV(MaNV, TenNV,Ngaysinh, Quyen, GioiTinh, hinh, DiaChi, CMND, Email, ngaytao, SDT,mk);
        }
    }
}
