using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentprofEnggCollege
{
    public class Student: Person
    {
        public String Branch {  get; set; }


       
        public Student(int id, string address, DateTime dob, string branch):base(id,address,dob)
        {
            Branch = branch;
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"Student Id={Id}\tStudent Address= {Address}\nStudent DOB={DOB}\tStudnet Branch={Branch}");
        }

    }
}
