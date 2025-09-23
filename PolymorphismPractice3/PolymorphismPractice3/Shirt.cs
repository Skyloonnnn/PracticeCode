using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice3
{
    class Shirt
    {
        public double Price { get; set; }

       
        public virtual double CalculatePrice()
        {
            double discount = Price * 0.35;
            return Price - discount;
        }

        public virtual void DiscountedPriceDisplay()
        {
            Console.WriteLine($"Final Price: {CalculatePrice():.00}");
        }
    }

    class PoloShirt : Shirt
    {
        public double Discount { get; set; }

        public string Brand { get; set; }
        public override double CalculatePrice()
        {
            
            Discount = Price * 0.45;
            return Price - Discount;
        }

        public override void DiscountedPriceDisplay()
        {
            Console.WriteLine($"\nThe brand of the PoloShirt: {Brand}");
            Console.WriteLine($"Here's the final PoloShirt price: {CalculatePrice():.00}");
            Console.WriteLine($"\nCalculation of discount: \n{Price} - {Discount} = {CalculatePrice()}");
        }
    }

    class Sando : Shirt
    {
        public double Discount { get; set ; }
        public string Type { get; set; }

        public override double CalculatePrice()
        {
            Discount = Price * 0.50;
            return Price - Discount;

        }

        public override void DiscountedPriceDisplay()
        {
            Console.WriteLine($"\nThe type of Sando: {Type}");
            Console.WriteLine($"Here's the final Sando price: {CalculatePrice():.00}");
            Console.WriteLine($"\nCalculation of discount: \n{Price} - {Discount} = {CalculatePrice()}");
        }
    }
}
