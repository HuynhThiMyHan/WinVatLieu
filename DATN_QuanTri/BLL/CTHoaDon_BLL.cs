using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
  public  class CTHoaDon_BLL
    {

        CTHoaDon_DAL cthd = new CTHoaDon_DAL();

        public DataTable loadCTHD()
        {
            return cthd.loadCTHD();
                }
    }
}
