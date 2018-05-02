using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Usluga
    {
        int idsaradnika;
        double cijena;
        string naziv;
        int idusluge;

        public string Naziv { get => naziv; set => naziv = value; }
        public int IDusluge { get => idusluge; set => idusluge = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public int IDsaradnika { get => idsaradnika; set => idsaradnika = value; }
    }
}
