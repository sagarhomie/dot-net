using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_and_reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageofAnimal = 5;
            Console.WriteLine(ageofAnimal);
            ChangeAnimalAge(ageofAnimal);
            Console.WriteLine(ageofAnimal);
            Animal animal = new Animal();
            animal.Name = "tiger";
            Console.WriteLine(animal.Name);
            ChangeAnimalName(animal);
            Console.WriteLine(animal.Name);
            Console.ReadKey();
            
        }
        static void ChangeAnimalAge(int age) {
            age = 10;
            Console.WriteLine(age);
        }
        static void ChangeAnimalName(Animal animal)
        {
            animal.Name = "cow";
            Console.WriteLine(animal.Name);
        }
    }
}
