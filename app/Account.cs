using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Akiva_Cohen.bank_app
{
    public class Account : ICloneable
    {
        private Owner owner;
        private double balance;
        private int overdraft;
        private const double MAX_OVERDRAFT = 90_000;



        //Copying constructor
        public Account(Account account)
        {
            //todo here the cloning
            this.owner = account.Owner;//u can do it deep. 
            // Owner other = new Owner(owner.GetFirstName(), owner.GetLastName());
            this.balance = account.Balance;
            //...
        }
        public Owner Owner { get => owner; set => owner = value; }
        public double Balance { get => balance; set => balance = value; }
        public int Overdraft { get => overdraft; set => overdraft = value; }

        public static double MAX_OVERDRAFT1 => MAX_OVERDRAFT;

        public Account() { }
        public Account(Owner owner, double balance, int overdraft)
        {
            this.Owner = owner;
            this.Balance = balance;
            SetOverdraft(overdraft);
        }

        public Owner GetOwner() { return Owner; }
        public double GetBalance() { return Balance; }
        public int GetOverdraft() { return Overdraft; }

        public void SetOverdraft(int overdraft)
        {
            if (overdraft < MAX_OVERDRAFT1)
                this.Overdraft = overdraft;
            else
                Console.WriteLine("You cannot do overdraft more then " + MAX_OVERDRAFT1);
        }

        public override string ToString()
        {
            return $"Account: [owner= {Owner}, balance = {Balance}, overdraft = {Overdraft}]";
        }

        public object Clone()
        {
            Account account = new Account();
            //for doing it deep u need to create new owner
            account.owner = owner;
            account.balance = balance;
            //return account;
            return new Account(owner, balance, overdraft);  


            //throw new NotImplementedException();
        }


        //Copy only the direct properties without cloning the references 
        public Account ShallowCopy()
        {
           return (Account)MemberwiseClone();
        }
        public Account DeepCopy()
        {
            Account account = (Account)MemberwiseClone();

            Owner other = new Owner(owner.GetFirstName(), owner.GetLastName());
            account.Owner = other;

            return account;
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
