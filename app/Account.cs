using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternPoc.app;

namespace c_sharp_apps_Akiva_Cohen.bank_app
{
    public class Account
    {
        private Owner owner;
        private double balance;
        private int overdraft;
        private const double MAX_OVERDRAFT = 90_000;

        public double Balance { get => balance; set => balance = value; }

        public Account(Owner owner, double balance, int overdraft)
        {
            this.owner = owner;
            this.Balance = balance;
            SetOverdraft(overdraft);
        }

        public Owner GetOwner() { return owner; }
        public double GetBalance() { return Balance; }
        public int GetOverdraft() { return overdraft; }

        public void SetOverdraft(int overdraft)
        {
            if (overdraft < MAX_OVERDRAFT)
                this.overdraft = overdraft;
            else
                Console.WriteLine("You cannot do overdraft more then " + MAX_OVERDRAFT);
        }

        public override string ToString()
        {
            return $"Account: [owner= {owner}, balance = {Balance}, overdraft = {overdraft}]";
        }


        public void TransferMoney(Account other, int amount)
        {
            //Console.WriteLine("Action of checking your id...");

            //Console.WriteLine("Action of checking the other account validation");

            //Console.WriteLine("Check balance");

            //from.Balance -= amount;
            //to.Balance += amount;
            TransferFacade facade = new TransferFacade();
            facade.Transfer(this, other, amount);
          
        }

        //public void Deposit(double amount) { this.balance += amount; }
        //public void Withdraw(double amount)
        //{
        //    if (amount < overdraft + balance)
        //        this.balance -= amount;
        //    else
        //        Console.WriteLine("You cannot exceed the overdraft");
        //}
    }
}
