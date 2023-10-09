﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Arv
{
    internal class Penguin : Bird
    {
        public bool HappyFeet { get; set; }

        public Penguin(string name, int age, string color, string species, string diet, bool flightless, bool happyFeet) : base(name, age, color, species, diet, flightless)
        {
            HappyFeet = happyFeet;
        }
        public void Dancing(Penguin p)
        {
            if (p.HappyFeet == true)
            {
                Console.WriteLine($"{p.Name} is dancing away!");
            }
            else 
            {
                Console.WriteLine($"{p.Name} doesn't have happy feet :(");
            }
        }
    }
}
