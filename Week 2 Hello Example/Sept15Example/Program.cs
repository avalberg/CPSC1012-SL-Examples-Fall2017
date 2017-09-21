using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept15Example
{
    class Program
    {
        private static string _FirstName;
        public static string LastName;

        public static string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name: ");
            FirstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            LastName = Console.ReadLine();

            Console.WriteLine(Hello(FirstName, LastName));
        }

        public static string Hello(string firstname, string lastname)
        {
            string toReturn;
            toReturn = "Hello " + firstname + " " + lastname + "!";
            return toReturn;
        }
    }
}
