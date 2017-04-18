using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekProj3
{
    class Savings : Account
    {
        //Fields:

        protected double minBalance;


        //Default Con
        public Savings()
        {
            
        }


        //Properties

        public override string AccountType
        {
            get { return this.accountType; }
        }

        public override int AccountNumb
        {
            get { return this.accountNumb; }
        }


        public override double SavingsAccount
        {
            get { return this.savingsAccount; }
            set { this.savingsAccount = value; }
        }

        
        public override double CheckingAccount
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }


        public double MinBalance
        {
            get { return this.minBalance; }
            set { this.minBalance = value; }
        }

        //Constructor

        public Savings(string accountType, int accountNumb, double savingsAccount, double minBalance)
        {
            this.accountType = accountType;
            this.accountNumb = accountNumb;
            this.savingsAccount = savingsAccount;
            this.minBalance = minBalance;
        }


        //Method

        //Deposite

        public override void Deposit(double desiredAmount)
        {
            savingsAccount += desiredAmount;
        }


        //Witdraw

        public override void Withdraw(double desiredAmount)
        {
            savingsAccount -= desiredAmount;
        }



    }
}
