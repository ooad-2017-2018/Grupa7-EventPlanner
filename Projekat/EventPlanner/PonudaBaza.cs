using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class PonudaBaza
    {
        public PonudaBaza()
        {
            ID++;
            IDPonude = ID;
        }

        static int ID = 1;

        public int IDPonude { get; set; }
        public int IDUsluge { get; set; }

        public string id { get; set; }

    }
}
