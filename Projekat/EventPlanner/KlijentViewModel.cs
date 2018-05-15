using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class KlijentViewModel
    {
        Klijent klijent;
        public KlijentViewModel(Klijent klijent)
        {
            this.klijent = klijent;
        }

        public string Ime { get { return klijent.Naziv; } set { klijent.Naziv = value; } }
        public string KorisnickoIme { get { return klijent.KorisnickoIme; } set { klijent.KorisnickoIme = value; } }
        public string Sifra { get { return klijent.Sifra; } set { klijent.Sifra = value; } }
        public string BrojKartice { get { return klijent.BrojKartice; } set { klijent.BrojKartice = value; } }
        public Klijent Klijent { get { return klijent; } }
    }
}
