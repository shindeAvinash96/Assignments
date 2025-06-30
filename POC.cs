namespace POC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter Name: ");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Company Name: ");
            emp.Company = Console.ReadLine();
            emp.showDetails();



            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Student stu = new Student(name);
            stu.Display();
           

            SalaryCal salaryCal = new SalaryCal();
            double net = salaryCal.CalculateSalary(500000);
            Console.WriteLine($"Net Salary: {net}");


        }
    }

    public class Person 
    {
        public string Name { get; set; }    

        public void Greet()
        {
            Console.WriteLine($"Hello, My Name is {Name}.");
        }


    }

    public class Employee : Person 
    {
        public string Company { get; set; }

        public void showDetails()
        {
            Greet();
            Console.WriteLine($"I Work at {Company}.");
        }
    }

    public class Student 
    {
        private string Name { get; set; }   

        public Student(string name)
        {
            this.Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Student Name is: {Name}");
        }
    }

    public class SalaryCal 
    {
        private const double TaxRate = 0.3;

        public double CalculateSalary(double Grosssalary)
        {
            return Grosssalary - (Grosssalary*TaxRate);
        }
    }



}
