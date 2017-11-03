using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "supercalifragilisticexpialidociousss";

            // 1. Find & print the length of this string
            try
            {
                Console.Write(example.Length + "\n");

                // 2. Using a substring, print only "super" from the string provided
                Console.Write(example.Substring(0, 5) + "\n");

                // 3. Remove the last 2 's' from example, and save the new string. Then print it
                string newstring = example.Substring(0, example.Length - 2);
                Console.Write(newstring + "\n");

                // 4. Print the last 14 characters in your new string using a substring
                Console.Write(newstring.Substring(newstring.Length - 14) + "\n");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            // 5. Wrap each of your substring or string functions in a try catch!
        }
    }
}
