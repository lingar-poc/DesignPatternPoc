using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{
    public class PublicBankComputer
    {
        private List<Account> connectedAccount = new List<Account>();

        private int maxConnected = 0;

        PublicBankComputer(int maxConnected)
        {
            this.maxConnected = maxConnected;
        }
    }
}
