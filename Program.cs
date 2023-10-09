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

            tiger.MakeSound();
            horse.MakeSound(); 
            whale.MakeSound(); 
        }
    }
}