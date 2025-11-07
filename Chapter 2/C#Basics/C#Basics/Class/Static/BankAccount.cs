using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.Class.Static
{
    public class BankAccount
    {
        private string AccountHolder { get; set; }
        private double Balance { get;  set; }

        public BankAccount(string holder, double initialBalance)
        {
            AccountHolder = holder;
            Balance = initialBalance;
        }

        // Instance method
        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"{AccountHolder} deposited {amount}. New balance: {Balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{AccountHolder} withdrew {amount}. Remaining balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"{AccountHolder}'s balance: {Balance}");
        }
    }

  

}
