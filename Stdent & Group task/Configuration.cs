using System;
using System.Collections.Generic;
using System.Text;

namespace Sudent
{
    class Configuration
    {
        List<Student> students = new List<Student>();
        List<Group> groups = new List<Group>();

        public void CreateStudent()
        {
            Console.WriteLine("Enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student surname");
            string surname = Console.ReadLine();
            students.Add(new Student(name, surname));




        }
        public void CreateGroup()
        {
            Console.WriteLine("Enter group name");
            string name = Console.ReadLine();
            int capasity = 0;
            Console.WriteLine("Enter group capasity");
            while (true)
            {

            try
            {
                    capasity =Convert.ToInt32( Console.ReadLine());
                    break;

                }
                catch(FormatException) {
                    Console.WriteLine("Please enter a digit");
                }
            }

            groups.Add(new Group(name, capasity));
        }

        public void ShowAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Please create a student");
            }
            else
            {
                foreach (var item in students)
                {
                    Console.WriteLine($"ID: {item.No}\n Name {item.Name}\nSurname {item.Surname} ");
                }
            }
            
        }
        public void ShowAllGroups()
        {
            if (groups.Count == 0)
            {
                Console.WriteLine("Please create a group");
            }
            else
            {
                foreach (var item in groups)
                {
                    Console.WriteLine($"ID: {item.No}\nName: {item.Name}\n Capasity: {item.Capasity}");
                }
            }
        }
        public void  AddStudentToGroup()
        {
            string groupNumber;
            string studentNumber;
            Student student = null; ;
            Group group = null; ;

            while (true) {
            Console.WriteLine("Please enter group number");
             groupNumber = Console.ReadLine();
            Console.WriteLine("Please enter student number");
             studentNumber = Console.ReadLine();
                if(groupNumber!=null && studentNumber != null)
                {
                    break;
                }
                    }

            foreach (var item in groups)
            {
                if (item.No == groupNumber)
                {
                    group = item;
                    break;
                }
               
            }
            foreach (var item in students)
            {
                if (item.No == studentNumber)
                {
                    student = item;
                    break;
                }
                
            }
            if (group == null)
            {
                Console.WriteLine("The group number you have entered is not exist");
            }
            else if (student == null)
            {
                Console.WriteLine("The student number you have entered is not exist");
            }
            else
            {
                bool flag = true;
                for (int i = 0; i < groups.Count; i++)
                {
                    for (int j = 0; j < groups[i].students.Count; j++)
                    {
                        if(groups[i].students[j].No== studentNumber)
                        {
                            flag = false;
                            Console.WriteLine("The student that you want to add is exsist in other group");
                            break;
                        }
                        
                    }

                }
                if (flag)
                {
                    group.AddStudent(student);
                    
                }

            }







        }
        public void ShowStudentsFromGroup()
        {
            Console.WriteLine("Enter group number");
            string groupNumber = Console.ReadLine();
            if (groupNumber != null)
            {
                Group group = null;
                foreach (var item in groups)
                {
                    if (item.No == groupNumber)
                    {
                        group = item;
                        break;
                    }
                }
                if (group != null)
                {
                    foreach (var item in group.students)
                    {
                        Console.WriteLine($"ID: {item.No}\n Name {item.Name}\nSurname {item.Surname} ");
                    }
                }
                else
                {
                    Console.WriteLine("Your group did not find!");
                }
            }
            else
            {
                Console.WriteLine("Enter correct data");
            }

           
            
        }



        public void Run()
        {
            bool flag = true;
            int choice;
            while (flag)
            {
                Console.WriteLine(@"
1 - Create new student
2 - Create new Group
3 - Show all students
4 - Show all groups
5 - Add student in a group
6 - Show student from selected group
7 - Exit
");
                while (true) { 
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                        if(choice>0 && choice < 8)
                        {
                            break;
                        }
                        else
                        {
                            throw new FormatException();
                        }
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Please enter correct data");
                    }
                }
                switch (choice)
                {
                    case 1:
                        CreateStudent();
                        break;
                    case 2:
                        CreateGroup();
                        break;
                    case 3:
                        ShowAllStudents();
                        break;
                    case 4:
                        ShowAllGroups();
                        break;
                    case 5:
                        AddStudentToGroup();
                        break;
                    case 6:
                        ShowStudentsFromGroup();
                        break;
                    case 7:
                        flag = false;
                        break;
                }

            }




        }
    }
}
