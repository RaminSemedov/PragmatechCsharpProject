using System;

    //Student.cs olsun, Name, Surname, Age propertyleri olsun, 
    //ancaq constructorda set olsun. Neche defe instance aldigimizi qaytaran Counter olsun, 
    //hansiniki yalniz constructorda set ede bilek.


namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("xxx", "yyy", 38);
            Student student1 = new Student("aaa", "ssss", 52);

           
            Console.WriteLine(student.Counter);

            Console.WriteLine(student1.Counter);



                }
    }
}
