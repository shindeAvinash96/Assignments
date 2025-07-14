namespace StudentprofEnggCollege
{
    public class Program
    {

        List<Person> students = new List<Person>();
        List<Person> professor = new List<Person>(); 
        
        public static void Main(string[] args)

        {
            Program P = new Program();
            Console.WriteLine("<   ---------------Engineering College System------------------->");

            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine("Select:\n1.Add\n2.Display\n3.Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Enter:\n1.Add Student\n2.Add Professor");
                        int ch= int.Parse(Console.ReadLine());

                        switch (ch)
                        {
                            case 1:
                                P.AddStudent();
                                break;

                            case 2:
                                P.Addprofessor();
                                break;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                                
                        }
                        break;

                    case 2:

                        Console.WriteLine("Enter:\n1.Display Student\n2.Display Professor");
                        int option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                P.DisplayStudent();
                                break;

                            case 2:
                                P.DisplayProfessor();
                                break;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;

                        }
                        break;

                    case 3:
                        isExit = true;
                        break;


                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }


            }
        }

        public  void AddStudent()
        {

            int id;
            string address,branch;
            DateTime dob;
            string dob1;
        

            Console.Write("Enter The ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter The Address: ");
            address = Console.ReadLine();

            Console.Write("Enter The DOB (in DD/MM/YYYY format):");
           dob1 = Console.ReadLine();

           dob= DateTime.Parse(dob1);


            Console.Write("Enter the branch: ");
            branch = Console.ReadLine();

            students.Add(new Student(id,address,dob,branch));



        }

        public void Addprofessor()
        {

            int id;
            string address;
            DateTime dob;
            string dob1;
            double noOfHrs;


            Console.Write("Enter The ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter The Address: ");
            address = Console.ReadLine();

            Console.Write("Enter The DOB (in DD/MM/YYYY format):");
            dob1 = Console.ReadLine();

            dob = DateTime.Parse(dob1);


            Console.Write("Enter No of hours worked: ");
            noOfHrs = double.Parse(Console.ReadLine());

            professor.Add(new Professor(id, address, dob,noOfHrs));



        }

        public void DisplayStudent()
        {
            if(students.Count == 0)
            {
                Console.Write("Students List is Empty");
                return;
            }
            foreach (Student stu in students) 
            {
                stu.DisplayStudent();
            }

           
        }


        public void DisplayProfessor()
        {
            if (professor.Count == 0)
            {
                Console.Write("Professors List is Empty");
                return;
            }
            foreach (Professor prof in professor)
            {
                prof.DisplayProf();
            }


        }
    }
}
