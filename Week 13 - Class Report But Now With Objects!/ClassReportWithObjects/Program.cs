using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassReportWithObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // add new menu here!
            #region Old Menu
            //int userInput;
            //int numStudents = 0;
            //string className = "";
            //double[] grades = new double[25];

            //do
            //{
            //    DisplayMenu();
            //    while (!int.TryParse(Console.ReadLine(), out userInput))
            //        Console.Write("Invalid choice. Try again: ");
            //    switch (userInput)
            //    {
            //        case 1:
            //            className = GetClassName();
            //            break;
            //        case 2:
            //            numStudents = GetNumStudents();
            //            break;
            //        case 3:
            //            if (numStudents == 0)
            //            {
            //                Console.Write("You must provide a number of students before you can enter grades.\nYou will now be returned to the main menu.\n");
            //                break;
            //            }
            //            GetStudentGrades(numStudents, grades);
            //            break;
            //        case 4:
            //            Console.Clear();
            //            if (className == "")
            //                Console.Write("You need a class name to view the report.\n\n");
            //            else if (numStudents == 0)
            //                Console.Write("You need to have entered number of students to view the report.\n\n");
            //            else
            //            {
            //                DisplayClassReport(className, numStudents, grades);
            //            }
            //            break;
            //        case 5:
            //            StartOver(ref className, ref numStudents, grades);
            //            break;
            //        case 6:
            //            Environment.Exit(0);
            //            break;
            //        default:
            //            Console.Write("Please pick an option between 1 and 6.\n");
            //            break;
            //    }
            //} while (userInput != 6);
            #endregion
        }
        
        // add new methods here!
        #region Old Methods
        public static void StartOver(ref string className, ref int numStudents, double[] grades)
        {
            for (int i = 0; i < numStudents; i++)
            {
                grades[i] = 0;
            }
            numStudents = 0;
            className = "";
            Console.Clear();
            Console.Write("All fields successfully reset.\n\n");
        }

        public static void DisplayClassReport(string className, int numStudents, double[] grades)
        {
            double avg = 0;
            for (int i = 0; i < numStudents; i++)
                avg += grades[i];
            avg /= numStudents;
            Console.Write(className);
            Console.Write("\n------------------------------");
            Console.Write("\n{0,-25}{1,5}", "Number of students: ", numStudents);
            Console.Write("\n{0,-17}", "Student grades: ");
            for (int count = 0; count < numStudents; count++)
                Console.Write(grades[count] + " ");
            Console.Write("\n{0,-24}{1,5}{2,1}\n", "Grade Average: ", avg, "%");
            Console.Write("\n\nDo you want to go back to the menu? Press any key to return to the menu, or Esc to Exit.\n\n");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Bye!");
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
            }

        }

        public static void GetStudentGrades(int numStudents, double[] grades)
        {
            Console.Write("Enter a grade for each student (there are {0}).\n", numStudents);
            double localGrade;
            for (int count = 0; count < numStudents; count++)
            {
                Console.Write("Student {0}'s grade: ", count + 1);
                while (!double.TryParse(Console.ReadLine(), out localGrade) || localGrade < 0 || localGrade > 100)
                    Console.Write("Invalid grade - must be between 0 and 100 (inclusive). Try again: ");
                grades[count] = localGrade;
            }
            Console.Clear();
            Console.Write("Grades entered successfully!\n\n");
        }

        public static int GetNumStudents()
        {
            int localNumStudents;
            Console.Write("Enter number of students: ");
            while (!int.TryParse(Console.ReadLine(), out localNumStudents) || localNumStudents <= 0 || localNumStudents > 25)
                Console.Write("Invalid choice. Minimum number of students is 1, maximum is 25. Try again: ");
            Console.Clear();
            Console.Write("Number of students entered!\n\n");
            return localNumStudents;
        }

        public static string GetClassName()
        {
            Console.Write("Enter the class name: ");
            string localClassName = Console.ReadLine();
            while (localClassName.Length > 30 || localClassName.Length < 1)
            {
                Console.Write("Class name must be minimum 1 character, maximum 30 characters. Try again: ");
                localClassName = Console.ReadLine();
            }
            Console.Clear();
            Console.Write("Class name entered!\n\n");
            return localClassName;
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("1) Enter class name");
            Console.WriteLine("2) Enter number of students");
            Console.WriteLine("3) Enter student grades");
            Console.WriteLine("4) View Class Report");
            Console.WriteLine("5) Start Over");
            Console.WriteLine("6) Exit");
            Console.Write("Your choice: ");
        }
        #endregion
    }
}
