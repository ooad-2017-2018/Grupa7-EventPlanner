using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Klijent : Korisnik
    {
        public List<Rezervacija> mojerezervacije = new List<Rezervacija>();
        public List<Rezervacija> MojeRezervacije { get => mojerezervacije; set => mojerezervacije = value; }
    }
}
