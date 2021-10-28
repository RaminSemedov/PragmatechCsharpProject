using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp19
{
    public class MyCollection:IEnumerable,IEnumerator,IDisposable
    {
        public List<int> myList=new List<int>();
        
        int position = -1;
        public object Current
        {
            get { return myList[position]; } 
           
        
        }

        public void Add(int item)
        {
            if (myList.Contains(item) == false)
            {
                myList.Add(item);
            }
            myList.Sort();
        }

        public IEnumerator GetEnumerator()
        {
            return myList.GetEnumerator() as IEnumerator;
        }

        public bool MoveNext()
        {
            if (position < myList.Count - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            Reset();
        }

        public int this[int index]
        {
            set
            {

                if (myList.Contains(value) == false)
                {
                    if (index >= 0 && index < myList.Count)
                    {
                        myList[index] = value;
                        myList.Sort();

                    }

                }
                   

            }
            get
            {   
                if(index>=0 && index < myList.Count)
                {
                return myList[index];
                }
                return 0;
            }


        }

}
class Program
{
    static void Main(string[] args)
    {
            MyCollection collection = new MyCollection();
            collection.Add(5);
            collection.Add(5);
            collection.Add(6);
            collection.Add(1);
            collection.Add(3);
            collection[0] = 3;
            Console.WriteLine(collection[6]);
            Console.WriteLine("-----------------");


            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }



        }
}
}


