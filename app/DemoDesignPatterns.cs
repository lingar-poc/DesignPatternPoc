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

            Product bisli = new BisliBuilder().Build();
            Console.WriteLine("Bisli = " + bisli);
        }
    }
}
