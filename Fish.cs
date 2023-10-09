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
            Console.WriteLine("Of course Moby Dick is angry, he's got several harpoons stuck in him...");
        }

        public override void Eat()
        {
            Console.WriteLine("Moby is eating all the squid he can see.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("OOOoooOOOOOoooOOOoOOOo");
        }

        public override void Play()
        {
            Console.WriteLine("Moby is being a dick and playing tag with every ship he can spot.");
        }
    }
}
