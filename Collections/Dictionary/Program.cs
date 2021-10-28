using System;
using System.Collections.Generic;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            string country;
            string capital;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter country name: ");
                country = Console.ReadLine();
                Console.WriteLine("Enter capital name:  ");
                capital = Console.ReadLine();
                capitals.Add(country, capital);
            }

            foreach (var item in capitals)
            {
                Console.WriteLine(item.Key);

            }





            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter country name to find capital");
                string countryName = Console.ReadLine();
                if(countryName=="All" || countryName == "all")
                {
                    foreach (var item in capitals)
                    {
                        Console.WriteLine($"{item.Value} is capital of {item.Key}");
                    }
                }
                else
                {
                    foreach (var item in capitals)
                    {
                        if (countryName == item.Key)
                        {
                            Console.WriteLine($"{item.Value} is capital of {item.Key}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Country that you entered is not consist in this list");
                            break;
                        }
                    }
                }

                bool check = true;              
                while (check) {
                Console.WriteLine("Would you like to find another capital  Y/N ");
                 string choice = Console.ReadLine();
                if(choice=="N" || choice == "n")
                    {
                        Console.WriteLine("Good Bye!!");
                        flag = false;
                        break;
                    }
                else if(choice == "Y" || choice == "y")
                    {
                        break;
                        
                    }
                else 
                    {
                        Console.WriteLine("Please enter 'Y' or 'N' ");
                    }
                
                         }


            }


        }
    }
}
