using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class QuyCach_DAL
    {
        QUYCACHTableAdapter qc = new QUYCACHTableAdapter();
       public DataTable loadQC()
        {
            return qc.GetData();
        }

        public int themQC(String mahh,String kichthuoc,int dientich,int tamtrenhop,int trongluong,String xuatxu)
        {
            return qc.ThemQC(mahh, kichthuoc, dientich, tamtrenhop, trongluong, xuatxu);
        }

        public int xoaQC(String mahh, String kichthuoc, int dientich, int tamtrenhop, int trongluong, String xuatxu)
        {
            return qc.XoaQC(mahh, kichthuoc, dientich, tamtrenhop, trongluong, xuatxu);
        }
    }
}
