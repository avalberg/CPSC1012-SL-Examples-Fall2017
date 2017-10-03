using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLOct3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.Write("\nEnter a height: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\nIs your volume in\n1) CM, or\n2) IN?");
            string measurementUnit = Console.ReadLine();
            double volume = Math.PI * radius * radius * height;
            switch (measurementUnit)
            {
                case "1":
                    Console.WriteLine($"\nBased on a height of {height:##.##} and a radius of {radius:##.##}, the volume of this cylinder would be {volume:##.##} cubic cm.");
                    break;
                case "2":
                    Console.WriteLine($"\nBased on a height of {height:##.##} and a radius of {radius:##.##}, the volume of this cylinder would be {volume:##.##} cubic cm.");
                    break;
                default:
                    Console.WriteLine("Your input was not valid.");
                    break;
            }
        }
    }
}
