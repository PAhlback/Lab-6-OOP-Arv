using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Arv
{
    internal class Bird : Animal
    {
        public bool Flightless { get; set; }

        public Bird(string name, int age, string color, string species, string diet, bool flightless) : base(name, age, color, species, diet)
        {
            Flightless = flightless;
        }

        public override void Eat()
        {
            if (Diet == "Herbivore")
            {
                Console.WriteLine("Pecking on some seeds.");
            }
            else
            {
                Console.WriteLine($"{Name} is eating some tasty fish");
            }
        }

        public override void MakeSound()
        {
            if (Species.Contains("Eagle"))
            {
                Console.WriteLine($"{Name} sounds a bit like a seagull...");
            }
            else
            {
                Console.WriteLine("Chirp-chirp!");
            }
        }

        public override void Play()
        {
            Console.WriteLine("Throwing sticks on everyone walking below.");
        }
    }
}
