using c_sharp_apps_Akiva_Cohen.bank_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{
    public class ConcreteBuilders
    {
    }

    public class BisliBuilder : IProductBuilder
    {
        private Product product;
        public void Reset()
        {
            product = new Product();
        }
        

        public void BuildManufacture()
        {
            product.Manufacturer = new Manufacturer("Osem", "LTD");

        }

        public void BuildName()
        {
            product.Name = "Bisli";
        }

        public void BuildPackage()
        {
            product.Package = new Package();
            product.Package.Material = Material.NYLON;
        }

        public void BuildPrice()
        {
            product.Price = 3.30;
        }

        public Product Build()
        {
            this.Reset();
            BuildManufacture();
            BuildName();
            BuildPrice();
            BuildPackage();

            Product result = product;
            this.Reset();
            return result;
        }


    }
}
