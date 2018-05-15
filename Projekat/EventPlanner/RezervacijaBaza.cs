using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class RezervacijaBaza
    {
        public RezervacijaBaza()
        {
            ID++;
            IDRezervacije = ID;
        }

        static int ID = 1;

        public int IDRezervacije { get; set; }
        public DateTime datumRezervacije { get; set; }
        public int IDUsluge { get; set; }
        public string id { get; set; }
    }
}
