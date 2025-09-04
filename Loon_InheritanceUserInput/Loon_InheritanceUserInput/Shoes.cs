using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_InheritanceUserInput
{
    class Shoes
    {
        public string brand, model;

        public Shoes(string brandName, string shoeModel)
        {
            brand = brandName;
            model = shoeModel;
        }

        public void ShoeInfo()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("\tHere are the shoes you want");
            Console.WriteLine($"Shoe Brand: {brand} \nShoe Model: {model}");
        }

    }
    class ShoesSize : Shoes
    {
        public int size;

        public ShoesSize(string brandName, string shoeModel, int shoeSize) : base(brandName, shoeModel)
        {
            ShoeInfo();
            size = shoeSize;
        }

        public void SizeInfo()
        {
            Console.WriteLine($"Shoe size: {size}");
        }
    }
}
