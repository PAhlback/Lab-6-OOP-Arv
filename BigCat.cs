using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Arv
{
    internal class BigCat : Animal
    {
        public bool HatesMowgli  { get; set; }

        public BigCat(string name, int age, string color, string species, string diet, bool hatesMowgli) : base(name, age, color, species, diet)
        {
            HatesMowgli = hatesMowgli;
        }

        public void LayingInAmbush()
        {
            Console.WriteLine($"{Name} is chilling in the tree, not laying in ambush for Mowgli wink-wink.");
        }

        public override void Eat()
        {
            Console.Write($"{Name} is chomping on some meat. ");

            if (Name == "Shere Khan")
            {
                Console.WriteLine("Wait, where'd Mowgli go?");
            }
        }

        public override void MakeSound()
        {
            if (Name == "Shere Khan")
            {
                Console.WriteLine("\"Mowgli... they've given it a name!\"");
            }
            else
            {
                Console.WriteLine("GROWL");
            }
        }

        public override void Play()
        {
            if (Name == "Shere Khan")
            {
                Console.WriteLine("The king does not play...");
            }
            else
            {
                Console.WriteLine($"{Name} is running back and forth chasing some bug or something.");
            }  
        }
    }
}
