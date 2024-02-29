using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_inheritance
{
    public class Animal
    {
       
        public int Age {  get; set; }
        public string Name { get; set; }
       
        public Animal() {
            int Age = 1;
            string Name = "default";
        }
        public Animal(int age, string name)
        {
            Name = name;
            Age = age;

        }
        public void Display()
        {
            
            Console.WriteLine(Age +""+ Name);
        }
    }
    

}
