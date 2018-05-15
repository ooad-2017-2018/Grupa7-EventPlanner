using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class KlijentBaza
    {
        public KlijentBaza()
        {
            ID++;
            IDKlijenta = ID;
        }

        static int ID = 1;

        public string ime { get; set; }
        public string id { get; set; }
        public string prezime { get; set; }
        public string korisnickoIme { get; set; }
        public string brojKartice { get; set; }
        public string sifra { get; set; }
        public int IDKlijenta { get; set; }
    }
}
