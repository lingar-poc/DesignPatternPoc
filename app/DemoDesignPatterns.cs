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

            PublicBankComputer publicBankComputer = new PublicBankComputer(3);
            Account account1 = publicBankComputer.GetAccount();
            Account account2 = publicBankComputer.GetAccount();
            Account account3 = publicBankComputer.GetAccount();
            //this will be null because pool is full
            Account account4 = publicBankComputer.GetAccount();
            publicBankComputer.FinishUsing(account1);
            account4 = publicBankComputer.GetAccount();
            account4.SetOverdraft(400);
            Console.WriteLine("account 4 = " + account4);







        }
    }
}
