namespace CalculatorMethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();

            int intresult = c1.Add(5,10);
            Console.WriteLine($"result of int: {intresult}");


            double floatresult = c1.Add(5.5, 10.5);
            Console.WriteLine($"result of double {floatresult}");


            int [] inputArray = { 1,2,3,4,5,6,};
            int outputSum = c1.Add(inputArray);
            Console.WriteLine($"result of array: {outputSum}");

            int[] nullArray = null;
            int nullArrayresult = c1.Add(nullArray);
            Console.WriteLine($"(result should be 0): {nullArrayresult}");

            int[] emptyArray = new int[0];
            int emptyArrayResult = c1.Add(emptyArray);
            Console.WriteLine($"(result should be 0 ): {emptyArrayResult}");

        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public  double Add(double a, double b)
        {
            return a + b;
        }
        public int Add(int[] numbers)
        {
            int sum = 0;
            if ((numbers== null) || (numbers.Length==0))
            {
                Console.WriteLine("Array is null or empty");
                return 0;

            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum = sum + numbers[i];
                    return sum;

                }
            }

            return 0;
           
        }


    }
}
