using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** ACCESSING ARRAY ITEMS IN C# *****/

            Numbers();
            Console.ReadLine();
        }

        static void Numbers()
        {
            int[,] Numbers = { { 1, 2, 2 },{ 2, 3, 4 } ,{ 2, 7, 8 } };
            for(int i = 0; i <= 2; i++)
            {
                for(int j = 0; j <= 2; j++)
                {
                    Console.WriteLine(Numbers[i, j]);
                }
            }
        }
    }
}