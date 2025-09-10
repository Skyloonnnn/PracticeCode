using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_InheritanceUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sky Loon
            //IT306
            //Exercise 8: Inheritance with User Input

        Main:
            //Ask User to choose what type of shirt the want
            Console.WriteLine("Here are the available type of shirts");
            Console.WriteLine("\n1. PoloShirt \n2. Sleeveless");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input only numbers! ");
            Console.ResetColor(); //To reset to default color
            Console.Write("\nSelect type of shirt you want: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            //Condition and process
            if (choice == 1)
            {
                Console.Clear(); //Clear after choosing what type of shirt

                //Ask user to input the following Sando
                Console.WriteLine("Please fill the following for PoloShirt");
                Console.Write("\nEnter the brand of shirt you want: ");
                string brandName = Console.ReadLine();

                Console.Write("Enter the price of that shirt: ");
                int shirtPrice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter color you want: ");
                string shirtColor = Console.ReadLine();

                Console.Write("What type of polo you want: ");
                string poloType = Console.ReadLine();

                //Instantiate the PoloShirt Class
                PoloShirt poloShirt = new PoloShirt(brandName, shirtPrice, shirtColor, poloType);

                //Call the method to display PoloInfo
                poloShirt.PoloInfo();
            }
            else if (choice == 2)
            {
                Console.Clear(); //Clear after choosing what type of shirt

                //Ask user to input the following for Sando
                Console.WriteLine("Please fill the following for Sando");
                Console.Write("\nEnter the brand of shirt you want: ");
                string brandName = Console.ReadLine();

                Console.Write("Enter the price of that shirt: ");
                int shirtPrice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter what type of your sando: ");
                string sandoType = Console.ReadLine();

                Console.Write("Enter you size: ");
                string sandoSize = Console.ReadLine();

                //Instantiate the Sando Class
                Sando sando = new Sando(brandName, shirtPrice, sandoType, sandoSize);

                //Call the method to display SandoInfo
                sando.SandoInfo();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input!!");
            }

            Console.ResetColor();
            //Ask user to input another or try again
            Console.Write("\nYou want to try again/add another shoes? (y/n): ");
            char option = Convert.ToChar(Console.ReadLine());
            Console.Clear();

            if (option == 'y')
            {
                goto Main;
            }
            else
            {
                return;
            }


        }
    }
}
