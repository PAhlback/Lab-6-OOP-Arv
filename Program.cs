using System.Drawing;
using System.Xml.Linq;

namespace Lab_6_OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigCat tiger = new BigCat("Shere Khan", 10, "Orange with black stripes", "Bengal Tiger", "Carnivore", true);
            Equus horse = new Equus("Shadowfax", 6, "Silvery-gray", "Mearas", "Herbivore", "Medium");
            Fish whale = new Fish("Moby", 65, "White", "Sperm Whale", "Carnivore", false);
            Penguin penguin = new Penguin("Mumble", 3, "Black with a white belly", "Emperor Penguin", "Carnivore", true, true);

            Console.Write($"The tiger {tiger.Name} says: ");
            tiger.MakeSound();
            Console.Write($"The horse {horse.Name} makes the sound ");
            horse.MakeSound();
            Console.Write($"The whale {whale.Name} makes the sound ");
            whale.MakeSound();
            Console.Write($"The penguin {penguin.Name} makes the sound ");
            penguin.MakeSound();
            penguin.Dancing(penguin);
        }
    }
}