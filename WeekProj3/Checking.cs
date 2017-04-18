using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekProj3
{
    class Checking : Account
    {
        //Fields:

        //Default Con
        public Checking()
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


        public override double CheckingAccount
        {
            get { return this.checkingAccount; }
            set { this.checkingAccount = value; }
        }


        public override double SavingsAccount
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        //Constructor

        public Checking (string accountType, int accountNumb, double checkingAccount)
        {
            this.accountType = accountType;
            this.accountNumb = accountNumb;
            this.checkingAccount = checkingAccount;
        }



        //Method

        //Deposite

        public override void Deposit(double desiredAmount)
        {
            checkingAccount += desiredAmount;
        }


        //Witdraw

        public override void Withdraw(double desiredAmount)
        {
            checkingAccount -= desiredAmount;
        }



    }
}
