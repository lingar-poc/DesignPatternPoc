using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{
    public class DemoDesignPatterns
    {
        public static void Demo()
        {
            Console.WriteLine("Demo design pattern");

            MilkProductsRequiresFactory m = new MilkProductsRequiresFactory();
            MilkProduct milkProduct = new MilkProduct(m);
        }
    }
}
