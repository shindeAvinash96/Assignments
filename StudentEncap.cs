namespace StudentEncap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            
            for(int i = 0; i < students.Length; i++)
            {
                Console.Write($"Enter the Roll Number of student {i+1}:  ");
                int rollNum = int.Parse(Console.ReadLine());

                Console.Write("Enter the name of student: ");
                string name = Console.ReadLine();

                if (name.Length < 5)
                {
                    name = null;
                }

                Console.Write("Enter CGPA of student: ");
                double cgpa = double.Parse(Console.ReadLine());

                if(cgpa <0 && cgpa > 11)
                {
                    cgpa = 0.0D;
                }

                students[i] = new Student(rollNum, name,cgpa);
            }

            for(int i =0;i< students.Length;i++)
            {
                Console.WriteLine($"Details of student{i + 1}: ");
                students[i].DisplayStudent();
            }
        }
    }

    public class Student 
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        public double CGPA { get; set; }

        public Student(int rollNo, string name,double cgpa)
        {
            this.RollNo = rollNo;
            this.Name = name;
            this.CGPA = cgpa;


        }

        public double CgpaToPercent(double CGPA)
        {
            return CGPA*9.5;
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"Roll Number: {RollNo}\nName: {Name}\nCGPA: {CGPA}\nPercentage: {CgpaToPercent(CGPA)}");
        }
    }


}
