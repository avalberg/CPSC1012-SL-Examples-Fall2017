using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockQuizAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1: a
            // Q2: c
            // Q3: b
            // Q4: c
            // Q5: d
            // Q6: a
            // Q7
            double[] grades = new double[2];
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter a grade between 0 and 100: ");
                while (!double.TryParse(Console.ReadLine(), out grades[i]) || grades[i] < 0 || grades[i] > 100)
                {
                    Console.Write("Something went wrong. Try again: ");
                }
            }
            // Q8
            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }
            Console.Write($"Your average is: {sum / grades.Length:#0.00}%.\n");
            // Q9
            int numStudents = 0;
            Console.WriteLine("How many students do you have?");
            while (!int.TryParse(Console.ReadLine(), out numStudents) || numStudents < 1 || numStudents > 25)
                Console.Write("Enter a number of students: ");
            double[] studentGrades = new double[numStudents];
            string[] studentNames = new string[numStudents];
            for (int i = 0; i < numStudents; i++)
            {
                Console.Write("Enter a name for student " + (i+1) + ": ");
                studentNames[i] = Console.ReadLine();
                while (string.IsNullOrEmpty(studentNames[i]) || studentNames[i].Length > 50)
                {
                    Console.Write("Incorrect. Try again: ");
                    studentNames[i] = Console.ReadLine();
                }
                Console.Write("Enter a grade for " + studentNames[i] + ": ");
                while (!double.TryParse(Console.ReadLine(), out studentGrades[i]) || studentGrades[i] < 0 || studentGrades[i] > 100)
                    Console.Write("Incorrect. Try again: ");
            }
            int highestIndex = HighestGrade(studentGrades);
            Console.WriteLine("The student with the highest grade is " + studentNames[highestIndex] + " with a grade of " + studentGrades[highestIndex] + "%!");
        }

        public static int HighestGrade(double[] grades)
        {
            int index = 0;
            double highest = 0;

            foreach (double grade in grades)
            {
                if (grade > highest)
                {
                    highest = grade;
                    index = Array.IndexOf(grades, grade);
                }
            }

            return index;
        }
    }
}
