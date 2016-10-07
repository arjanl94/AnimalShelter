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
        public static int Aantal { get; set; }

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
        public override bool SellAnimal()
        {
            decimal price = 500 - (50 * Aantal);
            if (price >= 50)
            {
                Price = price;
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
