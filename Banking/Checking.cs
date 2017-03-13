using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Banking
{
    class Checking : Account
    {   //Fields
        private string clientName;
        private decimal accountBalanceChecking;
        private int accountNumberChecking;

        //Properties
        public String ClientName { get; set; }
        public decimal AccountBalanceChecking { get; set; }
        public int AccountNumberChecking { get; set; }

        //Constructor
        public Checking()
        {
            this.clientName = "Albert King";
            this.AccountBalanceChecking = 5000;
            this.accountNumberChecking = 801;
        }

        //Method for displaying specific customer/accountinfo
        public void CheckingCustomer()
        {
            Console.WriteLine("Account Holder: " + clientName);
            Console.WriteLine("Checking Account Number: " + accountNumberChecking);
        }

        //Methods for calculating transactions
        public override decimal Deposit(decimal amount) //Method
        {
            DateTime TimeStamp = DateTime.Now;
            this.AccountBalanceChecking += amount;
            return this.AccountBalanceChecking;
          

        }

        public override decimal Withdraw(decimal amount)
        {
            
            this.AccountBalanceChecking -= amount; 
            return this.AccountBalanceChecking;
        }

        //Method to show balance
        public override void ShowBalance()
        {
            DateTime TimeStamp = DateTime.Now;

            Console.WriteLine("Checking account balance: $" + AccountBalanceChecking + " " + TimeStamp);
        }
    }
}

