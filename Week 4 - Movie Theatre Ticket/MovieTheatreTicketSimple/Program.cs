using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatreTicketSimple
{
    // This program is for a very simple movie theatre.
    // You can buy one ticket (based on your age) and 1 snack.
    // The program then displays your purchase details and your total cost.
    // I've simplified the program using methods & regions - 
    // To see the methods, click the little + sign on the left, next to the line numbers!
    // This will expand a region so you can see what's inside it.

    class Program
    {
        // this is a field!
        public static decimal total;

        static void Main(string[] args)
        {
            // initialization
            decimal ticketPrice, snackPrice;
            char userMenuChoice;

            // title
            Console.WriteLine("Movie Theatre\n-------------");

            // calling getTicketPrice method which returns a decimal; storing that decimal in ticketPrice
            ticketPrice = getTicketPrice();
            
            // displaying our snack menu by calling method snackMenu
            snackMenu();

            // taking user choice for snack; storing it in userMenuChoice
            userMenuChoice = char.Parse(Console.ReadLine());

            // calling getSnackPrice method which requires an argument that's a char (userMenuChoice);
            // this method returns a decimal that we then store in snackPrice
            snackPrice = getSnackPrice(userMenuChoice);

            // calling printBill method which requires 2 decimal arguments (ticketPrice & snackPrice)
            printBill(ticketPrice, snackPrice);
        }

        #region Snack Menu
        public static void snackMenu()
        {
            Console.WriteLine("-------------------");
            Console.Write("\nPick a snack: \nA) Popcorn - 5$\nB) Skittles - 2$\n"
                + "C) Cotton candy - 3$\nEnter your snack choice: ");
        }
        #endregion

        #region Get Ticket Price
        public static decimal getTicketPrice()
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
        #endregion

        #region Get Snack Price
        public static decimal getSnackPrice(char userChoice)
        {
            switch (userChoice)
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
                    return 0;
            }
        }
        #endregion

        #region Print Bill
        public static void printBill(decimal ticket, decimal snack)
        {
            Console.WriteLine("-------------------------");
            //this is the string interpolation version
            Console.WriteLine($"\n{"1",5}{"ticket(s)",13}{"@",5}{ticket,10:C2}");
            //this is the parameterized version
            Console.WriteLine("{0,5}{1,13}{2,5}{3,10:C2}", "1", "snack(s)", "@", snack);
            Console.WriteLine("{0,33}", "-----------------------------");
            Console.WriteLine("{0,18}{1,5}{2,10:C2}", "Subtotal", "=", total);
            Console.WriteLine("{0,18}{1,5}{2,10:C2}", "GST", "=", total * 0.05m);
            Console.WriteLine("{0,18}{1,5}{2,10:C2}\n\n", "Total", "=", total * 1.05m);
        }
        #endregion
    }
}
