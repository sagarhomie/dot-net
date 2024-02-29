using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            //animal.Name = "lion";
            //animal.Description = "wild";
            //animal.WhatItEats(animal.Description);

            Animal animal = new Animal();
            animal.Display();

            //wild.Name = "tiger";
            //wild.Description = "pet";
            //animal.WhatItEats(wild.Description);
            //wild.WhatItEats(wild.Description);
            
            Console.ReadKey();
        }
    }
}
