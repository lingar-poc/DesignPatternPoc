using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_Akiva_Cohen.bank_app;

namespace DesignPatternPoc.app
{
    public class DemoDesignPatterns
    {
        public static void Demo()
        {
            Console.WriteLine("Demo design pattern");

            Owner owner = new Owner("Yakov", "Levi");
            Account account = new Account(owner, 120000, 10000);
            Console.WriteLine("Account = " + account);

            //Account clonedAccout = account;// not good - only refernce
            Account clonedAccout = new Account();
            clonedAccout.Overdraft = account.Overdraft;
            clonedAccout.Owner = owner;//---> not cloned
            //Owner new owner.... 
            clonedAccout.Balance = account.Balance;

            clonedAccout.Balance = 200000;
            owner.FirstName = "John";
            Console.WriteLine("Account = " + account);
            Console.WriteLine("new Account = " + clonedAccout);


            Account clonedAccout2 = (Account) clonedAccout.Clone();
            clonedAccout2.Balance = 300000;
            Console.WriteLine("clonde1 Account = " + clonedAccout);
            Console.WriteLine("clonde2 Account = " + clonedAccout2);
            clonedAccout2.Owner.FirstName = "Moshe";

            Console.WriteLine("Account = " + account);
            Console.WriteLine("clonde1 Account = " + clonedAccout);
            Console.WriteLine("clonde2 Account = " + clonedAccout2);


            Account cloned3 = clonedAccout2.ShallowCopy();

            cloned3.Overdraft = 20;
            owner.LastName = "ABC";
            Console.WriteLine("clonde1 Account = " + clonedAccout);
            Console.WriteLine("clonde2 Account = " + clonedAccout2);
            Console.WriteLine("clonde3 Account = " + cloned3);
            Account cloned4 = cloned3.DeepCopy();
            cloned4.Overdraft = 10;
            cloned4.Owner.FirstName = "New";
            Console.WriteLine("After deep clone");
            Console.WriteLine("clonde1 Account = " + clonedAccout);
            Console.WriteLine("clonde2 Account = " + clonedAccout2);
            Console.WriteLine("clonde3 Account = " + cloned3);
            Console.WriteLine("cloned4 Account = " + cloned4);

            Account cloned5 = new Account(cloned4);//another way to cloning. 





            //it's possible that account be another IAccount 

        }
    }
}
