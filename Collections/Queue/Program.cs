using System;
using System.Collections.Generic;

namespace ConsoleApp18
{

     class MyQueue
    {
        public Queue<string> queue = null;
        public MyQueue()
        {
            this.queue = new Queue<string>();
        }
        public void Add(string item)
        {
            if (queue.Count < 10)
            {
            this.queue.Enqueue(item);
            }
            else
            {
                string[] arr= this.queue.ToArray();
                this.queue.Clear();
                for (int i = 0; i < arr.Length-1; i++)
                {
                    queue.Enqueue(arr[i]);
                }                
                this.queue.Enqueue(item);
            }
        }

       
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue my = new MyQueue();
            my.Add("Item1");
            my.Add("Item2");
            my.Add("Item3");
            my.Add("Item4");
            my.Add("Item5");
            my.Add("Item6");
            my.Add("Item7");
            my.Add("Item8");
            my.Add("Item9");
            my.Add("Item10");

            foreach (var item in my.queue)
            {
                Console.WriteLine(item);
            }

            my.Add("Item11");

            Console.WriteLine(new string('-',50));

            foreach (var item in my.queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
