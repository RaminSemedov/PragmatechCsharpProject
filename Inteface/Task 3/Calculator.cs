using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp31
{
    class Calculator:ISum,IDevide,IDifference,IMultiply
    {
        public double Sum( params double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        public double Devide(params double[] numbers)
        {
            double dev = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    Console.WriteLine("You can not devide to zero");

                }
                else
                {
                    dev /= numbers[i];
                }
            }
            return dev;
        }

        public  double Difference(params double[] numbers)
        {
            double diff = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                diff -= numbers[i];
            }
            return diff;
        }

        public double Multiple(params double[] numbers)
        {
            double mult = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                mult *= numbers[i];
                if (numbers[i] == 0)
                    return 0;
            }
            return mult;
        }
    }
}
