// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main (string[] args)
        {
            do
            {

                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("Please Enter Your First number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Enter the Second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Selectan Operation: ");
                Console.WriteLine("\t+ : ADD");
                Console.WriteLine("\t- : SUBSTRACT");
                Console.WriteLine("\t* : MULTIPLY");
                Console.WriteLine("\t/ : DIVIDE");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your Result : {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your Result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your Result: {num1} * {num2} =" + result);
                        break;
                    case "/":
                        if (num1 != 0 && num2 != 0 )
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Your Result: {num1} / {num2}= " + result);
                        }
                        else Console.WriteLine("This was divided by zero");
                        break;
                    default:
                        Console.WriteLine("That was not valid option");
                        break;
                }
                Console.WriteLine("Would you like to continue ! (Y = Yes, N = No): ");
            }while(Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("See You again!");
            Console.ReadKey();
        }
    }
}