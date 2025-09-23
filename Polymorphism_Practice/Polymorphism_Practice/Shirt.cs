using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Practice
{
    class Shirt
    {
        public double Discount { get; set; }

        public double Price { get; set; }

        public virtual double DiscontedPrice
        {
            get { return Price - Discount; }
        }
    }

    class PoloShirt : Shirt
    {
        public override double DiscontedPrice
        {
            get { return Price - Discount; }
        }
    }

    class Sando : Shirt
    {
        public override double DiscontedPrice
        {
            get { return Price - Discount; }
        }
    }
}
