using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Klijent : Korisnik
    {
        private List<Rezervacija> mojerez;
        static int ID = 1;
        private int id;
            
        public Klijent(string naziv, string sifra, string korisnickoime, string brojkartice) : base(naziv, sifra, korisnickoime, brojkartice)
        {
            Mojerez = new List<Rezervacija>();
            ID++;
            id = ID;
        }

        public List<Rezervacija> Mojerez { get => mojerez; set => mojerez = value; }
        public int Id { get => id; }
    }
}
