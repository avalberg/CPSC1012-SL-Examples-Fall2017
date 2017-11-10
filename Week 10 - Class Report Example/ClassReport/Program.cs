using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int numStudents;
            string className;
            double[] grades = new double[25];

            do
            {
                Console.WriteLine("1) Enter class name");
                Console.WriteLine("2) Enter number of students");
                Console.WriteLine("3) Enter student grades");
                Console.WriteLine("4) View Class Report");
                Console.WriteLine("5) Start Over");
                Console.WriteLine("6) Exit");
                Console.Write("Your choice: ");
                while (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.Write("Invalid choice. Try again: ");
                }
                switch (userInput)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        numStudents = 0;
                        className = "";
                        for (int i = 0; i < grades.Length; i++)
                        {
                            grades[i] = 0;
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (userInput != 6 || userInput < 0);
            //TODO: create 3 paths of logic (to be put in switch) - enter class name, # of students, grades
            //TODO: create 4th path of logic (to be put in switch) - view class report, 
                // which includes all the calculations and produces the class report output
        }
    }
}
