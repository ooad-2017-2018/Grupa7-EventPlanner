using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class SaradnikViewModel
    {
        Saradnik saradnik;
        public SaradnikViewModel(Saradnik saradnik)
        {
            this.saradnik = saradnik;
        }

        public string Ime { get { return saradnik.Ime; } set { saradnik.Ime = value; } }
        public string Prezime { get { return saradnik.Prezime; } set { saradnik.Prezime = value; } }
        public string KorisnickoIme { get { return saradnik.KorisnickoIme; } set { saradnik.KorisnickoIme = value; } }
        public string Sifra { get { return saradnik.Sifra; } set { saradnik.Sifra = value; } }
        public string BrojKartice { get { return saradnik.BrojKartice; } set { saradnik.BrojKartice = value; } }
        public int IDbroj { get { return saradnik.IDbroj; } set { saradnik.IDbroj = value; } }
        public Saradnik Saradnik { get { return saradnik; } }
    }
}
