namespace StudentGrading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Avinash");
            s1.Marks = 60;
            s1.Assigngrade();
            s1.DisplayInfo();

            Student s2 = new Student("Parth",89);
            s2.Assigngrade();
            s2.DisplayInfo();

            Student s3 = new Student("Sanket",81,'N');
            s3.Assigngrade();
            s3.DisplayInfo();

        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public char Grade { get; set; }


        public Student(string name)
        {
            this.Name = name;
            this.Marks = 0;
            this.Grade = 'N';


        }

        public Student(string name, int marks)
        {

            this.Name= name;
            this.Marks = marks;
            this.Grade = 'N';
        }
        public Student(string name, int marks, char grade) 
        {
            this.Name = name;   
            this.Marks = marks;
            this.Grade = grade;
        
        }

        public void Assigngrade()
        {
            if (Marks >= 90)
            {
                Grade = 'A';
            }else if((Marks>=80) && (Marks <= 89))
            {
                Grade = 'B';
            }else if((Marks>=70) && (Marks <= 79))
            {
                Grade = 'C';
            }
            else
            {
                Grade = 'D';
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name = {this.Name}");
            Console.WriteLine($"Marks = {this.Marks}");
            Console.WriteLine($"Grade = {this.Grade}");
        }



    }
}
