using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatreTicketSimple
{
    class Program
    {
        // this is a field!
        public static double total;

        static void Main(string[] args)
        {
            double ticketPrice, snackPrice;

            Console.WriteLine("Movie Theatre\n-------------");

            ticketPrice = getTicketPrice();

            snackMenu();

            snackPrice = getSnackPrice(char.Parse(Console.ReadLine().ToUpper()));

            printBill(ticketPrice, snackPrice);
        }

        public static void snackMenu()
        {
            Console.WriteLine("-------------------");
            Console.Write("\nPick a snack: \nA) Popcorn - 5$\nB) Skittles - 2$\n"
                + "C) Cotton candy - 3$\nEnter your snack choice: ");
        }

        public static double getTicketPrice()
        {
            Console.Write("\nHow old are you? ");

            int age = int.Parse(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("\nYour ticket is 8$.");
                total += 8;
                return 8;
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("\nYour ticket is 10$.");
                total += 10;
                return 10;
            }
            else
            {
                Console.WriteLine("\nYour ticket is 12$.");
                total += 12;
                return 12;
            }
        }

        public static double getSnackPrice(char userChoice)
        {
            switch (userChoice)
            {
                case 'A':
                    total += 5;
                    return 5;
                case 'B':
                    total += 2;
                    return 5;
                case 'C':
                    total += 3;
                    return 5;
                default:
                    return 0;
            }
        }

        public static void printBill(double ticket, double snack)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("\n{0,5}{1,13}{2,5}{3,10}", "1", "ticket(s)", "@", String.Format("{0:C}", ticket));
            Console.WriteLine("{0,5}{1,13}{2,5}{3,10}", "1", "snack(s)", "@", String.Format("{0:C}", snack));
            Console.WriteLine("{0,33}", "-----------------------------");
            Console.WriteLine("{0,18}{1,5}{2,10}", "Subtotal" ,"=", String.Format("{0:C}", total));
            Console.WriteLine("{0,18}{1,5}{2,10}", "GST", "=", String.Format("{0:C}", total * 0.05));
            Console.WriteLine("{0,18}{1,5}{2,10}\n\n", "Total", "=", String.Format("{0:C}", total * 1.05));
        }
    }
}
