using System;

namespace BankGameApp
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(string accountHolder, double initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine(AccountHolder+" deposited "+amount+" New Balance: "+Balance);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine(AccountHolder+" attempted to withdraw "+amount+" but insufficient funds. Current Balance: "+Balance);
            }
            else
            {
                Balance -= amount;
                Console.WriteLine(AccountHolder+" withdrew"+amount+" New Balance: "+Balance);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Random rand = new Random();

            BankAccount account1 = new BankAccount("Account1", rand.Next(1000, 5001));
            BankAccount account2 = new BankAccount("Account2", rand.Next(1000, 5001));

            Console.WriteLine("Starting Balances:");
              Console.WriteLine(account1.AccountHolder+": "+account1.Balance);
            Console.WriteLine(account2.AccountHolder+": "+account2.Balance);

            for (int round = 1; round <= 3; round++)
            {
                Console.WriteLine("\n--- Round {round} ---");

                ProcessTurn(account1);
                ProcessTurn(account2);
            }

            Console.WriteLine("\n--- Final Balances ---");
            Console.WriteLine(account1.AccountHolder+": "+account1.Balance);
            Console.WriteLine(account2.AccountHolder+": "+account2.Balance);

            if (account1.Balance > account2.Balance)
                Console.WriteLine(account1.AccountHolder+" wins!");
            else if (account2.Balance > account1.Balance)
                Console.WriteLine(account2.AccountHolder+" wins!");
            else
                Console.WriteLine("It's a tie!");
        }

        static void ProcessTurn(BankAccount account)
        {
            Console.Write(account.AccountHolder+" Withdraw or Deposit (w/d): ");
            string choice = Console.ReadLine().ToLower();

            Console.Write("Amount: ");
            if (double.TryParse(Console.ReadLine(), out double amount))
            {
                if (choice == "d")
                    account.Deposit(amount);
                else if (choice == "w")
                    account.Withdraw(amount);
                else
                    Console.WriteLine("Invalid option. Turn skipped.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Turn skipped.");
            }
        }
    }
}
