using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO MY BANK");
            var choice = "-1";
            while (choice != "0")
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("*******************************************");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("have a great day!");
                        return;
                    case "1":
                        Console.Write("Email address: ");
                        var checkingAccount = new Account();
                        checkingAccount.EmailAddress = Console.ReadLine();
                        checkingAccount.AccountType = typeOfAccount.Checking;
                        checkingAccount.Deposit(1002.50M);
                        Console.WriteLine($"Account Number: {checkingAccount.AccountNumber}, Balance: {checkingAccount.Balance:C}");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
