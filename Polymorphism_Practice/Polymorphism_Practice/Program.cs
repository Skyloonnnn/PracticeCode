using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shirt polo = new PoloShirt { Price = 450, Discount = 100 };
            Shirt sando = new Sando { Price = 600, Discount = 150 };

            Console.WriteLine($"Here's the final PoloShirt price: {polo.DiscontedPrice}");
            Console.WriteLine($"\nHere's the final Sando price: {sando.DiscontedPrice}");

            Console.ReadKey();
        }
    }
}
