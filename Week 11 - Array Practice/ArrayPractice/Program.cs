using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Declare & initialize 2 arrays - one int array, one string array
            // int array is called grades and has the following values (in this order!): 50, 45, 70, 70, 86, 87, 36, 65, 65, 90, 55, 100
            // string array is called names and has the following values (in this order!): Abed, Britta, Troy, Jeff, Shirley, Annie, Pierce

            int[] grades = new int[] { 50, 45, 70, 70, 86, 87, 36, 65, 65, 90, 55, 100 };
            string[] names = new string[] { "Abed", "Britta", "Troy", "Jeff", "Shirley", "Annie", "Pierce" };

            // 2. Find the maximum value of each array and show them to the user
            Console.WriteLine(grades.Max());
            Console.WriteLine(names.Max());

            // 3. Find the minimum value of each array and show them to the user
            Console.WriteLine(grades.Min());
            Console.WriteLine(names.Min());

            // 4. Sort both arrays in ascending order (lowest to highest value)
            Array.Sort(grades);
            Array.Sort(names);

            // 5. Display the sorted arrays in this format: 1, 2, 3 && Name, Name, Name
            // Your last printed item should not have a comma after it!

            for (int index = 0; index < grades.Length; index++)
            {
                if (index != grades.Length - 1)
                    Console.Write(grades[index] + ", ");
                else
                    Console.Write(grades[index] + "\n");
            }

            for (int index = 0; index < names.Length; index++)
            {
                if (index != names.Length - 1)
                    Console.Write(names[index] + ", ");
                else
                    Console.Write(names[index] + "\n");
            }

            // 6. Now, sort both arrays in descending order (highest to lowest value)
            Array.Reverse(grades);
            Array.Reverse(names);

            // 7. Display the reversed arrays in the same format as earlier
            // Again, no comma should appear after your last item
            for (int index = 0; index < grades.Length; index++)
            {
                if (index != grades.Length - 1)
                    Console.Write(grades[index] + ", ");
                else
                    Console.Write(grades[index] + "\n");
            }

            for (int index = 0; index < names.Length; index++)
            {
                if (index != names.Length - 1)
                    Console.Write(names[index] + ", ");
                else
                    Console.Write(names[index] + "\n");
            }

            // 8. Now, for some fun...check your int array for duplicates.
            // When you find a duplicate, you need to save its value.
            // At the end, display your list of duplicates to the user.
            int[] gradeDuplicates = new int[grades.Length];
            int duplicates = 0;
            for (int count = 0; count < grades.Length; count++)
            {
                for (int index = count + 1; index < grades.Length; index++)
                {
                    if (grades[count] == grades[index])
                    {
                        gradeDuplicates[duplicates] = grades[count];
                        duplicates++;
                        break;
                    }
                }
            }
            Console.Write("Duplicates: ");
            for (int dupes = 0; dupes < duplicates; dupes++)
            {
                if (dupes != duplicates - 1)
                    Console.Write(gradeDuplicates[dupes] + ", ");
                else
                    Console.Write(gradeDuplicates[dupes] + "\n");
            }
        }
    }
}
