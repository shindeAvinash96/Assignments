using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAppConstructorChaining
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; } // in meters
        public double Weight { get; set; } // in kg

        // Constructor 1
        public Person(int id, string name, int age, double height, double weight)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }

        // Constructor 2 (Chained)
        public Person(int id, string name, int age)
            : this(id, name, age, 1.5, 50) // default height 1.5m, weight 50kg
        {
        }

        public double CalculateBMI()
        {
            return Weight / (Height * Height);
        }

        public string GetBodyType()
        {
            double bmi = CalculateBMI();
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                return "Normal";
            else if (bmi >= 25 && bmi <= 29.9)
                return "Overweight";
            else
                return "Obese";
        }

        public void PrintInfo()
        {
            Console.WriteLine("Person Info:");
            Console.WriteLine($"Name: {Name}, Age: {Age}");
            Console.WriteLine($"Height: {Height}m, Weight: {Weight}kg");
            Console.WriteLine($"BMI Score: {CalculateBMI():F2}");
            Console.WriteLine($"Body Type: {GetBodyType()}");
        }
    }
}
