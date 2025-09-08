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

        }
    }
}
