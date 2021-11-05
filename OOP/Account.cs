using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
      abstract class Account
    {
       public  abstract bool PasswordChecker(string password);
        public virtual void ShowInfo() { }
    }


}
