using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandwich_Shop
{
    class Bread
    {
        public Bread() { }

        public Bread(string name, double price, int numOfIngredients)
        {
            Name = name;
            Price = price;
            NumOfIngredients = numOfIngredients;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int NumOfIngredients { get; set; }
    }
}
