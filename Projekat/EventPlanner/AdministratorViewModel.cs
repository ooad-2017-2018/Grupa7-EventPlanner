using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class AdministratorViewModel
    {
        Administrator klijent;
        public AdministratorViewModel(Administrator klijent)
        {
            this.klijent = klijent;
        }
        public string KorisnickoIme { get { return klijent.KorisnickoIme; } set { klijent.KorisnickoIme = value; } }
        public string Sifra { get { return klijent.Sifra; } set { klijent.Sifra = value; } }
        public string BrojKartice { get { return klijent.BrojKartice; } set { klijent.BrojKartice = value; } }
        public Administrator Administrator { get { return klijent; } }
    }
}
