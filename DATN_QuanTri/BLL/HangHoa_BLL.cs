using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
   public class HangHoa_BLL
    {
        HangHoa_DAL hh = new HangHoa_DAL();
        public DataTable loadDL()
        {
            return hh.loadDL();
        }
        public int themHH(String mahang, String tenhang, String maloai, String dvt, String mota, String hinh, String mau, Double gianhap, Double giaban, DateTime ngaytao, int soluong, string noibat, int luotxem, String tinhtrang)
        {
            return hh.themHH(mahang, tenhang, maloai, dvt, mota, hinh, mau, (gianhap), (giaban), ngaytao, (soluong), noibat, (luotxem), tinhtrang);
        }

        public int xoaHH(String mahang, String tenhang, String maloai, String dvt, String mota, String hinh, String mau, Double gianhap, Double giaban, DateTime ngaytao, int soluong, string noibat, int luotxem, String tinhtrang)
        {
            return hh.xoaHH(mahang, tenhang, maloai, dvt, mota, hinh, mau, (gianhap), (giaban), ngaytao, (soluong), noibat, (luotxem), tinhtrang);
        }
    }
}
