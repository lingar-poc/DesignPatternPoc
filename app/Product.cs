using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{

    //SKU, Expiration Date, Weight
    public class Product
    {


        private string name;
        private double price;
        private string description;
        private bool inStock;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public bool InStock { get => inStock; set => inStock = value; }

        public override string ToString()
        {
            return $"Product:[name = {name}, price = {price}" +
                $", description={description}, inStock={inStock}";
        }
    }
}
