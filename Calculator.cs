using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProblemStatement1
{
    internal class Calculator
    {
        public int num1;
        public int num2;
        public int result;

        public void MenuDrivenCalculator()
        {
            Console.WriteLine("Enter Number1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number2 :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("1. Addition \n2. Subtraction \n3. Multiplication \n4. Division \n5. Exit ");
                Console.WriteLine();
                Console.WriteLine("Enter your Choice : ");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine(num1 + " + " + num2 + " = " + result);
                        break;

                    case 2:
                        result = num1 - num2;
                        Console.WriteLine(num1 + " - " + num2 + " = " + result);
                        break;

                    case 3:
                        result = num1 * num2;
                        Console.WriteLine(num1 + " * " + num2 + " = " + result);
                        break;

                    case 4:
                        result = num1 / num2;
                        if(num2 == 0)
                        {
                            Console.WriteLine("you Cannot divide by 0 ");
                            break;
                        }
                        Console.WriteLine(num1 + " / " + num2 + " = " + result);
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice !!! ");
                        break;

                }


            }
        }
    }
}
