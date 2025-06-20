using System;

namespace BookDiscCal{

	public class Program
	{
		public static void Main(String [] args)
		{
			 Book book1 = new Book("The Power of Habit", "Charles Duhigg", 600.00, true);
       			 Book book2 = new Book("C# Programming", "Jane Doe", 450.00, false);
	
        		 book1.CalculateDiscountedPrice();
        		 book2.CalculateDiscountedPrice();

              		 Book book3 = new Book("Beginner's Guide to AI", "Sam Tech", 520.00, false);
       			 Book book4 = new Book("Fast Money", "Rachel Green", 300.00, true);

                         book3.CalculateDiscountedPrice();
                         book4.CalculateDiscountedPrice();
  

		}

		class Book
		{

  		  public string Title { get; set; }
   		  public string Author { get; set; }
                  public double Price { get; set; }
                  public bool IsBestseller { get; set; }

                  public Book(string title, string author, double price, bool isBestseller)
                  {
                   Title = title;
                   Author = author;
                   Price = price;
                   IsBestseller = isBestseller;
                  }

                   public double CalculateDiscountedPrice()
                   {
                     double discountedPrice = Price;

                     Console.WriteLine("\nTitle: "+Title);
                     Console.WriteLine("Author: "+Author);
                     Console.WriteLine("Original Price: "+Price);

                   if (IsBestseller)
                   {
                   Console.WriteLine(Title+ " is a bestseller. Applying 10% discount.");
                   discountedPrice *= 0.90;
                   }

                   if (Price > 500)
                   {
                    Console.WriteLine(Title+ " is priced over 500. Applying additional 5% discount.");
                    discountedPrice *= 0.95;
                    }

                    Console.WriteLine("Final Discounted Price: "+discountedPrice);
                    return discountedPrice;
		   }
		}
	}
}
		

	