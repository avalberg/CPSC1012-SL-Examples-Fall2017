using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChairExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring variables
            Chair.chairType type;
            Chair.primaryMaterial material;
            string colour, name;
            int selection;
            
            // title
            Console.Write("Inventory Management\n--------------------");

            // getting user input for chair type and parsing it
            Console.Write("\nSelect a chair type: \n1) Rolling\n2) Stationary\n3) Stool\nYour choice: ");
            while (!int.TryParse(Console.ReadLine(), out selection) || (selection != 1 && selection != 2 && selection != 3))
                Console.Write("Invalid selection. Your choice: ");

            // setting chair type based on user input
            if (selection == 1)
                type = Chair.chairType.rolling;
            else if (selection == 2)
                type = Chair.chairType.stationary;
            else
                type = Chair.chairType.stool;

            // getting user input for chair material and parsing it
            Console.Write("Select a chair material: \n1) Wood\n2) Cloth\n3) Plastic\nYour choice: ");
            while (!int.TryParse(Console.ReadLine(), out selection) || (selection != 1 && selection != 2 && selection != 3))
                Console.Write("Invalid selection. Your choice: ");

            // setting chair material based on user input
            if (selection == 1)
                material = Chair.primaryMaterial.wood;
            else if (selection == 2)
                material = Chair.primaryMaterial.cloth;
            else
                material = Chair.primaryMaterial.plastic;

            // getting user input for chair colour (with no real validation)
            Console.Write("Enter a chair colour: ");
            colour = Console.ReadLine();

            // getting user input for chair name (again, not really validating)
            Console.Write("Enter a chair name: ");
            name = Console.ReadLine();

            // now, the fun stuff: we make the chair!
            // we're passing in the parameters we just took so that the constructor can use them
            Chair userChair = new Chair(type,material,colour,name);

            // because we now have a chair (and the Chair class has a method in it!), we can call our chair's method
            userChair.DisplayChairAttributes();
        }
    }
}
