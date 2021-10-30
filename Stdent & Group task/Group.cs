using System;
using System.Collections.Generic;
using System.Text;

namespace Sudent
{
    class Group
    {
        public string Name { get; set; }
        static int ID = 100;
        public string No { get; }
        public int Capasity { get; }
        public readonly List<Student> students = new List<Student>();

        public Group(string name, int capasity)
        {
            this.Name = name;
            this.Capasity = capasity;
            No = name[0] + (++ID).ToString();
        }

        public void AddStudent()
        {
            Console.WriteLine("Enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student surname");
            string surname = Console.ReadLine();

            if (students.Count < Capasity)
            {


                students.Add(new Student(name, surname));
                Console.WriteLine("New student added to group");
            }
            else
            {
                Console.WriteLine("Would you like to change student's list capasity 'Y'/'N' ");
                string choice = Console.ReadLine().ToUpper().Trim();
                while (choice != "Y" || choice != "N")
                {
                    Console.WriteLine("Please enter 'Y' or 'N' ");
                }
                if (choice == "Y")
                {
                    students.Add(new Student(name, surname));
                    Console.WriteLine("New student added to group");
                }

            }

        }

        public void AddStudent(Student student)
        {
            if (students.Count < Capasity)
            {


                students.Add(student);
                Console.WriteLine("New student added to group");
            }
            else
            {
                Console.WriteLine("Would you like to change student's list capasity 'Y'/'N' ");
                string choice = Console.ReadLine().ToUpper().Trim();
                while (choice != "Y" || choice != "N")
                {
                    Console.WriteLine("Please enter 'Y' or 'N' ");
                }
                if (choice == "Y")
                {
                    students.Add(student);
                    Console.WriteLine("New student added to group");
                }


            }


        }
    }
}
