using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Banking
{
    class Reserve : Account
    {   //Fields
        private string clientName;
        private decimal accountBalanceReserve;
        private int accountNumberReserve;

        //Properties
        public String ClientName { get; set; }
        public decimal AccountBalanceReserve { get; set; }
        public int AccountNumberReserve { get; set; }

        //Constructor
        public Reserve()
        {
            this.clientName = "Albert King";
            this.AccountBalanceReserve = 20000;
            this.accountNumberReserve = 1201;
        }

        //Method for displaying specific customer/accountinfo
        public void ReserveCustomer()
        {
            Console.WriteLine("Account Holder: " + clientName);
            Console.WriteLine("Reserve Account Number: " + accountNumberReserve);
        }

        //Methods for calculating transactions
        public override decimal Deposit(decimal amount) //Method
        {
            DateTime TimeStamp = DateTime.Now;
            this.AccountBalanceReserve += amount;
            return this.AccountBalanceReserve;
        }

        public override decimal Withdraw(decimal amount)
        {
            DateTime TimeStamp = DateTime.Now;
            this.AccountBalanceReserve -= amount;
            return this.AccountBalanceReserve;
        }

        //Method to show balance
        public override void ShowBalance()
        {
            DateTime TimeStamp = DateTime.Now;

            Console.WriteLine("Reserve account balance: $" + AccountBalanceReserve + " " + TimeStamp);
        }
    }
}
