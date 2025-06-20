using System;

using System.Linq;

namespace CommandLineApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] n = new int[5];
            int sum = 0;
            int avg, count, max, min;

            for (int i = 0; i < n.Length; i++)
            {
                Console.Write("Enter Number " + (i + 1) + ": ");
                n[i] = Convert.ToInt32(Console.ReadLine());
                sum += n[i];
            }

           
            CalculateValues(n, sum, out avg, out count, out max, out min);

        
            Console.WriteLine("Results:");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Minimum: " + min);
        }

        public static void CalculateValues(int[] n, int sum, out int avg, out int count, out int max, out int min)
        {
            max = n.Max();
            min = n.Min();
            avg = sum / n.Length;
            count = n.Length;
        }
    }
}
