using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class MauSac_DAL
    {
        MAUSACTableAdapter ms = new MAUSACTableAdapter();
        public DataTable loaddl()
        {
            return ms.GetData();
        }

        public int themms(String mamau,String tenmau)
        { return ms.ThemMS(mamau, tenmau); }

        public int xoams(String mamau,String tenmau)
        { return ms.XoaMS(mamau, tenmau); }
    }
}
