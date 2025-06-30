using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingNew
{
    internal class Student
    {
        private string studentName;
        private string rollNumber;
        private int[] marks; // array of 5 subjects

        public Student(string name, string rollNumber, int[] marks)
        {
            this.studentName = name;
            this.rollNumber = rollNumber;

            if (marks.Length != 5)
                throw new ArgumentException("Marks array must contain exactly 5 subjects.");

            this.marks = marks;
        }

        public double CalculateAverage()
        {
            int total = 0;
            foreach (int mark in marks)
                total += mark;

            return total / 5.0;
        }

        public string CalculateGrade()
        {
            double average = CalculateAverage();

            if (average >= 90)
                return "A+";
            else if (average >= 80)
                return "A";
            else if (average >= 70)
                return "B";
            else if (average >= 60)
                return "C";
            else if (average >= 50)
                return "D";
            else
                return "Fail";
        }

        public override string ToString()
        {
            return "Student Report Card\n" +
                   "----------------------------\n" +
                   $"Name        : {studentName}\n" +
                   $"Roll No     : {rollNumber}\n" +
                   $"Marks       : [{string.Join(", ", marks)}]\n" +
                   $"Average     : {CalculateAverage():F1}\n" +
                   $"Grade       : {CalculateGrade()}";
        }
    }
}
