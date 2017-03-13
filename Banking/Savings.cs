using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Banking
{
    class Savings : Account
    {   //Fields
        private string clientName;
        private decimal accountBalanceSavings;
        private int accountNumberSavings;
        
        //Properties
        public String ClientName { get; set; }
        public decimal AccountBalanceSavings { get; set; }
        public int AccountNumberSavings { get; set; }

        //Constructor
        public Savings()
        {
            this.clientName = "Albert King";
            this.AccountBalanceSavings = 2500;
            this.accountNumberSavings = 101;        
                
        }

        //Method for displaying specific customer/accountinfo
        public void SavingsCustomer()
        {
            Console.WriteLine("Account Holder: " + clientName);
            Console.WriteLine("Savings Account Number: " + accountNumberSavings);
        }

        //Methods for calculating transactions
        public override decimal Deposit(decimal amount) 
        {
            
            DateTime TimeStamp = DateTime.Now;
            this.AccountBalanceSavings += amount;
            return this.AccountBalanceSavings;
        }

        public override decimal Withdraw(decimal amount)
        {
           // DateTime TimeStamp = DateTime.Now;
            this.AccountBalanceSavings -= amount;
            return this.AccountBalanceSavings;
        }

        //Method to show balance
        public override void ShowBalance()
        {
            DateTime TimeStamp = DateTime.Now;
            
            Console.WriteLine("Savings account balance: $" + AccountBalanceSavings + " " + TimeStamp);
        }

    }
}
