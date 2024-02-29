using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace @switch.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            int newAge = Convert.ToInt32(age);
            string ageGroup;

            if (newAge >= 0 && newAge <= 10)
            {
                ageGroup = "child";

            }

            else if (newAge >= 11 && newAge <= 20)
            {
                ageGroup = "teen";

            }

            else if (newAge >= 21 && newAge <= 55)
            {
                ageGroup = "adult";
            }

            else
            {
                ageGroup = "man";
            }
            /***** SWITCH CASE IN C# *****/
            switch (ageGroup)
            {
                case "child":
                    {
                        Console.WriteLine("You are a " + ageGroup + "!");
                        break;
                    }
                case "teen":
                    {
                        Console.WriteLine("You are a " + ageGroup + "!");
                        break;
                    }
                case "adult":
                    {
                        Console.WriteLine("You are an " + ageGroup + "!");
                        break;
                    }
                case "man":
                    {
                        Console.WriteLine("You are a " + ageGroup + "!");
                        break;
                    }
                default:

                    {
                        Console.WriteLine("Enter a valid age!");
                        break;
                    }

            }
            Console.ReadLine();
        }
    }
}


