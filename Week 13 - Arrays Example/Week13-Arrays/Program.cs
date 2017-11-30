using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentGrades();
        }

        public static void StudentGrades()
        {
            Console.Write("How many students do you have? ");
            int numStudents;
            while (!int.TryParse(Console.ReadLine(), out numStudents) || numStudents <= 0)
                Console.Write("Sorry, that was not a valid number. Try again: ");
            string[] studentNames = new string[numStudents];
            double[] grades = new double[numStudents];
            for(int i = 0; i < numStudents; i++)
            {
                Console.Write("\nEnter student name: ");
                string name = Console.ReadLine();
                while (name.Length > 50)
                {
                    Console.Write("Name cannot be more than 50 characters.\nEnter student name: ");
                    name = Console.ReadLine();
                }
                studentNames[i] = name;
                Console.Write("\nEnter student grade: ");
                double grade;
                while (!double.TryParse(Console.ReadLine(),out grade) || grade < 0 || grade > 100)
                {
                    Console.Write("Your grade didn't work! Try again: ");
                }
                grades[i] = grade;
            }
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine("Name: " + studentNames[i]);
                Console.WriteLine("Grade: " + grades[i] + "%");
            }
            int index = HighestGrade(grades);
            Console.Write(studentNames[index] + "had the highest grade of " + grades[index] + "!");
        }

        public static int HighestGrade(double[] grades)
        {
            return Array.IndexOf(grades, grades.Max());
        }
    }
}
