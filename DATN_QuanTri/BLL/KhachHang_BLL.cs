using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public class KhachHang_BLL
    {
        KhachHang_DAL kh = new KhachHang_DAL();
        public DataTable loadKH()
        {
            return kh.loadKH();
        }
     
    }
}
