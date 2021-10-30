using System;
using System.Collections.Generic;
using System.Text;

namespace Sudent
{
    class Student
    {
        public string Name { get; set; }
        public string  Surname { get; set; }
        static int ID=0;
        public string  No { get;}

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            No = ID++.ToString();
        }


    }
}
