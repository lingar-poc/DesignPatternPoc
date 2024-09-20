using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_Akiva_Cohen.bank_app;

namespace DesignPatternPoc.app
{
    public class Product
    {
        private string name;
        private Package package;
        private double price;
        private Manufacturer manufacturer;

        public string Name { get => name; set => name = value; }
        public Package Package { get => package; set => package = value; }
        public double Price { get => price; set => price = value; }
        public Manufacturer Manufacturer { get => manufacturer; set => manufacturer = value; }

        public override string ToString()
        {
            return $"Product:[name = {Name}, price = {Price}, Manufacturer = {Manufacturer} " +
                $"package = {Package.Material}";
              
        }
    }
}
