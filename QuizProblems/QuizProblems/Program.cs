using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiplication table
            for (int row = 1; row <= 9; row++)
            {
                for (int col = 1; col <= 9; col++)
                {
                    Console.Write("{0,3}", col);
                }
                Console.WriteLine();
                //}

                // Take an avg of numbers provided by the user
                double avg = 0;
            string input = "";
            int count;
            char again = 'Y';
            do
            {
                input = "";
                avg = 0;
                for (count = 1; input != "="; count++)
                {
                    Console.Write("Enter a mark: ");
                    input = Console.ReadLine();
                    if (input != "=")
                        avg += double.Parse(input);
                }
                avg /= count;
                Console.Write("The average is {0}\n", avg);
                Console.Write("Try again? Y/N");
                again = char.Parse(Console.ReadLine().ToUpper());
            } while (again == 'Y');
        }
    }
}
