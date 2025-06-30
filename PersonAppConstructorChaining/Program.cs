namespace PersonAppConstructorChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Avinash", 25, 1.75, 68);
            person1.PrintInfo();

            Console.WriteLine("\n------------------------\n");

           
            Person person2 = new Person(2, "Parth", 21);
            person2.PrintInfo();
        }
    }
}
