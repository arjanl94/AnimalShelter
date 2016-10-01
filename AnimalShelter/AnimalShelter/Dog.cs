using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Dog
    {
        string Name { get; set; }
        Gender gender { get; set; }
        DateTime LastWalk { get; set; }

        public Dog(string name, Gender gender)
        {
            Name = name;
            this.gender = gender;
        }
        public bool Reserve()
        {
            return true;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Gender: {gender}, Last Walk: {LastWalk}";
        }
    }
}
