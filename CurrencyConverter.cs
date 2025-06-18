using System;

namespace CurrencyConverter{
	public class Program
	{
		public static void Main(string [] args)
		{
			
			Console.Write("Enter the amount: ");
			int n= Convert.ToInt32(Console.ReadLine());
			int i=0,j=0,k=0,l=0;

			if(n<0 || n>50000 || n %100 !=0 )
			{
				Console.Write("Enter valid number");
				return;
			}

			i = n/ 2000;
			n%=2000;
			j = n/ 500;
			n%=500;
			k = n/ 200;
			n%=200;
			l=n/100;


			Console.WriteLine("₹2000 : "+i);
			Console.WriteLine("₹500 : "+j);
			Console.WriteLine("₹200 : "+k);
			Console.WriteLine("₹100 : "+l);
		}
	}
}