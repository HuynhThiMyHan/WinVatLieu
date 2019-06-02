using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
   public class PhieuGiao_BLL
    {
        PhieuGiao_DAL pg = new PhieuGiao_DAL();
        public DataTable loadPG()
        {
            return pg.loadPG();
        }
        public int themPG(String mapg, String mahd, String ngaygiao, String diachigiao, String tennv, String sdtnguoigiao, String tinhtrang, String tennguoinhan, String sdtnguoinhan)
        {
            return pg.themPG(mapg, mahd, ngaygiao, diachigiao, tennv, sdtnguoigiao, tinhtrang, tennguoinhan, sdtnguoinhan);
        }
        public int capnhatPG(String mapg, String mahd, String ngaygiao, String diachigiao, String tennv, String sdtnguoigiao, String tinhtrang, String tennguoinhan, String sdtnguoinhan)
        {
            return pg.capnhatPG(mapg, mahd,ngaygiao, diachigiao, tennv, sdtnguoigiao, tinhtrang, tennguoinhan, sdtnguoinhan);
        }

    }
}
