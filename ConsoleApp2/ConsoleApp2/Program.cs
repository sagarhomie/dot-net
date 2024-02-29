using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** ACCESSING CLASS IN C# *****/

            Animal myAnimal = new Animal();
            myAnimal.Name = "Lion";
            myAnimal.Description = "wild";
            myAnimal.WhatItEats(myAnimal.Description);
            Console.ReadLine();
        }

    }
}
