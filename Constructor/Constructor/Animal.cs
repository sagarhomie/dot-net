﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age {  get; set; }
        public Animal() {
            Name = "sagar";
            Age = 22;
        }
        public Animal(string name,int age)
        {
            Name = name;
            Age = age;
        }
    }
}
