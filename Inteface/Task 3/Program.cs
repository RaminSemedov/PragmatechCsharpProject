using System;

namespace ConsoleApp31
{
    interface ISum {
        public double Sum(params double[] number);

    }
   interface IMultiply
    {
        public double Multiple(params double[] numbers);
    }
    interface IDifference
    {
        public double Difference(params double[] numbers);
    }
    interface IDevide
    {
        public double Devide(params double[] numbers);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Multiple(1,2,3,4,5,6));
            Console.WriteLine(calculator.Devide(1,2,3,4,5,6));
            Console.WriteLine(calculator.Difference(1,2,3,4,5,6));
            Console.WriteLine(calculator.Sum(1,2,3,4,5,6));


        }
    }
}
