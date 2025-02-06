using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemStatement1
{
    internal class LoginSystem
    {
        public String userName;
        public String password;

        public int check = 1;

        public void SignIn()
        {
            while(check <= 3)
            {
                Console.WriteLine("You have only 3 chance to SignIn otherwise your account get locked! ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Enter yoir Your UserName:");
                userName = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Enter yoir Your Password:");
                password = Console.ReadLine();
                Console.WriteLine();

                if (userName == "Admin")
                {
                    if (password == "Admin")
                    {
                        Console.WriteLine("Login Successfull !");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Password  !");
  
                    }

                }
                else
                {
                    Console.WriteLine("Incorrect User Name  !");
                    
                }

                if (check == 3)
                {
                    Console.WriteLine("Your Account Locked !");
                }
                check++;
            }


            


        }

    }
}
