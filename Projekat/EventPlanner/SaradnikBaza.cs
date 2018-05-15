using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class SaradnikBaza
    {
        public SaradnikBaza()
        {
            ID++;
            IDSaradnika = ID;
        }

        static int ID = 1;

        public string naziv { get; set; }
        public string sifra { get; set; }
        public string korisnickoIme { get; set; }
        public string brojKartice { get; set; }
        public int IDSaradnika { get; set; }
        public string id { get; set; }
        public string adresa { get; set; }
        public string kontakt { get; set; }
    }
}
