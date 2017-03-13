using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Banking
{
    class Program
    { 
        static void Main(string[] args)
            /*Banking console application with 1 base class and 3 derived classes.  
              Would like to add exception handling on the some of the option selections 
              at some point in the near future.*/
        {
            //Instantiation of the 3 derived classes
            Savings mySavingsAccount = new Savings();
            Checking myCheckingAccount = new Checking();
            Reserve myReserveAccount = new Reserve();

            //Creation of Stream writer files
            StreamWriter savingsFile = new StreamWriter("Savings.txt");
            StreamWriter checkingFile = new StreamWriter("Checking.txt");
            StreamWriter reserveFile = new StreamWriter("Reserve.txt");
            
            savingsFile.WriteLine("Client: Albert King | Savings Account Number: 101");
            checkingFile.WriteLine("Client: Albert King | Checking Account Number: 801");
            reserveFile.WriteLine("Client: Albert King | Reserve Account Number: 1201");

            while (true) //Console menu
            {
                Console.WriteLine("\nPlease enter a number from the menu for one of the following banking options: ");
                Console.WriteLine("\n1) View Customer Account Information");
                Console.WriteLine("--------");
                Console.WriteLine("\nView account balance:");
                Console.WriteLine("2) Checking");
                Console.WriteLine("3) Savings");
                Console.WriteLine("4) Reserve");
                Console.WriteLine("--------");
                Console.WriteLine("\nMake a transaction:");
                Console.WriteLine("5) Deposit Money");
                Console.WriteLine("6) Withdrawal Money");
                Console.WriteLine("7) Quit");
                Console.WriteLine("Enter an option");

                int userResult = Convert.ToInt32(Console.ReadLine());
                Console.Clear();//clears console window for easier readability

                switch (userResult)
                {
                    case 1: //Gives option to view specific hard coded account info

                        Console.WriteLine("Choose account to view info");
                        Console.WriteLine("1) Checking");
                        Console.WriteLine("2) Savings");
                        Console.WriteLine("3) Reserve");

                        int accountEntered = Convert.ToInt32(Console.ReadLine());

                        switch (accountEntered)
                        {
                            case 1:
                                myCheckingAccount.CheckingCustomer();
                                break;

                            case 2:
                                mySavingsAccount.SavingsCustomer();
                                break;

                            case 3:
                                myReserveAccount.ReserveCustomer();
                                break;

                            default:
                                break;

                        }
                        break;

                    case 2: //Options to show specific account balances
                        myCheckingAccount.ShowBalance();
                        break;


                    case 3:
                        mySavingsAccount.ShowBalance();
                        break;


                    case 4:
                        myReserveAccount.ShowBalance();
                        break;

                    case 5://Options for accounts to deposit to

                        Console.WriteLine("Choose account to make deposit");
                        Console.WriteLine("1) Checking");
                        Console.WriteLine("2) Savings");
                        Console.WriteLine("3) Reserve");

                        int accountChoice = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Deposit Amount: ");

                        decimal depositAmount = decimal.Parse(Console.ReadLine());


                        switch (accountChoice) //shows account balances after deposit
                        {
                            case 1:
                                myCheckingAccount.Deposit(depositAmount);
                                Console.WriteLine("Checking balance: $ " + myCheckingAccount.AccountBalanceChecking);
                                checkingFile.WriteLine(depositAmount + "+ " + "Balance: $" + myCheckingAccount.AccountBalanceChecking + " " + DateTime.Now);
                                break;


                            case 2:
                                mySavingsAccount.Deposit(depositAmount);
                                Console.WriteLine("Savings balance: $ " + mySavingsAccount.AccountBalanceSavings);
                                savingsFile.WriteLine(depositAmount + "+ " + "Balance: $" + mySavingsAccount.AccountBalanceSavings + " " + DateTime.Now);

                                break;


                            case 3:
                                myReserveAccount.Deposit(depositAmount);
                                Console.WriteLine("Reserve balance: $ " + myReserveAccount.AccountBalanceReserve);
                                reserveFile.WriteLine(depositAmount + "+ " + "Balance: $" + myReserveAccount.AccountBalanceReserve + " " + DateTime.Now);
                                break;


                            default:
                                break;

                        }
                        break;

                    case 6: //Accounts to withdraw from

                        Console.WriteLine("Choose account to make withdrawl from: ");
                        Console.WriteLine("1) Checking Account");
                        Console.WriteLine("2) Savings Account");
                        Console.WriteLine("3) Reserve Account");


                        int clientChoice = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Enter withdrawl ammount: ");


                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());


                        switch (clientChoice) //shows account balances after withdraw
                        {
                            case 1:
                                myCheckingAccount.Withdraw(withdrawAmount);
                                Console.WriteLine("Checking balance $ " + myCheckingAccount.AccountBalanceChecking);
                                checkingFile.WriteLine(withdrawAmount + "- " + "Balance: $" + myCheckingAccount.AccountBalanceChecking + " " + DateTime.Now);
                                break;


                            case 2:
                                mySavingsAccount.Withdraw(withdrawAmount);
                                Console.WriteLine("Savings balance $ " + mySavingsAccount.AccountBalanceSavings);
                                savingsFile.WriteLine(withdrawAmount + "- " + "Balance: $" + mySavingsAccount.AccountBalanceSavings + " " + DateTime.Now);
                                break;


                            case 3:
                                myReserveAccount.Withdraw(withdrawAmount);
                                Console.WriteLine("Reserve balance $ " + myReserveAccount.AccountBalanceReserve);
                                reserveFile.WriteLine(withdrawAmount + "- " + "Balance: $" + myReserveAccount.AccountBalanceReserve + " " + DateTime.Now);
                                break;
                        }
                        break;

                    case 7:

                        break;


                    default:

                        break;

                } //Exit procedure
                Console.WriteLine("\nThank you for banking with us.  Press C to continue or any key to exit.");

                string c = Console.ReadLine();
                if (c.ToLower() == "c")
                {
                    Console.Clear();

                }
                else
                {
                    break;
                }
                
               
            }
            savingsFile.Close();
            checkingFile.Close();
            reserveFile.Close();
        }
        
    }
}









        
   
    

       
    


