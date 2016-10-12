using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Reservation
    {
        public Cat cat { get; private set; }
        public Dog dog { get; private set; }
        public List<Dog> dogs = new List<Dog>();
        public List<Cat> cats = new List<Cat>();

        public void NewCat(string name, string gender, string badhabits)
        {
            cat = new Cat(name, gender, badhabits);
            cats.Add(cat);
        }
        public void NewDog(string name, string gender)
        {
            dog = new Dog(name, gender);
            dogs.Add(dog);
        }
    }
}
