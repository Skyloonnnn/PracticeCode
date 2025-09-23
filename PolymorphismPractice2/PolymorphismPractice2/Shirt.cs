using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice2
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
        public double discount;
        
        public override double CalculatePrice()
        {
            
            discount = Price * 0.45;
            return Price - discount;
        }

        public override void DiscountedPriceDisplay()
        {
            Console.WriteLine($"\nHere's the final PoloShirt price: {CalculatePrice():.00}");
            Console.WriteLine($"\nCalculation of discount: \n{Price} - {discount} = {CalculatePrice()}");
        }
    }

    class Sando : Shirt
    {
        public double discount;
        
        public override double CalculatePrice()
        { 
            discount = Price * 0.50;
            return Price - discount;
           
        }

        public override void DiscountedPriceDisplay()
        { 
            Console.WriteLine($"\nHere's the final Sando price: {CalculatePrice():.00}");
            Console.WriteLine($"\nCalculation of discount: \n{Price} - {discount} = {CalculatePrice()}");
        }
    }
}


