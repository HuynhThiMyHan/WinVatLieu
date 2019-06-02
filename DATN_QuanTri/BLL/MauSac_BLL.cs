using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public class MauSac_BLL
    {
        MauSac_DAL ms = new MauSac_DAL();
        public DataTable loaddl()
        {
            return ms.loaddl();
        }

        public int themms(String mamau, String tenmau)
        { return ms.themms(mamau, tenmau); }

        public int xoams(String mamau, String tenmau)
        { return ms.xoams(mamau, tenmau); }
    }
}
