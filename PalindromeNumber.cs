using System;

namespace PalindromeNumber{

	public class Program
	{
		public static void Main(string [] args)
		{

			Console.Write("Enter Number: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int num=0,ld=0,original=n;
			
			while(n>0)
			{
				ld=n%10;
				num = (num* 10)+ld;
				n/=10;
			}
			
			if(original==num)
			{
				Console.Write(original+ " is a Palindrome.");
			}else
			{
				Console.Write(original+ " is not palindrome.");
			}
		}
	}
}