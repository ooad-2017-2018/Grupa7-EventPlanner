using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class UslugaViewModel
    {
        Usluga usluga;
        public UslugaViewModel(Usluga usluga)
        {
            this.usluga = usluga;
        }

        public string Naziv { get { return usluga.Naziv; } set { usluga.Naziv = value; } }
        public int IDusluge { get { return usluga.IDusluge; } set { usluga.IDusluge = value; } }
        public int IDsaradnika { get { return usluga.IDsaradnika; } set { usluga.IDsaradnika = value; } }
        public double Cijena { get { return usluga.Cijena; } set { usluga.Cijena = value; } }
        public Usluga Usluga { get { return usluga; } }
    }
}
