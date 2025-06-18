using System;

namespace StudentsApp{
	public class Program
	{
		public static void Main(string [] args)
		{
			int [] fees = new int[5];
			for(int i=0;i<fees.Length;i++)
			{
				Console.WriteLine("Enter the fees for student  : "+(i+1));
				fees[i]=Convert.ToInt32(Console.ReadLine());
				while(fees[i]<5000 || fees[i]>10000)
				{
					Console.WriteLine("Enter amount between 5000-10000");
					Console.WriteLine("Enter the fees for student : ");
					fees[i]=Convert.ToInt32(Console.ReadLine());
					
				}

				
			}
			for(int i =0;i<fees.Length;i++)
			{
				if(fees[i]>7000)
				{
					fees[i]=fees[i]-(int)(fees[i]*0.05);
					
				}
			}
			Console.WriteLine("Fees with discount are as: ");
	
			for(int i=0;i<fees.Length;i++)
			{
				Console.WriteLine("Student "+(i+1)+" : "+fees[i]);
			}

			
			
			
			
		}
	}
}