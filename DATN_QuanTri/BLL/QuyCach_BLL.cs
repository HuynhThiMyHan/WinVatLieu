using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
  public  class QuyCach_BLL
    {
        QuyCach_DAL qc = new QuyCach_DAL();

        public DataTable loadQC()
        {
            return qc.loadQC();
        }

        public int themQC(String mahh, String kichthuoc, int dientich, int tamtrenhop, int trongluong, String xuatxu)
        {
            return qc.themQC(mahh, kichthuoc, dientich, tamtrenhop, trongluong, xuatxu);
        }

        public int xoaQC(String mahh, String kichthuoc, int dientich, int tamtrenhop, int trongluong, String xuatxu)
        {
            return qc.xoaQC(mahh, kichthuoc, dientich, tamtrenhop, trongluong, xuatxu);
        }
    }
}
