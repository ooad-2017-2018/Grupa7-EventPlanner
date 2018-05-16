﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class UslugaBaza
    {
        public UslugaBaza()
        {
            ID++;
            IDUsluge = ID;
        }

        static int ID = 1;

        public int IDSaradnika { get; set; }
        public double cijena { get; set; }
        public string naziv { get; set; }
        public int IDUsluge { get; set; }
        public string vrsta { get; set; }
        public string id { get; set; }
    }
}