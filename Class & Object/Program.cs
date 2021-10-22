using System;

namespace ConsoleApp5
{
    class Student
    {
        public string fullname;
        public string groupNo;
        public  int age;
        public Student(string fullname, string groupNo, int age)
        {
            this.fullname = fullname;
            this.groupNo = groupNo;
            this.age = age;
        }
        public int GetBirthYear()
        {
            DateTime date = DateTime.Today;
            return date.Year - this.age;
        }


    }






    class Program
    {

         static int CountStudents(  string groupNumber ,Student[] students)
        {
            int sum = 0;
            

            for (int i = 0; i < students.Length; i++)
            {
                if (groupNumber == students[i].groupNo)
                    sum++;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Student[] students = new Student[2];
            try
            {
                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine("Enter Fullname");
                    string fullname = Console.ReadLine();
                    Console.WriteLine("Enter Group Number");
                    string groupNumber = Console.ReadLine();
                    Console.WriteLine("Enter Age");
                    int age = Convert.ToInt32(Console.ReadLine());

                    students[i] = new Student(fullname, groupNumber, age);
                }
            }catch(Exception)
            {
                Console.WriteLine("You entered a wrong data");
            }
            

            Console.WriteLine("Enter group number to  get count of students");
            string groupNo = Console.ReadLine() ;
            Console.WriteLine($"In group number {groupNo }:study  {CountStudents(groupNo, students)} students");

        }
    }
}