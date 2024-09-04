using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{
    public abstract class OnlineStore
    {
        private string name;
        private List<Product> products;

        //online store that works with many countries. Each country has different account setting, and regulations
        // and if we want to set it fit to every country it's becomes problem. 


        //this is the factory which can be implemented in the subclasses. 
        public abstract IAccount CreateAccount(); 

        public void DoManyStoreThings() { 
            //use in the account

            IAccount account = CreateAccount();
            account.Deposit(1000);
        
        }


        public override string ToString()
        {
            return $"Store:[name={name},products=\n{string.Join("\n",products)}]";
        }
    }
}
