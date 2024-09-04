using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{
    public interface IAccount
    {
        void Withdraw(int amount);

        void Deposit(int amount);

        bool TrasferMoney(int amount, IAccount other);

    }
}
