using System;
using System.Collections.Generic;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            Console.WriteLine("Fill list with 10 digits");
            int a;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    myList.Add(a);
                }
                catch(FormatException e)
                {
                    Console.WriteLine("You entered a wrong data");
                    Console.WriteLine("Please enter only digits");
                    i = i - 1;
                }
            }

            foreach (var item in myList)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine(new string('-',5));

            int[] arr= myList.ToArray();
            myList.Clear();
            for (int i = arr.Length/2; i < arr.Length; i++)
            {
                myList.Add(arr[i]);
            }
            for (int i = 0; i < arr.Length/2; i++)
            {
                myList.Add(arr[i]);
            }

            foreach (var item in myList)
            {
                Console.WriteLine(item);

            }
        }
    }
}
