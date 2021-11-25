using System;
using System.Collections.Generic;

namespace ConsoleApp40
{

    static class MyExtention
    {
        public static bool IsOdd(this int number)
        {
            if (number % 2 != 0)
                return true;
            return false;
        }
        public static bool IsEven(this int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
        }
        public static bool IsContainsDigit(this string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if(Convert.ToInt32(text[i])>47 && Convert.ToInt32(text[i]) < 58)
                {
                    return true;
                }
            }
            return false;
        }

        public static List<int> GetValueIndexes(this string s,char c)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    indexes.Add(i);
                }
            }
            if(indexes.Count!=0)
            return indexes;
            return null;
        }

        public static List<int> GetValueIndexes(this int[] arr,int num)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    indexes.Add(i);
                }
            }
            if (indexes.Count != 0)
                return indexes;
            return null;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 56,1,5,1,2,1 };
            foreach (var item in arr.GetValueIndexes(1))
            {
                Console.WriteLine(item);
            }
        }
    }
}
