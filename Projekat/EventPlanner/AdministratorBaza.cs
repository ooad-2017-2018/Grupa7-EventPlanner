using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class AdministratorBaza
    {

        public AdministratorBaza()
        {
            ID++;
            IDAdmina = ID;
        }

        static int ID = 1;

        public string sifra { get; set; }
        public string korisnickoIime { get; set; }
        public int IDAdmina { get; set; }
        public string id { get; set; }

    }
}
