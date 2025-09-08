using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_InheritanceUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
        Main:
            Console.WriteLine("Here are the available type of shirts1");
            Console.WriteLine("\n1. PoloShirt \n2. Sleeveless");
            Console.WriteLine("Input only numbers! \n\nSelect type of shirt you want: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter the brand of shirt you want: ");
                string brandName = Console.ReadLine();

                Console.Write("Enter your size: ");
                string shirtSize = Console.ReadLine();

                Console.Write("Enter color you want: ");
                string shirtColor = Console.ReadLine();

                PoloShirt poloShirt = new PoloShirt(brandName, shirtSize, shirtColor);

                poloShirt.PoloInfo();
            }
            else if (choice == 2)
            {
                Console.Write("Enter the brand of shirt you want: ");
                string brandName = Console.ReadLine();

                Console.Write("Enter your size: ");
                string shirtSize = Console.ReadLine();

                Console.Write("Enter what type of your sando: ");
                string sandoType = Console.ReadLine();

                Sando sando = new Sando(brandName, shirtSize, sandoType);

                sando.SandoInfo();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input!!");
            }

            Console.Write("You want to add another shoes? (y/n): ");
            char option = Convert.ToChar(Console.ReadLine());

            if (option == 'y')
            {
                goto Main;
            }
            else
            {
                return;
            }

            Console.ReadKey();
        }
    }
}
