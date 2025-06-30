namespace ArrayOfAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many accounts you want to manage: ");
            int n = int.Parse(Console.ReadLine());
            Account[] accounts = new Account[n];
            HashSet<string> existingAccountNumbers = new HashSet<string>();

            int count = 0;
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==== Bank Menu ====");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. View Balance");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (count < n)
                        {
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Account Type (Savings/Current): ");
                            string type = Console.ReadLine();

                            accounts[count] = new Account(name, type, existingAccountNumbers);
                            Console.WriteLine($"Account created successfully! Account Number: {accounts[count].AccountNumber}");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Account limit reached.");
                        }
                        break;

                    case 2:
                        Console.Write("Enter Account Number: ");
                        string accNoView = Console.ReadLine();
                        var accView = FindAccount(accounts, accNoView);
                        if (accView != null)
                            accView.ViewBalance();
                        else
                            Console.WriteLine("Account not found.");
                        break;

                    case 3:
                        Console.Write("Enter Account Number: ");
                        string accNoDeposit = Console.ReadLine();
                        var accDeposit = FindAccount(accounts, accNoDeposit);
                        if (accDeposit != null)
                        {
                            Console.Write("Enter amount to deposit: ");
                            double amount = double.Parse(Console.ReadLine());
                            accDeposit.Deposit(amount);
                        }
                        else
                            Console.WriteLine("Account not found.");
                        break;

                    case 4:
                        Console.Write("Enter Account Number: ");
                        string accNoWithdraw = Console.ReadLine();
                        var accWithdraw = FindAccount(accounts, accNoWithdraw);
                        if (accWithdraw != null)
                        {
                            Console.Write("Enter amount to withdraw: ");
                            double amount = double.Parse(Console.ReadLine());
                            accWithdraw.Withdraw(amount);
                        }
                        else
                            Console.WriteLine("Account not found.");
                        break;

                    case 5:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

            Console.WriteLine("Thank you for using our banking system.");
        

    }


        static Account FindAccount(Account[] accounts, string accNo)
        {
            foreach (var acc in accounts)
            {
                if (acc != null && acc.AccountNumber == accNo)
                    return acc;
            }
            return null;
        }
    }
}
