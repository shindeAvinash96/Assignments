using System;
namespace PrimeNum{
	public class Program
	{
		public static void Main(string [] args)
		{
			Console.Write("Enter a Number: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int iterations1 = Convert.ToInt32(Math.Sqrt(n));
			bool primeNumber = true;
			
			if(n<=1)
			{
				primeNumber=false; 
			}else{

			for(int i=2;i<=iterations1;i++)
			{
				if(n%i == 0)
				{
					primeNumber=false;
					break;
				}
			}
			}

			if(primeNumber)
			{
				Console.Write(n+" is Prime Number");
			}else
			{
				Console.Write(n+" is a Not Prime Number");
			}
		}
	}
}