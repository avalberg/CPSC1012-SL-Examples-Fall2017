using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int storeParsedValue;

            //Console.Write("Taking input without validating (what we've done until now)\nInput:   ");
            //storeParsedValue = int.Parse(Console.ReadLine());
            //Console.Write($"\nOur value: {storeParsedValue}\n\n");

            //Console.Write("Taking input and TryParsing it\nInput:   ");
            //int.TryParse(Console.ReadLine(), out storeParsedValue);
            //Console.Write($"\nOur value: {storeParsedValue}\n\n");

            Console.Write("Taking input and TryParsing it, this time with an error message\nInput:   ");
            bool didItParse = int.TryParse(Console.ReadLine(), out storeParsedValue);
            if (didItParse == true)
                Console.Write($"\nOur value: {storeParsedValue}\n\n");
            else
                Console.Write("Sorry, that wasn't a valid input. BYE\n\n");
        }
    }
}
