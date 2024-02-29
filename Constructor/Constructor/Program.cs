using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine("Name:"+animal.Name+"\tAge:"+animal.Age);
            Animal animal2 = new Animal("Ronaldo",39);
            Console.WriteLine("Name:" + animal2.Name + "\tAge:" + animal2.Age);

            Console.ReadKey();
        }
    }
}
