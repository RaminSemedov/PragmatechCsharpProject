using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp26
{
    class User:Account
    {
        public override bool PasswordChecker(string password)
        {
            bool bigLetters = false;
            bool smallLetters = false;
            if (password.Length > 8 && !String.IsNullOrWhiteSpace(password))
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if(Convert.ToInt32(password[i])>96 && Convert.ToInt32(password[i]) < 123)
                    {
                        smallLetters = true;
                    }
                    else if(Convert.ToInt32(password[i]) > 64 && Convert.ToInt32(password[i]) < 91)
                    {
                        bigLetters = true;
                    }

                }
                if(bigLetters && smallLetters)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("The password must have big ang small letters!!");
                }
            }
            else
            {
                Console.WriteLine("Password length must be more than 8 characters or password can not be emtry!");
            }
                return false;

            
        }
        public string FullName { set; get; }
        public string EMail { set; get; }
        public string Password {
            set {
                if (this.PasswordChecker(value))
                {
                    this.Password = value;
                }
            }
            get
            {
                return this.Password;
            }
        
        
        }

       

        public override void ShowInfo()
        {

            Console.WriteLine($"User full name is {this.FullName}\nUser  e-EMail is {this.EMail}");

        }






    }
}
