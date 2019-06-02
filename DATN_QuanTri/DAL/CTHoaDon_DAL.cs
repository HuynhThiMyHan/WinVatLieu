using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
  public  class CTHoaDon_DAL
    {
        CT_HOADONTableAdapter cthd = new CT_HOADONTableAdapter();

        public DataTable loadCTHD()
        {
            return cthd.GetData();
        }
    }
}
