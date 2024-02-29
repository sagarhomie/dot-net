using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** IF, ELSE CONDITION *****/
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            int newAge = Convert.ToInt32(age);
            if (newAge >= 0 && newAge <= 10)
            {
                Console.WriteLine("You are a child!");
            }
            else if (newAge >= 11 && newAge <= 20)
            {
                Console.WriteLine("You are a teen!");
            }
            else if (newAge >= 21 && newAge <= 55)
                Console.WriteLine("You are an adult!");
            else
            {
                Console.WriteLine("You are old man!");
            }
            Console.ReadLine();
        }
    }
}
