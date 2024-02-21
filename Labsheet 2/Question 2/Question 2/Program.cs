using Question_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class BankAccount
    {
        public string AccountNumber { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0.0;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
                return;
            }

            Balance += amount;
            Console.WriteLine("Your new balance is :"+Balance);
        }
    }

}   
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Enter your account number: ");
        string accountNumber = Console.ReadLine();

        BankAccount myAccount = new BankAccount(accountNumber);

        Console.Write("Enter amount to deposit: ");
        double depositAmount = Convert.ToDouble(Console.ReadLine());

        myAccount.Deposit(depositAmount);

        Console.ReadLine();
    }
    }
