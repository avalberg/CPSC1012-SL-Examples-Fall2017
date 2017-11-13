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
            int numStudents = 0;
            string className = "";
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
                    Console.Write("Invalid choice. Try again: ");
                switch (userInput)
                {
                    case 1:
                        Console.Write("Enter the class name: ");
                        className = Console.ReadLine();
                        while (className.Length > 30 || className.Length < 1)
                        {
                            Console.Write("Class name must be minimum 1 character, maximum 30 characters. Try again: ");
                            className = Console.ReadLine();
                        }
                        break;
                    case 2:
                        Console.Write("Enter number of students: ");
                        while(!int.TryParse(Console.ReadLine(), out numStudents) || numStudents == 0 || numStudents > 25)
                            Console.Write("Invalid choice. Minimum number of students is 1, maximum is 25. Try again: ");
                        break;
                    case 3:
                        if (numStudents == 0)
                        {
                            Console.Write("You must provide a number of students before you can enter grades.\nYou will now be returned to the main menu.\n");
                            break;
                        }
                        Console.Write("Enter a grade for each student (there are {0}).\n", numStudents);
                        double localGrade;
                        for (int count = 0; count < numStudents; count++)
                        {
                            Console.Write("Student {0}'s grade: ", count + 1);
                            while (!double.TryParse(Console.ReadLine(), out localGrade) || localGrade < 0 || localGrade > 100)
                                Console.Write("Invalid grade - must be between 0 and 100 (inclusive). Try again: ");
                            grades[count] = localGrade;
                        }
                        break;
                    case 4:
                        if (className == "")
                            Console.Write("You need a class name to view the report. You are now being returned to the main menu.\n");
                        else if (numStudents == 0)
                            Console.Write("You need a class name to view the report. You are now being returned to the main menu.\n");
                        else
                        {
                            Console.Write(className);
                            Console.Write("\n------------------------------");
                            Console.Write("\n{0,-25}{1,5}", "Number of students: ", numStudents);
                            Console.Write("\n{0,-25}", "Student grades: ");

                        }
                        break;
                    case 5:
                        for (int i = 0; i < numStudents; i++)
                        {
                            grades[i] = 0;
                        }
                        numStudents = 0;
                        className = "";
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("Please pick an option between 1 and 6.\n");
                        break;
                }
            } while (userInput != 6 || userInput < 0);
            //TODO: create 3 paths of logic (to be put in switch) - enter class name, # of students, grades
            //TODO: create 4th path of logic (to be put in switch) - view class report, 
                // which includes all the calculations and produces the class report output
        }
    }
}
