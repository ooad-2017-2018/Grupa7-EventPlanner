using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Usluga
    {
        static int ID = 1;
        int idsaradnika;
        double cijena;
        string naziv;
        int idusluge;
        string vrsta;

        public string Naziv { get => naziv; set => naziv = value; }
        public int IDusluge { get => idusluge; }
        public double Cijena { get => cijena; set => cijena = value; }
        public int IDsaradnika { get => idsaradnika; }
        public string Vrsta { get => vrsta; set => vrsta = value; }

        public Usluga(int idsaradnika, double cijena, string naziv, string vrsta)
        {
            ID++;
            idusluge = ID;
            this.idsaradnika = idsaradnika;
            Vrsta = vrsta;
            Naziv = naziv;
            Cijena = cijena;
        }
    }
}
