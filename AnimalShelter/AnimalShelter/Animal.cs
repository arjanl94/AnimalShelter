using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public Gender gender { get; set; }

        public Animal(string name, Gender gender)
        {
            Name = name;
            this.gender = gender;
        }
    }
}
