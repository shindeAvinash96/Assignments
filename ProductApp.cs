namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product
            {
                Id = 1,
                Name = "TV",
                Price=5000,
                DiscountPercent=5
            };

            Product p2 = new Product
            {
                Id = 2,
                Name = "Mobile",
                Price = 15000,
                DiscountPercent = 15
            };
            Console.WriteLine("Details of Product 1: ");
            Console.WriteLine(p1.Display());

            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine("Details of Product 2: ");
            Console.WriteLine(p2.Display());





        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercent { get; set; }



        public double CostAfterDiscount()
        {
            return Price - (Price * (DiscountPercent / 100));
        }

        public string Display()
        {
            return $"Id:{Id}\nName: {Name} \nPrice: {Price} \nDiscount Percentage: {DiscountPercent}\nPrice after Discount: {CostAfterDiscount}";
        }

    }

    
}
