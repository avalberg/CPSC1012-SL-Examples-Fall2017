using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatreTicketSimple
{
    class Program
    {
        public static double total;

        static void Main(string[] args)
        {
            char userSnack;
            double ticketPrice, snackPrice, GST, netTotal;

            Console.WriteLine("Movie Theatre\n-------------");

            ticketPrice = getTicketPrice();
            Console.WriteLine("-------------");

            writeSnackList();
            userSnack = char.Parse(Console.ReadLine().ToUpper());

            snackPrice = getSnackPrice(userSnack);

            Console.WriteLine("-------------------------");
            Console.WriteLine("{0,5}{1,12}{2,5}{3,10}", "1", "ticket(s)", "@", String.Format("{0:C}", ticketPrice));
            Console.WriteLine("{0,5}{1,12}{2,5}{3,10}", "1", "snacks(s)", "@", String.Format("{0:C}", snackPrice));
            Console.WriteLine("{0,5}{1,12}{2,5}{3,10}", "GST = ", String.Format("{0:C}", ticketPrice));
        }

        public static int getTicketPrice()
        {
            int age;
            Console.Write("\nHow old are you? ");
            age = int.Parse(Console.ReadLine());

            if (age < 13 || age > 59)
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

        public static void writeSnackList()
        {
            Console.WriteLine("\nPick a snack: ");
            Console.WriteLine("A) Popcorn - 5$");
            Console.WriteLine("B) Skittles - 2$");
            Console.WriteLine("C) Cotton candy - 3$");
            Console.WriteLine("D) Enter anything else to skip snack selection.");
            Console.Write("Enter your snack choice: ");
        }

        public static double getSnackPrice(char snack)
        {
            switch (snack)
            {
                case 'A':
                    total += 5;
                    return 5;
                case 'B':
                    total += 2;
                    return 2;
                case 'C':
                    total += 3;
                    return 3;
                default:
                    Console.WriteLine("\nNo snack selected.");
                    return 0;
            }
        }
    }
}
