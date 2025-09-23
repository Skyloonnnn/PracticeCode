using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Here's the available shirt: \n1.Poloshirt \n2.Sando \nSelect type of shirt you want: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of shirt you want: ");
            double price = Convert.ToDouble(Console.ReadLine());

            if (choice == 1)
            {
                Shirt shirt = new PoloShirt();
                shirt.Price = price;

                shirt.DiscountedPriceDisplay();

            }
            else if (choice == 2)
            {
                Shirt shirt = new Sando();
                shirt.Price= price;

                shirt.DiscountedPriceDisplay();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

                Console.ReadKey();

            
        }
    }
}
