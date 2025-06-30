namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string in name,company,location format");
            string sentence = Console.ReadLine();

            //split function breaks string to arrayt of substring
            string[] parts = sentence.Split(',');

            if (parts.Length == 3)
            {
                Console.WriteLine($"Developer Name is: {parts[0]}");
                Console.WriteLine($"Company Name is: {parts[1]}");
                Console.WriteLine($"Location is: {parts[2]}");
            }
            else
            {
                Console.WriteLine("String is inserted in invalid format.");
            }
        }
    }
}
