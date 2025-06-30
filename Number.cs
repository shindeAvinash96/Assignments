using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceWithCalisthenics
{
    public class Program
{
    static void Main(string[] args)
    {

        Game game = new Game();
        game.Play();
    }
}
     public class Die
 {
     private readonly Random random = new Random();

     public Number Roll()
     {
         return new Number(random.Next(1, 7));
     }
 }
     public class Game
 {
     private readonly Die die = new Die();
     private readonly Player[] players;
     private int currentPlayerIndex = 0;

     public Game()
     {
         players = new Player[]
         {
             new Player("Player 1"),
             new Player("Player 2")
         };
     }

     public void Play()
     {
         while (true)
         {
             Player currentPlayer = players[currentPlayerIndex];
             Console.WriteLine($"\n{currentPlayer.Name()}'s Turn. Total Score: {currentPlayer.TotalScore()}");

             Score turnScore = new Score();

             while (true)
             {
                 Console.Write("Roll or Hold? (r/h): ");
                 string input = Console.ReadLine().Trim().ToLower();

                 if (input == "h")
                 {
                     currentPlayer.AddToScore(new Number(int.Parse(turnScore.ToString())));
                     Console.WriteLine($"{currentPlayer.Name()} holds. New Total Score: {currentPlayer.TotalScore()}");
                     break;
                 }

                 Number roll = die.Roll();
                 Console.WriteLine($"Rolled: {roll}");

                 if (roll.IsOne())
                 {
                     Console.WriteLine("Rolled a 1! Turn over. No points added.");
                     break;
                 }

                 turnScore = turnScore.Add(roll);
                 Console.WriteLine($"Turn Score: {turnScore}");
             }

             if (currentPlayer.HasWon())
             {
                 Console.WriteLine($"\n🎉 {currentPlayer.Name()} wins the game with {currentPlayer.TotalScore()} points!");
                 break;
             }

             SwitchTurn();
         }
     }

     private void SwitchTurn()
     {
         currentPlayerIndex = (currentPlayerIndex + 1) % players.Length;
     }
 }

    public class Player
{
    private readonly string name;
    private Score totalScore = new Score();

    public Player(string name)
    {
        this.name = name;
    }

    public void AddToScore(Number points)
    {
        totalScore = totalScore.Add(points);
    }

    public bool HasWon()
    {
        return totalScore.IsGreaterOrEqualTo(new Number(100));
    }

    public string Name()
    {
        return name;
    }

    public Score TotalScore()
    {
        return totalScore;
    }

}

    public class Score
{
    private readonly int value;

    public Score()
    {
        value = 0;
    }

    public Score(int value)
    {
        this.value = value;
    }

    public Score Add(Number number)
    {
        return new Score(value + number.ToInt());
    }

    public bool IsGreaterOrEqualTo(Number number)
    {
        return value >= number.ToInt();
    }

    public override string ToString()
    {
        return value.ToString();
    }

}

    

    
    
    public class Number
    {
        private readonly int value;

        public Number(int value)
        {
            this.value = value;
        }

        public bool IsOne()
        {
            return value == 1;
        }

        public int ToInt()
        {
            return value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
