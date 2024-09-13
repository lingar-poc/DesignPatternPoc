using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_Akiva_Cohen.bank_app;

namespace DesignPatternPoc.app
{
    public class TransferFacade
    {
        public void Transfer(Account from, Account to, int amount)
        {
            Console.WriteLine("Action of checking your id...");

            Console.WriteLine("Action of checking the other account validation");

            Console.WriteLine("Check balance");

            from.Balance -= amount;
            to.Balance += amount;

        }
    }
}
