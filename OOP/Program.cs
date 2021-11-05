using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.FullName = "User1";
            user.EMail = "user@email.com";
         
            user.ShowInfo();
            Console.WriteLine(user.PasswordChecker("AbhbhbAss"));








        }
    }
}
