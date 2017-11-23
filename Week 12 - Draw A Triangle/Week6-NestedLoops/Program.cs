using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            Console.Write("Display a right-angle pattern using asterisks\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");

            if (int.TryParse(Console.ReadLine(), out rows))
            {
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }
            }
            else
                Console.Write("\nThat wasn't a number!\n");

            Console.WriteLine();
        }
    }
}
