using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Baza
    {
        List<Saradnik> listasaradnika = new List<Saradnik>();
        List<Klijent> listaklijenata = new List<Klijent>();
        List<Rezervacija> listarezervacija = new List<Rezervacija>();

        public List<Saradnik> ListaSaradnika { get => listasaradnika; set => listasaradnika = value; }
        public List<Klijent> ListaKlijenata { get => listaklijenata; set => listaklijenata = value; }
        public List<Rezervacija> ListaRezervacija { get => listarezervacija; set => listarezervacija = value; }
    }
}
