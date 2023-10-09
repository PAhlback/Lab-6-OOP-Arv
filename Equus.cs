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
            Console.WriteLine("Shadowfax is travelling west with Gandalf on the White Ship");
        }

        public override void Eat()
        {
            Console.WriteLine($"Shadowfax is dining on some fancy hay.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Neigh!");
        }

        public override void Play()
        {
            Console.WriteLine("Shadowfax is running around jumping and stuff.");
        }
    }
}
