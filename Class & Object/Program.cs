using System;

namespace ConsoleApp5
{
    class Student
    {
        string fullname;
        string groupNo;
        int age;
        public Student(string fullname,string groupNo,int age)
        {
            this.fullname = fullname;
            this.groupNo = groupNo;
            this.age = age;
        }
        public int GetBirthYear()
        {
            DateTime date = DateTime.Today;        

            return date.Year-this.age;
        }


    }






    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ramin Semedov","080A4",38);
            Console.WriteLine(student.GetBirthYear());
        }
    }
}
