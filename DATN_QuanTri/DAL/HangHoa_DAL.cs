using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class HangHoa_DAL
    {
        HANGHOATableAdapter hh = new HANGHOATableAdapter();
        public DataTable loadDL()
        {
            return hh.GetData();
        }

        public int themHH(String mahang,String tenhang,String maloai,String dvt,String mota,String hinh,String mau,Double gianhap, Double giaban, DateTime ngaytao,int soluong,string noibat,int luotxem,String tinhtrang)
        {
            return hh.ThemHH(mahang, tenhang, maloai, dvt, mota, hinh, mau,(gianhap),(giaban),ngaytao, (soluong),DateTime.Parse(noibat),(luotxem), tinhtrang);
        }

        public int xoaHH(String mahang,String tenhang, String maloai,String dvt, String mota,String hinh, String mau, Double gianhap, Double giaban,DateTime ngaytao, int soluong,string noibat,int luotxem, String tinhtrang)
        {
            return hh.XoaHH(mahang, tenhang, maloai, dvt, mota, hinh, mau, (gianhap),(giaban),ngaytao,(soluong), DateTime.Parse(noibat), (luotxem), tinhtrang);
        }
    }
}
