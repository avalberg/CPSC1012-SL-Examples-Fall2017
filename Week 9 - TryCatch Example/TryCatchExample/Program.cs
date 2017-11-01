using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            char userChar;
            // wrapped a loop around the trycatch so that it repeats if an exception is caught
            while (userInput <= 0)
            {
                try
                {
                    Console.Write("Enter a number greater than 0: ");
                    userInput = int.Parse(Console.ReadLine());
                    Console.Write("\nEnter one single letter: ");
                    userChar = char.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    // we're catching our error and handling it by forcing the user to correct their input
                    Console.Write("An error occurred: " + e.Message + "\n");
                }
            }
            Console.Write("\nCongrats, you didn't mess it up!\n");

            // another try catch, but this time we're handling the error by throwing.
            // this makes the console application stop but still sends an error message.
            // whether you display a message or throw, you need to be handling errors
            // when you catch them! don't just display a message and move along.
            try
            {
                HiddenMessage();
            }
            catch (Exception e)
            {
                // this effectively 'crashes' our app, but the exception information is stored
                // which is what's important.
                throw;
            }
        }

        public static void HiddenMessage()
        {
            int.Parse("potato");
        }
    }
}
