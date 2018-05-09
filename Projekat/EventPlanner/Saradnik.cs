using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Saradnik : Korisnik
    {
        int Idbroj;
        public int IDbroj { get => Idbroj; set => Idbroj = value; }
        List<Usluga> mojeusluge = new List<Usluga>();
        public List<Usluga> MojeUsluge { get => mojeusluge; set => mojeusluge = value; }
    }
}
