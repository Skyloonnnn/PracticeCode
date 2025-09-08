using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_InheritanceUserInput
{
    class Shirt
    {
        public string brand;
        public string size;

        public Shirt(string brandName, string shirtSize)
        {
            brand = brandName;
            size = shirtSize;
        }

        public void ShirtInfo()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Shirt Brand:  {brand} \nShirt Size: {size}");
        }

    }

    class PoloShirt : Shirt
    {
        public string color;

        public PoloShirt(string brandName, string shirtSize, string shirtColor) : base (brandName, shirtSize)
        {
            color = shirtColor;
        }

        public void PoloInfo()
        {
            ShirtInfo();
            Console.WriteLine($"Color of polo: {color}");
        }
    }
}
