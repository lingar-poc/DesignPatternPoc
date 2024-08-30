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
            Console.WriteLine("Design patterns");
            Console.WriteLine("Singleton");
            //Account a = new Account();//compilation error
            Account a = Account.GetInstance();
            a.SetBalance(500);
            Console.WriteLine("a = " + a);

            Account b = Account.GetInstance();
            Console.WriteLine("b = " + b);

            b.SetBalance(1000);
            Console.WriteLine("a = " + a);

            Console.WriteLine("a == b ? " + a.Equals(b));

            AnotherMethod();
        }

        public static void AnotherMethod()
        {
            Account someAccount = Account.GetInstance();

            Console.WriteLine("someAccount" + someAccount);

        }
    }
}
