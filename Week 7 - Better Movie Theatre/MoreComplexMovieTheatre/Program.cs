using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreComplexMovieTheatre
{
    class Program
    {
        // initialize class-wide variables (fields)
        public static decimal total = 0;
        public static int totalTickets = 0;
        public static decimal ticketSum = 0;

        static void Main(string[] args)
        {
            // declaring variables we'll need in our methods
            int child = 0;
            int youth = 0;
            int adult = 0;
            int senior = 0;

            Console.WriteLine("The Best Theatre Ever");
            Console.Write("------------------");
            
            // method to show current ticket prices
            DisplayTicketPrices();

            // method to get all the user's tickets
            //GetUserTicketChoices(ref child, ref youth, ref adult, ref senior);

            // method to display ticket purchase summary
            //PrintBill(child,youth,adult,senior);

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
            // what type of ticket they want to buy
            string userInput = Console.ReadLine().ToUpper();

            switch (userInput)
            {
                case "A":
                    Console.WriteLine("How many child tickets would you like to buy?");
                    int childTix;
                    int.TryParse(Console.ReadLine(), out childTix);
                    break;
                case "B":
                    break;
                case "C":
                    break;
                case "D":
                    break;
                default:
                    break;
            }
            // TODO: check if their data is valid (is it a number?)
            // TODO: update totalTickets, ticketSum, and childTix
            // TODO: ask the user if they need to add more tickets
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
