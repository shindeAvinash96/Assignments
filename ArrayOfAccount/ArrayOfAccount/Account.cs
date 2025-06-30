using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfAccount
{
    internal class Account
    {
        private static Random rnd = new Random();
        public string AccountNumber { get; private set; }
        public string Name { get; set; }
        public double Balance { get; private set; }
        public string AccountType { get; set; }

        public Account(string name, string accountType, HashSet<string> existingAccountNumbers)
        {
            Name = name;
            AccountType = accountType;
            Balance = 500; 
            AccountNumber = GenerateUniqueAccountNumber(existingAccountNumbers);
        }

        private string GenerateUniqueAccountNumber(HashSet<string> existingAccounts)
        {
            string accNum;
            do
            {
                accNum = "IDBI" + rnd.Next(100000000, 999999999).ToString();
            } while (existingAccounts.Contains(accNum));

            existingAccounts.Add(accNum);
            return accNum;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                Console.WriteLine("Deposit amount must be positive.");
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && Balance - amount >= 500)
                Balance -= amount;
            else
                Console.WriteLine("Insufficient balance or invalid amount. Minimum balance ₹500 must be maintained.");
        }

        public void ViewBalance()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Current Balance: ₹{Balance}");
        }
    }
}
