using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekProj3
{
    abstract class Account
    {
        //Fields:
        protected int accountNumb;
        protected string accountType;

        protected double overallBalance;
        protected double checkingAccount;
        protected double savingsAccount;
        protected double balance; 

        protected double deposit;
        protected double withdraw; 

        //Default Con
        public Account()
        {


        }


        //Properties

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public double OverallBalance
        {
            get { return this.overallBalance; }
            set { this.overallBalance = value; }
        }

        public virtual double CheckingAccount
        {
            get { return this.checkingAccount; }
            set { this.checkingAccount = value; }
        }


        public virtual double SavingsAccount
        {
            get { return this.savingsAccount; }
            set { this.savingsAccount = value; }
        }


        //Overrides

        public abstract string AccountType
        {
            get;
        }


        public virtual int AccountNumb
        {
            get;
        }


        //Constructor

        public Account(int accountNumb, string accountType, double checkingAccount, double savingsAccount, double balance, double deposit, double withdraw)
        {
            this.accountNumb = accountNumb;
            this.accountType = accountType;
            this.checkingAccount = checkingAccount;
            this.savingsAccount = savingsAccount;
            this.balance = savingsAccount + checkingAccount;
            this.deposit = deposit;
            this.withdraw = withdraw;
        }


        //Methods

        public void ViewBalance()  //View balance: savings, checking!
        {
            Console.WriteLine("Would you like to view the balance of your Checking Account, Savings Account, or your Total overall balance?");
            Console.WriteLine("\nA. Checking Account Balance");
            Console.WriteLine("\nB. Savings Account Balaance");
        }

        public void MyAccountStatus()
        {
            Console.WriteLine("Checking Account Balance: " + checkingAccount);
            Console.WriteLine("Savings Account Balance: " + savingsAccount);
            Console.WriteLine("Total Balance: " + overallBalance);
        }


        //Total Balance

        public void TotalBalance()
        {
            overallBalance = savingsAccount + checkingAccount;
        }


        public string GetTotalBalance()
        {
            return "Total Balance: " + overallBalance + "\n";
        }


        //Deposite

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }


        //Witdraw

        public virtual void Withdraw(double amount)
        {
            balance -= amount;
        }


        //Get Balance
        public double GetBalance()
        {
            return balance;
        }





    }
}
