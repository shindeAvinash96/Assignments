using System;

namespace FactorialProgram{

	public class Program
	{
		public static void Main(string[] args)
		{

			Console.Write("Enter The Number: ");
			int n= Convert.ToInt32(Console.ReadLine());
			int factorial=1;

			if(n<=0)
			{
				Console.Write("Enter +ve integer greater than 0.");
			}

			for(int i =1;i<=n;i++)
			{
				factorial*=i;
			}
			Console.Write("The factorial of number" +n " is : "+ factorial);
			
		}
	}
}
