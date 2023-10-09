using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Arv
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string Species { get; set; }
        public string Diet { get; set; }
        public Animal(string name, int age, string color, string species, string diet)
        {
            Name = name;
            Age = age;
            Color = color;
            Species = species;
            Diet = diet;
        }

        public abstract void MakeSound();
        public abstract void Play();
        public abstract void Eat();
    }
}
