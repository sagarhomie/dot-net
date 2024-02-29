using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine(); // Take input from user and store it in variable named 'name'
            Console.WriteLine("Hello, " + name + "!");
            Console.ReadLine();
        }
    }
}
