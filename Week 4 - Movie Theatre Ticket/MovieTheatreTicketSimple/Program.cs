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
            // Declaring our variables
            int age;
            double total = 0;
            char userSnack;

            // Writing the title
            Console.WriteLine("Movie Theatre\n-------------");
            Console.Write("How old are you? ");

            // Taking in user's age
            age = int.Parse(Console.ReadLine());

            // If/else to determine ticket price based on age
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

            // Writing snack options
            Console.Write("\n\nPick a snack: \nA) Popcorn - 5$\nB) Skittles - 2$\n"
                            + "C) Cotton candy - 3$\nEnter your snack choice: ");

            // Taking in user's snack choice
            userSnack = char.Parse(Console.ReadLine().ToUpper());

            // Switch to figure out user's snack choice
            switch (userSnack)
            {
                case 'A':
                    total += 5;
                    break;
                case 'B':
                    total += 2;
                    break;
                case 'C':
                    total += 3;
                    break;
                default:
                    break;
            }

            // Writing the bill total
            Console.WriteLine("\n-------------------------"
                + $"\nYour total bill is {total:C}\n\n");
        }
    }
}
