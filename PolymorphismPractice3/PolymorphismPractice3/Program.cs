using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are the avaiable type of shirt: \n1.PoloShirt \n2.Sando");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input only numbers!!");
            Console.ResetColor();
            Console.Write("Select what type of shirt you want: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            
            if (choice == 1)
            {
                Console.Write("\nEnter the brand of Poloshirt you want: ");
                string brand = Console.ReadLine();

                Console.Write("Enter the price of that PoloShirt: ");
                double price = Convert.ToDouble(Console.ReadLine());
                
                PoloShirt shirt = new PoloShirt();

                shirt.Brand = brand;
                shirt.Price = price;

                shirt.DiscountedPriceDisplay();
            }
            else if (choice == 2)
            {
                Console.Write("\nEnter what type of Sando you want: ");
                string type = Console.ReadLine();

                Console.Write("Enter the price of that Sando: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Sando sando = new Sando();

                sando.Type = type;
                sando.Price = price;

                sando.DiscountedPriceDisplay();
            }else
            {
                Console.WriteLine("Invalid Input");
            }

                Console.ReadKey();
        }
    }
}
