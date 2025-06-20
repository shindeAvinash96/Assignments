using System;

namespace GuessNumber{
	
	public class Program
	{
		public static void Main(String [] args)
		{
			Random rnd = new Random();
			int num = rnd.Next(1,100);
			int attempts = 0;

			int inc =1;

			
			

				while(attempts<5){

				Console.Write("Enter Number: ");
				int n = Convert.ToInt32(Console.ReadLine());
				if(num==n)
				{
					Console.WriteLine("Wow! You guessed it right in: "+inc +" attempts.");
					return;
				}else if(n>num)
				{
					Console.WriteLine("Sorry, Too High");
					
				}else
				{
					Console.WriteLine("Sorry, Too Low");
					
				}
				attempts++;
				inc++;
				}

				if(inc>5)
				{
					Console.Write("your attempts are over The Number was "+num);
				}
			
		}
	}

}