using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public abstract class Animal : ISellable
    {
        public string name { get; set; }
        public Gender gender { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public Animal(string name, string gender)
        {
            this.name = name;
            this.gender = (Gender)Enum.Parse(typeof(Gender), gender);
        }
        public abstract bool SellAnimal();
    }
}
