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
            Console.WriteLine("Select shoes that you want");
            Console.WriteLine("");

            string brandName = "";

            Console.Write("\n1. Nike \n2. Adidas \n3. Puma \nPick a numer of brand you want: ");
            string brandChoice = Console.ReadLine();

            if (brandChoice == "1")
            {
                brandName = "Nike";
            }
            else if (brandChoice == "2")
            {
                brandName = "Adidas";
            }
            else if (brandChoice == "3")
            {
                brandName = "Puma";
            }
            else
            {
                Console.WriteLine("Please select brand!!");
                goto Main;
            }

            Console.Write("What model of shoes you want: ");
            string shoesModel = Console.ReadLine();

            Shoes shoes = new Shoes(brandName, shoesModel);

            




            shoes.ShoeInfo();

            Console.ReadKey();
            

            
        }
    }
}
