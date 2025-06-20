using System;

namespace PigDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalScore = 0;
            int turn = 1;
            Random rand = new Random();

            Console.WriteLine("Let's Play PIG!\nReach 20 points to win.");
            Console.WriteLine("* Turn ends when you hold or roll a 1.");
            Console.WriteLine("* If you roll a 1, you lose all points for the turn.");
            Console.WriteLine("* If you hold, you save all points for the turn.\n");

            while (totalScore < 20)
            {
                Console.WriteLine($"\nTURN {turn}");
                int turnScore = 0;
                bool continueTurn = true;

                while (continueTurn)
                {
                    Console.Write("Roll or hold? (r/h): ");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "r")
                    {
                        int die = rand.Next(1, 7); // Random number between 1 and 6
                        Console.WriteLine($"Die: {die}");

                        if (die == 1)
                        {
                            Console.WriteLine("Turn over. No score.");
                            turnScore = 0;
                            continueTurn = false;
                        }
                        else
                        {
                            turnScore += die;
                        }
                    }
                    else if (choice == "h")
                    {
                        Console.WriteLine($"\nScore for turn: {turnScore}");
                        totalScore += turnScore;
                        Console.WriteLine($"Total score: {totalScore}");
                        continueTurn = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'r' to roll or 'h' to hold.");
                    }
                }

                turn++;
            }

            Console.WriteLine($"\nYou finished in {turn - 1} turns!");
            Console.WriteLine("Game over!");
        }
    }
}
