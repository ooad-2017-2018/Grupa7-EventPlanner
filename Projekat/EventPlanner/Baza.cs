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
        List<Usluga> listausluga = new List<Usluga>();
        Administrator administrator = new Administrator();
        public List<Usluga> ListaUsluga { get => listausluga; set => listausluga = value; }
        public List<Saradnik> ListaSaradnika { get => listasaradnika; set => listasaradnika = value; }
        public List<Klijent> ListaKlijenata { get => listaklijenata; set => listaklijenata = value; }
        public List<Rezervacija> ListaRezervacija { get => listarezervacija; set => listarezervacija = value; }
        public Administrator Administrator { get => administrator; set => administrator = value; }
    }
}
