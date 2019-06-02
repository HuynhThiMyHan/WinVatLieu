using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class PhieuGiao_DAL
    {
        PHIEUGIAOTableAdapter pg = new PHIEUGIAOTableAdapter();
        public DataTable loadPG()
        {
            return pg.GetData();
        }
        public int themPG(String mapg, String mahd, String ngaygiao, String diachigiao, String tennv, String sdtnguoigiao, String tinhtrang, String tennguoinhan, String sdtnguoinhan)
        {
            return pg.ThemPG(mapg, mahd, DateTime.Parse(ngaygiao), diachigiao, tennv, sdtnguoigiao, tinhtrang, tennguoinhan, sdtnguoinhan);
        }
        public int capnhatPG(String mapg,String mahd,String ngaygiao,String diachigiao,String tennv,String sdtnguoigiao,String tinhtrang,String tennguoinhan,String sdtnguoinhan)
        {
            return pg.CapNhatPG(mapg, mahd,DateTime.Parse(ngaygiao),diachigiao, tennv, sdtnguoigiao, tinhtrang, tennguoinhan, sdtnguoinhan);
        }

       
    }
}
