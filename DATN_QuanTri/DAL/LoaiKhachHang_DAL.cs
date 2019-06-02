using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class LoaiKhachHang_DAL
    {
        LOAIKHACHHANGTableAdapter lkh = new LOAIKHACHHANGTableAdapter();

        public DataTable loadDl()
        {
            return lkh.GetData();
        }
        public int themLKH(String maloai,String tenloai,float mucgiam)
        {
            return lkh.ThemLKH(maloai, tenloai, mucgiam);
        }

        public int xoaLKH(String maloai, String tenloai, float mucgiam)
        {
            return lkh.XoaLKH(maloai, tenloai, mucgiam);
        }
    }
}
