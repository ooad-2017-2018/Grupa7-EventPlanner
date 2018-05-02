using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Korisnik
    {
        private string ime;
        private string prezime;
        private string sifra;
        private string korisnickoime;
        private string brojkartice;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Sifra { get => sifra; set => sifra = value; }
        public string KorisnickoIme { get => korisnickoime; set => korisnickoime = value; }
        public string BrojKartice { get => brojkartice; set => brojkartice = value; }

    }
}
