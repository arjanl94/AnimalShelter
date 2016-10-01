using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Reservor
    {
        string Name { get; set; }
        DateTime ReservedAt { get; set; }

        public Reservor(string name, DateTime reservedat)
        {
            Name = name;
            ReservedAt = reservedat;
        }
    }
}
