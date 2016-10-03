using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Dog : Animal
    {
        public DateTime LastWalk { get; set; }

        public Dog(string name, Gender gender) :base(name, gender)
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
