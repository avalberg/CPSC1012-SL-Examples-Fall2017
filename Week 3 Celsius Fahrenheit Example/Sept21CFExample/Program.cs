using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept21CFExample
{
    class Program
    {
        // We're going to make a basic program together that uses methods
        // to convert celsius to fahrenheit, and vice versa!

        // We need to use all 3 of the variables provided. We can make more
        // if we need to. We need to use both methods provided.

        // What writes to our console should be formatted EXACTLY like this: 
        // Enter a value in celsius: 12
        // 12C is 53.6F
        // Enter a value in fahrenheit: 40
        // 40F is 4.4444444444C
        // Press any key to continue...

        // PS - here are the conversion formulas:
            // C to F: C * 1.8 + 32
            // F to C: (F - 32) / 1.8

        static void Main(string[] args)
        {
            double userValueCelsius;
            double userValueFahrenheit;
            double fValueConvertedToC;

            Console.Write("Enter a value in celsius: ");
            userValueCelsius = double.Parse(Console.ReadLine());

            CelsiusToFahrenheit(userValueCelsius);

            Console.Write("Enter a value in fahrenheit: ");
            userValueFahrenheit = double.Parse(Console.ReadLine());
            fValueConvertedToC = FahrenheitToCelsius(userValueFahrenheit);
            Console.WriteLine(userValueFahrenheit + "F is " + fValueConvertedToC + "C");
        }

        public static void CelsiusToFahrenheit(double userValue)
        {
            Console.WriteLine(userValue + "C is " + (userValue * 1.8 + 32) + "F");
        }

        public static double FahrenheitToCelsius(double userValue)
        {
            return (userValue - 32) / 1.8;
        }
    }
}
