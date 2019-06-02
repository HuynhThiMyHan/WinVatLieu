using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public class NguoiDung_BLL
    {
        NguoiDung_DAL nd = new NguoiDung_DAL();
        public DataTable loaddl()
        {
            return nd.loaddL();
        }
    }
}
