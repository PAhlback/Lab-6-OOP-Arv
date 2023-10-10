using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Arv
{
    internal class Fish : Animal
    {
        public bool TechnicallyFish {  get; set; }

        public Fish(string name, int age, string color, string species, string diet, bool technicallyFish) : base(name, age, color, species, diet)
        {
            TechnicallyFish = technicallyFish;
        }
        public void IsAngry()
        {
            if (Name == "Moby Dick")
            {
                Console.WriteLine($"Of course {Name} is angry, he's got several harpoons stuck in him...");
            }
            else
            {
                Console.WriteLine($"{Name} is probably not angry.");
            }
        }

        public override void Eat()
        {
            if (Name == "Moby Dick") 
            {
                Console.WriteLine("Moby is eating all the squid he can see.");
            }
            else
            {
                Console.WriteLine($"{Name} is eating some sweet tasting fish food.");
            } 
        }

        public override void MakeSound()
        {
            if (Species.Contains("Whale"))
            {
                Console.WriteLine("OOOoooOOOOOoooOOOoOOOo");
            }
            else
            {
                Console.WriteLine("Blub blub");
            }
        }

        public override void Play()
        {
            if (Name == "Moby Dick")
            {
                Console.WriteLine("Moby is being a dick and playing tag with every ship he can spot.");
            }
            else
            {
                Console.WriteLine($"{Name} is just swimming around.");
            }    
        }
    }
}
