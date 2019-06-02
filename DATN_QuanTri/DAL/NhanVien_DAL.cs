using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVien_DAL
    {
        NHANVIENTableAdapter nv = new NHANVIENTableAdapter();

        public DataTable loadDL()
        {
            return nv.GetData();
        }

       
        public int themNV(String MaNV, String TenNV, String Ngaysinh, String Quyen, String GioiTinh, String hinh,String DiaChi, String CMND, String Email, DateTime ngaytao,String SDT,String mk)
        {
            return nv.ThemNV(MaNV, TenNV,DateTime.Parse( Ngaysinh), Quyen, GioiTinh, hinh,DiaChi, CMND, Email, ngaytao,SDT,mk);
        }

        public int xoaNV(String MaNV, String TenNV, String Ngaysinh, String Quyen, String GioiTinh, String hinh, String DiaChi, String CMND, String Email, DateTime ngaytao, String SDT, String mk)
        {
            return nv.XoaNV(MaNV, TenNV, DateTime.Parse(Ngaysinh), Quyen, GioiTinh, hinh, DiaChi, CMND, Email, ngaytao, SDT, mk);
        }

    }
}
