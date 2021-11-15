using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandwich_Shop
{
    class Order
    {
        public Bread bread;
        public List<Ingredient> listOfIngredients { get; set; } = new List<Ingredient>();
    }
}
