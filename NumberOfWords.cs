using System;
namespace NumberOfWords{
	public class Program
	{	
		public static void Main(string [] args)
		{
			Console.Write("Enter The sentence:  ");
			
			string sentence = Console.ReadLine();

			int counter=0;
			int len= sentence.Length;
			
			for(int i = 0; i<len;i++)
			{
				if(sentence[i]==' ')
				{
					counter++;
				}
			}
		
			Console.Write("The Number of words in sentence are: "+(counter+1));
		}
	}
}