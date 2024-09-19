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
       

        

        public override string ToString()
        {
            return $"Product:[name = {name}, price = {price}";
              
        }
    }
}
