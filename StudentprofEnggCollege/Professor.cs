using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentprofEnggCollege
{
   public class Professor:Person
    {
        public double NoOfHrs { get; set; }

        public double RatePerHr = 400;

        public Professor(int id,string address,DateTime dob,double noOfHrs):base(id,address,dob)
        {
            NoOfHrs = noOfHrs;

        }

        public double CalculateSalary()
        {
            double Salary = NoOfHrs * RatePerHr;
            return Salary;
        }

        public void DisplayProf()
        {
            Console.WriteLine($"Prof. Id={Id}\tProf. Address={Address}\tProf. DOB={DOB}\nNo.Of Hrs Worked={NoOfHrs}\tSalary={CalculateSalary()}");
        }

    }
}
