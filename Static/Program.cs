using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Account
    {
        public string userName;
        public string password;
        public int no;
        static int id;

        public Account(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            this.no = ++id; 
            
        }
    }



    class Program
    {
        static bool IsUserNameValid(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
            if(!(Convert.ToInt32(s[i])> 47 && Convert.ToInt32(s[i]) < 58)&&
              !(Convert.ToInt32(s[i]) > 64 && Convert.ToInt32(s[i]) < 90)&&
              !(Convert.ToInt32(s[i]) > 95 && Convert.ToInt32(s[i]) < 123))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsPassWordvalid(string s)
        {
            if (s.Length >= 8 && s.Length <= 25)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if(Convert.ToInt32(s[i]) > 47 && Convert.ToInt32(s[i])<58    ||
                       Convert.ToInt32(s[i]) > 64 && Convert.ToInt32(s[i]) < 90  ||
                       Convert.ToInt32(s[i]) > 95 && Convert.ToInt32(s[i]) < 123 ||
                       Convert.ToInt32(s[i]) > 32 && Convert.ToInt32(s[i]) < 48  || 
                       Convert.ToInt32(s[i]) > 58 && Convert.ToInt32(s[i]) < 65){

                                    return true;
                    }
                                
                               
                            

                       
                    
                }
            }
            return false;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Create an Account");
            Console.WriteLine("Please enter a user Name: Use only letters and  digits");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter a user Password: ");
            string userPasswoerd= Console.ReadLine();
            if (IsUserNameValid(userName) && IsPassWordvalid(userPasswoerd))
            {
                Account account = new Account(userName, userPasswoerd);
                Console.WriteLine(account.no);
            }
            else
            {
                Console.WriteLine("You entered a wrong data!!!");
            }




        }
    }
}
