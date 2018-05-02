using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class RezervacijaViewModel
    {
        Rezervacija rezervacija;
        public RezervacijaViewModel(Rezervacija rezervacija)
        {
            this.rezervacija = rezervacija;
        }

        public int BrojRezervacije { get { return rezervacija.BrojRezervacije; } set { rezervacija.BrojRezervacije = value; } }
        public DateTime DatumRezervacije { get { return rezervacija.DatumRezervacije; } set { rezervacija.DatumRezervacije = value; } }
        public List<Usluga> ListaUsluga { get { return rezervacija.ListaUsluga; } set { rezervacija.ListaUsluga = value; } }
        public Rezervacija Rezervacija { get { return rezervacija; } }
    }
}
