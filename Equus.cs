using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Arv
{
    internal class Equus : Animal
    {
        public string ManeLength { get; set; }

        public Equus(string name, int age, string color, string species, string diet, string maneLength) : base(name, age, color, species, diet)
        {
            ManeLength = maneLength;
        }
        public void WithGandalf()
        {
            if (Name == "Shadowfax")
            {
                Console.WriteLine("Shadowfax is travelling west with Gandalf on the White Ship");
            }
            else
            {
                Console.WriteLine($"{Name} is not with Gandalf.");
            }
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is dining on some fancy hay.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("neigh!");
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} is running around jumping and stuff.");
        }
    }
}
