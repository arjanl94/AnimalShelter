using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Cat
    {
        string Name { get; set; }
        Gender gender { get; set; }
        string BadHabits { get; set; }

        public Cat(string name, Gender gender, string badhabits)
        {
            Name = name;
            this.gender = gender;
            BadHabits = badhabits;
        }
        public bool Reserve()
        {
            return true;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Gender: {gender}, Bad Habits: {BadHabits}";
        }
    }
}
