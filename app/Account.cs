﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPoc.app
{
    public class Account
    {
        private Owner owner;
        private double balance;
        private int overdraft;
        private const double MAX_OVERDRAFT = 90_000;

        private static Account myInstance = null;

        //private Account(Owner owner, double balance, int overdraft)
        //{
        //    this.owner = owner;
        //    this.balance = balance;
        //    SetOverdraft(overdraft);
        //}

        public static Account GetInstance()
        {

            //return myInstance == null ? new Account() : myInstance;

            if(myInstance == null)
            {
                myInstance = new Account();
            }
            return myInstance;

        }


        //Private constructor - blocking public access to this class 
        private Account() { }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        public void SetOwner(Owner owner)
        {
            this.owner = owner;
        }

        public Owner GetOwner() { return owner; }
        public double GetBalance() { return balance; }
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
            return $"Account: [owner= {owner}, balance = {balance}, overdraft = {overdraft}]";
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
