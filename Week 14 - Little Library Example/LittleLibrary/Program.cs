using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            string[] bookLines = System.IO.File.ReadAllLines(@"C:\Users\avalberg\Documents\GitHub\CPSC1012-SL-Examples\Week 14 - Little Library Example\LittleLibrary\Books\booklist.txt");
            foreach(string line in bookLines)
            {
                string[] bookParts = line.Split(',');
                Book temp;
                //set all properties of the Book to their appropriate part of the string
                //temp.BookID = bookParts[0];
            }
        }
    }
}
