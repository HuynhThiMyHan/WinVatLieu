using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class KhachHang_DAL
    {
        KHTableAdapter kh = new KHTableAdapter();
        public DataTable loadKH()
        {
            return kh.GetData();
        }

     
    }
}
