using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Banking
{
    public abstract class Account
    {   //Fields
        private int accountNumber;
        private string accountType;

        private decimal accountBalance;

        //Properties
        public int AccountNumber { get; set; }
        public string AccountType { get; set; }

        public decimal AccountBalance { get; set; }
        
        //Constructor
        public Account() 
        { 
            
        }
       
        //Methods
        public virtual decimal Deposit(decimal amount) 
        {
            this.accountBalance += amount;
            return this.accountBalance;
        }

        public virtual decimal Withdraw(decimal amount)
        {
            this.accountBalance -= amount;
            return this.accountBalance;
        }

        public virtual void ShowBalance()
        {
            Console.WriteLine("Account Balance: $ ");
            
        }
        
       
    }
}
