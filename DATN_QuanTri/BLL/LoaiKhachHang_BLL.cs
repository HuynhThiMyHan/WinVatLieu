using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
   public class LoaiKhachHang_BLL
    {
        LoaiKhachHang_DAL lkh = new LoaiKhachHang_DAL();

        public DataTable loadDl()
        {
            return lkh.loadDl();
        }
        public int themLKH(String maloai, String tenloai, float mucgiam)
        {
            return lkh.themLKH(maloai, tenloai, mucgiam);
        }
        public int xoaLKH(String maloai, String tenloai, float mucgiam)
        {
            return lkh.xoaLKH(maloai, tenloai, mucgiam);
        }
    }
}
