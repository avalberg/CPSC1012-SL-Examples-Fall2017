using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreComplexMovieTheatre
{
    class Program
    {
        #region Fields
        // initialize class-wide variables (fields)
        public static decimal total = 0;
        public static int totalTickets = 0;
        public static decimal ticketSum = 0;
        #endregion

        static void Main(string[] args)
        {
            // declaring variables we'll need in our methods
            int child = 0;
            int youth = 0;
            int adult = 0;
            int senior = 0;

            Console.WriteLine("The Best Theatre Ever");
            Console.Write("------------------");

            // method to get all the user's tickets
            GetUserTicketChoices(ref child, ref youth, ref adult, ref senior);

            // method to display ticket purchase summary
            PrintBill(child,youth,adult,senior);

            // TODO: add menu for whole program
            // TODO: add snack choices (1 for each guest)
            // TODO: add drink choices (1 for each guest)
        }

        private static void DisplayTicketPrices()
        {
            Console.WriteLine("\nA) Child (under 12): $8");
            Console.WriteLine("B) Youth (13-17): $10");
            Console.WriteLine("C) Adult (18-69): $12");
            Console.WriteLine("D) Senior (70+): $8");
            Console.Write("Please enter the ticket type you'd like to buy: ");
        }

        private static void GetUserTicketChoices(ref int child, ref int youth, ref int adult, ref int senior)
        {
            string exitYN = "";
            Console.Write("\n Ticket Purchase");
            do
            {
                DisplayTicketPrices();
                string userInput = Console.ReadLine().ToUpper();
                // TODO: need to validate user input
                switch (userInput)
                {
                    case "A":
                        Console.WriteLine("How many child tickets would you like to buy?");
                        int childTix;
                        while (!int.TryParse(Console.ReadLine(), out childTix))
                            Console.Write($"\nThat's not a valid selection.");
                        Console.Write($"\nYou have added {childTix} child ticket(s) to your order.");
                        child += childTix;
                        ticketSum += childTix * 8;
                        totalTickets += childTix;
                        total += childTix * 8;
                        break;
                    case "B":
                        Console.WriteLine("How many youth tickets would you like to buy?");
                        int youthTix;
                        while (!int.TryParse(Console.ReadLine(), out youthTix))
                            Console.Write($"\nThat's not a valid selection.");
                        Console.Write($"\nYou have added {youthTix} child ticket(s) to your order.");
                        youth += youthTix;
                        ticketSum += youthTix * 10;
                        totalTickets += youthTix;
                        total += youthTix * 10;
                        break;
                    case "C":
                        Console.WriteLine("How many adult tickets would you like to buy?");
                        int adultTix;
                        while (!int.TryParse(Console.ReadLine(), out adultTix))
                            Console.Write($"\nThat's not a valid selection.");
                        Console.Write($"\nYou have added {adultTix} child ticket(s) to your order.");
                        adult += adultTix;
                        ticketSum += adultTix * 12;
                        totalTickets += adultTix;
                        total += adultTix * 12;
                        break;
                    case "D":
                        Console.WriteLine("How many senior tickets would you like to buy?");
                        int seniorTix;
                        while (!int.TryParse(Console.ReadLine(), out seniorTix))
                            Console.Write($"\nThat's not a valid selection.");
                        Console.Write($"\nYou have added {seniorTix} child ticket(s) to your order.");
                        senior += seniorTix;
                        ticketSum += seniorTix * 8;
                        totalTickets += seniorTix;
                        total += seniorTix * 8;
                        break;
                    default:
                        break;
                }
                Console.Write("\n\nHave you added all your tickets?");
                exitYN = Console.ReadLine().ToUpper();
            } while (exitYN != "Y");
        }

        private static void PrintBill(int child, int youth, int adult, int senior)
        {
            // TODO: add the rest of the bill!
            Console.WriteLine("{0,30}", "--------------------");
            Console.WriteLine("{0,25}{1,5}{2,10:C2}", "Subtotal", "=", total);
            Console.WriteLine("{0,25}{1,5}{2,10:C2}", "GST", "=", total * 0.05m);
            Console.WriteLine("{0,25}{1,5}{2,10:C2}\n\n", "Total", "=", total * 1.05m);
        }
    }
}
