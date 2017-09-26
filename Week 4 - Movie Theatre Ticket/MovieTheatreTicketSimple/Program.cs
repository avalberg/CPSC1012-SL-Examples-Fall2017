using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatreTicketSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            double total = 0;
            char userChoice;

            Console.WriteLine("Movie Theatre\n-------------");
            Console.Write("How old are you? ");

            age = int.Parse(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("\nYour ticket is 8$.");
                total += 8;
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("\nYour ticket is 10$.");
                total += 10;
            }
            else
            {
                Console.WriteLine("\nYour ticket is 12$.");
                total += 12;
            }
        }
    }
}
