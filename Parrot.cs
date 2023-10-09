using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Arv
{
    internal class Parrot : Bird
    {
        public int NumberOfWordsLearnt {  get; set; }
        public Parrot(string name, int age, string color, string species, string diet, bool flightless, int numberOfWordsLearnt) : base(name, age, color, species, diet, flightless)
        {
            NumberOfWordsLearnt = numberOfWordsLearnt;
        }
        public void WantsCracker(Parrot p)
        {
            Console.WriteLine($"{p.Name} wants a cracker, craw, {p.Name} wants a cracker!");
        }
    }
}
