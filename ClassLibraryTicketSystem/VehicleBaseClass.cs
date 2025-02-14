﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// VehicleBaseClass is an abstract class. It has two properties: Licenseplate, Date. It has two abstract methods: Price(), VehicleType().
    /// </summary>
    public abstract class VehicleBaseClass
    {
        public string Licenseplate { get; set; }

        public DateTime Date { get; set; }

        protected VehicleBaseClass(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }

        protected VehicleBaseClass()
        {
        }

        public abstract double Price(Brobizz brobizz);

        public abstract string VehicleType();

    }
}
