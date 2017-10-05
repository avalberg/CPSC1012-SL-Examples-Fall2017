using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            string menuChoice;
            do
            {
                menuChoice = DisplayMenu();
                switch (menuChoice)
                {
                    case "A":
                        GuessANumber();
                        break;
                    case "B":
                        WriteMovies();
                        break;
                    case "C":
                        WriteChars();
                        break;
                    case "X":
                        Console.WriteLine("Thanks for playing!");
                        break;
                    default:
                        Console.WriteLine("\nYou didn't pick a valid option. Please pick again!\n");
                        break;
                }
            } while (menuChoice != "X");
        }

        private static string DisplayMenu()
        {
            Console.Write("Pick a method to run, or exit:\nA) Guess A Number"
                + "\nB) Write Movies from a List \nC) Write the characters in a string \nX) Exit the program.\nYour choice:   ");
            return Console.ReadLine().ToUpper();
        }

        private static void WriteChars()
        {
            string line = "Supercalifragilisticexpialidocious";
            int count = 0;

            Console.Write("\nWhich letter would you like to count?   ");
            char userLetter = char.Parse(Console.ReadLine());

            foreach (char character in line)
            {
                if (character == char.ToUpper(userLetter) || character == char.ToLower(userLetter))
                    count++;
            }
            Console.WriteLine($"\nThere are {count} '{char.ToUpper(userLetter)}'s in {line}.\n");
        }

        private static void WriteMovies()
        {
            List<string> names = new List<string>()
            {
                "Citizen Kane","The Godfather","Shawshank Redemption","The Godfather II","Pulp Fiction","The Good, the Bad, and the Ugly",
                "12 Angry Men","Schindler's List","The Dark Knight","Lord of the Rings: Return of the King","One Flew Over the Cuckoos Nest",
                "Star Wars: Episode V","Fight Club","Inception","Seven Samurai","Lord of the Rings: Fellowship of the Ring","Goodfellas",
                "Star Wars: Episode IV","City of God","Casablanca","Matrix","Once Upon A Time In The West","Rear Window",
                "Indiana Jones & the Raiders of the Lost Ark","Silence of the Lambs"
            };

            int userNumber;

            Console.Write("\nI've provided a list of the top 25 movies of all time. Choose how many items you'd like to see from that list.   ");
            userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (userNumber > 0 && userNumber < 25)
            {
                for (int count = 0; count < userNumber; count++)
                {
                    Console.Write($"{count + 1}) {names[count]}\n");
                    if (count == userNumber - 1)
                        Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("\nPlease pick a number between 1 and 25.   ");
                userNumber = int.Parse(Console.ReadLine());
            }
                
        }

        private static void GuessANumber()
        {
            Random rnd = new Random();
            int answer, userInput;

            answer = rnd.Next(0, 10);

            Console.Write("\nGuess a number between 1 and 10!   ");
            userInput = int.Parse(Console.ReadLine());

            while (userInput != answer)
            {
                Console.WriteLine("\nNope! Try again.   ");
                userInput = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nYou got it! The answer was {answer}.\n");
        }
    }
}
