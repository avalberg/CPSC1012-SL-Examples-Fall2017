using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_SomeLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            char userChoice;
            Console.Write("More Looping Examples!\n");
            do
            {
                Console.Write("\n------------------\nPick a loop to try\nA) Prime Numbers\nB) Perfect Numbers\nX) Exit\nYour choice: ");
                userChoice = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine();
                switch (userChoice)
                {
                    case 'A':
                        PrimeNumber();
                        break;
                    case 'B':
                        PerfectNumber();
                        break;
                    case 'X':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\nInvalid menu choice. Try again.");
                        break;
                }
            } while (userChoice != 'X');
        }

        private static void PerfectNumber()
        {
            int n, i, sum = 0;

            Console.Write("----------------\nInput a number : ");
            n = int.Parse(Console.ReadLine());
            Console.Write($"Positive divisors of {n}: ");
            for (i = 1; i <= n /2; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0}, ", i);
                }
            }
            Console.Write("\nThe sum of the divisors is: {0}", sum);
            if (sum == n)
                Console.Write("\nSo, the number is perfect.");
            else
                Console.Write("\nSo, the number is not perfect.");
            Console.Write("\n");

        }

        public static void PrimeNumber()
        {
            int num, i, ctr = 0;

            Console.Write("----------------\nInput a number: ");
            num = int.Parse(Console.ReadLine());
            Console.Write($"\n{num} is divisible by 1, ");
            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    Console.Write($"{i}, ");
                }
            }
            if (ctr == 0 && num != 1)
                Console.Write("and {0}.\n\n{0} is a prime number.\n", num);
            else
                Console.Write("and {0}.\n\n{0} is not a prime number.\n", num);
        }

    }
}
