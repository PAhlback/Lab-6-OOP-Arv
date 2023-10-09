using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Arv
{
    internal class Canine : Animal
    {
        public bool HasBigEyesAndEars { get; set; }

        public Canine(string name, int age, string color, string species, string diet, bool hasBigEyesAndEars) : base(name, age, color, species, diet)
        {
            HasBigEyesAndEars = hasBigEyesAndEars;
        }

        public override void Eat()
        {
            Console.WriteLine("Eating some yummy treats.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Voof voof!");
        }

        public override void Play()
        {
            Console.WriteLine("Playing catch with themselves.");
        }
    }
}
