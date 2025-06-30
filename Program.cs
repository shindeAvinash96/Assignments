namespace StudentGradingNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[] { 78, 85, 90, 88, 76 };

           
            Student student = new Student("Avinash Shinde", "R12", marks);

            
            Console.WriteLine(student.ToString());
        }
    }
}
