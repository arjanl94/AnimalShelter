using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Cat : Animal
    {
        public string BadHabits { get; set; }

        public Cat(string name, Gender gender, string badhabits) :base(name, gender)
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
