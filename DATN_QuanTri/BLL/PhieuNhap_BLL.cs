using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public class PhieuNhap_BLL
    {
        PhieuNhap_DAL pn = new PhieuNhap_DAL();
        public DataTable loadPN()
        {
            return pn.loadPN();
        }

        public int themPN(String mapn, String mancc, String manv, DateTime ngaynhap, Double tongtien, String tinhtrang)
        {
            return pn.thempn(mapn, mancc, manv, ngaynhap, tongtien, tinhtrang);
        }
    }

}
