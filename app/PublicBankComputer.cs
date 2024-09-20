using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{
    public class PublicBankComputer
    {
        private List<Account> connectedAccounts = new List<Account>();

        private int maxConnected = 0;

        public PublicBankComputer(int maxConnected)
        {
            this.maxConnected = maxConnected;
            for(int i = 0; i < maxConnected; i++)
            {
                connectedAccounts.Add(null);
            }

        }
        public Account GetAccount()
        {
            for (int i = 0; i < this.connectedAccounts.Count; i++)
            {
                if (this.connectedAccounts[i] == null)
                {
                    this.connectedAccounts[i] = new Account();
                    return this.connectedAccounts[i];
                }
            }
            Console.WriteLine("all slots on hold");
            return null;
        }

        public void FinishUsing(Account account)
        {

            int index = connectedAccounts.IndexOf(account);
            connectedAccounts[index] = null;

        }
    }
}
