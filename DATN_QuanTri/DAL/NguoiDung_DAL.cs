using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class NguoiDung_DAL
    {
        NGUOIDUNGTableAdapter nd = new NGUOIDUNGTableAdapter();
        public DataTable loaddL()
        {
            return nd.GetData();
        }
    }
}
