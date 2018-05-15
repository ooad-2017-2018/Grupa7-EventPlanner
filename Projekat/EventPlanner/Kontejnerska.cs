using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Kontejnerska
    {
        List<Saradnik> listasaradnika = new List<Saradnik>();
        List<Klijent> listaklijenata = new List<Klijent>();
        List<Rezervacija> listarezervacija = new List<Rezervacija>();
        List<Usluga> listausluga = new List<Usluga>();

        Administrator administrator = new Administrator("admin", "123456", "adminic", "123456");

        public List<Usluga> ListaUsluga { get => listausluga; set => listausluga = value; }
        public List<Saradnik> ListaSaradnika { get => listasaradnika; set => listasaradnika = value; }
        public List<Klijent> ListaKlijenata { get => listaklijenata; set => listaklijenata = value; }
        public List<Rezervacija> ListaRezervacija { get => listarezervacija; set => listarezervacija = value; }
        public Administrator Administrator { get => administrator; set => administrator = value; }
    }
}
