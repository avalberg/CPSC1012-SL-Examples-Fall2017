using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            string userInput = "";
            Console.Write("Draw An Asterisk Pyramid\n------------------------\n\n");

            do
            {
                Console.Write("Enter number of rows (1-10): ");
                while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0 || rows > 10)
                    Console.Write("Invalid input. Please enter number of rows (1-10): ");
                Console.WriteLine();
                DrawPyramid(rows);
                Console.WriteLine();
                Console.Write("Do you want to draw another pyramid? Y/N: ");
                userInput = Console.ReadLine().ToUpper();
                while (userInput != "Y" && userInput != "N")
                {
                    Console.Write("Sorry, I didn't catch that. Continue Y/N: ");
                    userInput = Console.ReadLine().ToUpper();
                }
                if (userInput == "Y")
                    Console.Clear();
            } while (userInput != "N");
            Console.Clear();
            Console.Write("Bye!\n\n");
            Environment.Exit(0);
        }

        private static void DrawPyramid(int rows)
        {
            // need a variable to count down spaces with; you can set it higher if you want your whole triangle to move
            int space = rows;

            // outside loop is saying "i want to create a new row until we've reached the number the user input"
            for (int i = 1; i <= rows; i++)
            {
                // first inside loop says "i need to count spaces on each row to move the asterisk."
                for (int j = space; j >= 1; j--)
                    Console.Write(" ");

                // second inside loops says "once we have the spaces we need, we put an asterisk and a space!"
                // we do this until the value in this loop reaches the value of the outside loop.

                for (int k = 1; k <= i; k++)
                    Console.Write("* ");

                // once our row is done (spaces and asterisks shown), we make a new line
                Console.WriteLine();

                // and we have to decrement space or else it will go on forever and ever and ever and ever and ever and....
                space--;
            }

        }
    }
}
