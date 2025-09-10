using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_InheritanceUserInput
{
    class Shirt // base class
    {
        //Declare fields for Shirt Class
        public string brand;
        public int price;

        //Parameterized Constructor
        public Shirt(string brandName, int shirtPrice)
        {
            brand = brandName;
            price = shirtPrice;
        }

        //Method to display ShirtInfo
        public void ShirtInfo()
        {
            Console.WriteLine($"Shirt Brand:  {brand} \nShirt Size: ${price}");
        }
    }

    class PoloShirt : Shirt //Derived class
    {
        //Declare fields for PoloShirt Class
        public string color;
        public string type;

        //Parameterized Constructor
        public PoloShirt(string brandName, int shirtPrice, string shirtColor, string poloType) : base(brandName, shirtPrice)
        {
            color = shirtColor;
            type = poloType;
        }

        //Method to display PoloInfo
        public void PoloInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Here are the information of your PoloShirt\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            ShirtInfo();
            Console.WriteLine($"Color of polo: {color}");
            Console.WriteLine($"What type of polo: {type}");
        }
    }

    class Sando : Shirt //Derived class
    {
        //Declare fields for Sando Class
        public string type;
        public string size;

        //Parameterized Constructor
        public Sando(string brandName, int shirtSize, string sandoType, string sandoSize) : base(brandName, shirtSize)
        {
            type = sandoType;
            size = sandoSize;
        }

        //Method to display SandoInfo
        public void SandoInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Here are the information of your Sando\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            ShirtInfo();
            Console.WriteLine($"Type of sando: {type}");
            Console.WriteLine($"Sando size: {size}");
        }

    }
}
