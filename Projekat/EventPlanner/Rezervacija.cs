using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Rezervacija
    {
        int brojrezervacije;
        DateTime datumrezervacije;
        List<Usluga> listausluga = new List<Usluga>();

        public DateTime DatumRezervacije { get => datumrezervacije; set => datumrezervacije = value; }
        public int BrojRezervacije { get => brojrezervacije; set => brojrezervacije = value; }
        public List<Usluga> ListaUsluga { get => listausluga; set => listausluga = value; }

    }
}
