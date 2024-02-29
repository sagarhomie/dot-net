using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private string NameAndDescription {  get; set; }
        public void WhatItEats(string Description)
        {
            NameAndDescription = Name + " is a " + Description + " animal.";
            Console.WriteLine(NameAndDescription);
            if (Description == "pet")
            {

                Console.WriteLine("It eats grass.");
            }
            else
            {
                Console.WriteLine("It eats flesh.");
            }
        }
    }
}
