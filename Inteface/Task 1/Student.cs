using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class Student
    {

        public string  Name { get;  }
        public string  Surname { get;  }
        public int  Age { get;}
        public  int Counter;
        public static  int id;

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;

            Counter = id++;
            
        }
    }
}
