using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Saradnik : Korisnik
    {
        static int ID = 1;
        int id;
        List<Usluga> mojeusluge = new List<Usluga>();
        string adresa;

        public Saradnik(string naziv, string sifra, string korisnickoime, string brojkartice, string adr) : base(naziv, sifra, korisnickoime, brojkartice)
        {
            ID++;
            id = ID;
            MojeUsluge = new List<Usluga>();
            Adresa = adr;
        }

        public List<Usluga> MojeUsluge { get => mojeusluge; set => mojeusluge = value; }
        public int Id { get => id; }
        public string Adresa { get => adresa; set => adresa = value; }
    }
}
