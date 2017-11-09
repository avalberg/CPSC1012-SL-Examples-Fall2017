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
            // MC/TF
            // 1: c
            // 2: b
            // 3: d
            // 4: a
            // 5: false
            // 6: true
            // 7: false

            // Question 8
            //int grade = 0;
            //Console.Write("Enter a grade between 1 and 100: ");
            //while (!int.TryParse(Console.ReadLine(), out grade) || grade < 1 || grade > 100)
            //{
            //    Console.Write("\tThat grade was invalid. Try again: ");
            //}
            //Console.Write($"\nGood! The grade you entered was: {grade}%\n");

            // Question 9
            //double grades = 0;
            //int students;
            //double average;
            //Console.Write("Enter the number of students in your class: ");
            //while (!int.TryParse(Console.ReadLine(), out students))
            //    Console.Write("Invalid input. Try again: ");

            //for (int i = 1; i <= students; i++)
            //{
            //    double placeholder;
            //    Console.Write("Enter a grade for student {0}: ", i);
            //    while (!double.TryParse(Console.ReadLine(), out placeholder) || placeholder < 0 || placeholder > 100)
            //        Console.Write("Invalid input. Try again: ");
            //    grades += placeholder;
            //}
            //average = grades / students;
            //Console.Write("The average grade is {0}.\n", average);

            // Question 10
            //int size;
            //string character;

            //Console.Write("What size box do you want (4-10)? ");
            //while (!int.TryParse(Console.ReadLine(), out size) || size < 4 || size > 10)
            //    Console.Write("\tInvalid number. Try again: ");
            //Console.Write("\nWhat character do you want to make the box from? ");
            //character = Console.ReadLine();
            //while (character.Length > 1 || character == null)
            //{
            //    Console.Write("\tInvalid character. Try again: ");
            //    character = Console.ReadLine();
            //}
            //// Start your code here
            //for (int row = 1; row <= size; row++)
            //{
            //    for (int col = 1; col <= size; col++)
            //    {
            //        if (row == 1 || row == size || col == 1 || col == size)
            //            Console.Write(character);
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
