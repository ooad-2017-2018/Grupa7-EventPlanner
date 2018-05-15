using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Korisnik
    {
        private string naziv;
        private string sifra;
        private string korisnickoime;
        private string brojkartice;

        public Korisnik(string naziv, string sifra, string korisnickoime, string brojkartice)
        {
            
            Sifra = sifra;
            KorisnickoIme = korisnickoime;
            BrojKartice = brojkartice;
            Naziv = naziv;
        }

        public string Sifra { get => sifra; set => sifra = value; }
        public string KorisnickoIme { get => korisnickoime; set => korisnickoime = value; }
        public string BrojKartice { get => brojkartice; set => brojkartice = value; }
        public string Naziv { get => naziv; set => naziv = value; }
    }
}
