using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Reservation
    {
        public Cat cat { get; private set; }
        public Dog dog { get; private set; }

        public void NewCat(string name, Gender gender, string badhabits)
        {
            cat = new Cat(name, gender, badhabits);
        }
        public void NewDog(string name, Gender gender)
        {
            dog = new Dog(name, gender);
        }
    }
}
