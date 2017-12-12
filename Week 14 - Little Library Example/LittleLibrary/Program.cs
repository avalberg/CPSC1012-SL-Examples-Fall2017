using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleLibrary
{
    class Program
    {
        // creating a list of books to store the books we will pull in from the .txt file
        public static List<Book> books = new List<Book>();

        static void Main(string[] args)
        {
            int userChoice = 0;
            Console.Write("The Little Library\n------------------\n\n");

            // trying to retrieve book list before anything starts
            while (!RetrieveBookList())
                Console.Write("Please try again!\n");

            do
            {
                Console.Write("Main Menu\n\t1) Show Top Books by Genre\n\t2) Find a Specific Book\n\t3) Library Services\n\t4) Manage Account\n\t5) Exit\nSelect an option: ");
                while (!int.TryParse(Console.ReadLine(), out userChoice) || (userChoice != 0 && userChoice != 1 && userChoice != 2 && userChoice != 3 && userChoice != 4 && userChoice != 5))
                {
                    Console.Write("That was an invalid option. Try again: ");
                }
                switch (userChoice)
                {
                    case 1:
                        //TODO: set up this case so that it lets the user pick a genre (from a list) and then shows them the books from that genre in order of how many times they've been taken out
                        //set it up in a method for repeatability
                        foreach (Book book in books)
                            Console.Write(book.BookID);
                        break;
                    case 2:
                        //TODO: set up this case to find a specific book
                        break;
                    case 3:
                        LibraryServices();
                        break;
                    case 4:
                        ManageAccount();
                        break;
                    default:
                        break;
                }
            } while (userChoice != 5);
            Console.Write("Goodbye!\n");
            Environment.Exit(0);
        }

        public static bool RetrieveBookList()
        {
            // creating a bool to track if our list worked
            bool retrieved = false;

            // taking user input for the source of the books (the file path)
            Console.Write("Enter the file path for the library's books: ");
            string source = Console.ReadLine();

            // now, we'll try to find the path specific by the user; since it might be wrong, we want to wrap this in a try/catch!
            try
            {
                string[] bookGenres = Directory.GetFiles(source, "*.txt");
                foreach (string file in bookGenres)
                {
                    string filecontent = File.ReadAllText(file);
                    string[] booklist = filecontent.Split('\n');
                    foreach(string book in booklist)
                    {
                        string[] bookParts = book.Split(',');
                        Book temp = new Book();
                        temp.BookID = int.Parse(bookParts[0]);
                        temp.Title = bookParts[1];
                        temp.Genre = bookParts[2];
                        temp.CheckedOut = bool.Parse(bookParts[3]);
                        temp.DateCheckedOut = DateTime.Parse(bookParts[4]);
                        temp.FinePerDay = decimal.Parse(bookParts[5]);
                        temp.TimesCheckedOut = int.Parse(bookParts[6]);
                        books.Add(temp);
                    }
                }
                retrieved = true;
            }
            catch (Exception ex)
            {

                Console.Write("Error: " + ex.Message + "\n");
            }
            return retrieved;
        }

        public static void LibraryServices()
        {
            int innerMenuChoice = 0;
            do
            {
                Console.Write("Main Menu --> Library Services\n\t1) Take out a Book\n\t2) Return a Book\n\t3) See Current Fines\n\t4) Pay Fines\n\t5) Back to Main Menu\nSelect an option: ");
                while (!int.TryParse(Console.ReadLine(), out innerMenuChoice) || (innerMenuChoice != 0 && innerMenuChoice != 1 && innerMenuChoice != 2 && innerMenuChoice != 3 && innerMenuChoice != 4 && innerMenuChoice != 5))
                {
                    Console.Write("That was an invalid option. Try again: ");
                }
                switch (innerMenuChoice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            } while (innerMenuChoice != 5);
        }

        public static void ManageAccount()
        {
            int innerMenuChoice = 0;
            do
            {
                Console.Write("Main Menu --> Manage Account\n\t1) Create New Account\n\t2) Manage Existing Account\n\t3) Back to Main Menu\nSelect an option: ");
                while (!int.TryParse(Console.ReadLine(), out innerMenuChoice) || (innerMenuChoice != 0 && innerMenuChoice != 1 && innerMenuChoice != 2 && innerMenuChoice != 3))
                {
                    Console.Write("That was an invalid option. Try again: ");
                }
                switch (innerMenuChoice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            } while (innerMenuChoice != 3);
        }
    }
}
