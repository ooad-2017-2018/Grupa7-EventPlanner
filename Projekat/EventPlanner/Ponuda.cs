using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Ponuda
    {
        List<Usluga> listausluga = new List<Usluga>();
        int brojusluge;

        public int BrojUsluge { get => brojusluge; set => brojusluge = value; }
        public List<Usluga> ListaUsluga { get => listausluga; set => listausluga = value; }
    }
}
