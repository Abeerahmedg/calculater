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

                double num1 = 0; //the double to define numeric variables holding numbers with decimal points 
                double num2 = 0;
                double result = 0;

                Console.WriteLine("Please Enter The First number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Enter the Second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Select Operation Symbole: ");
                Console.WriteLine("\t+:Add , -:Substact , *:Multiply , /:Divide");

                string userChioce = Console.ReadLine();

                switch (userChioce)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your Result : {num1} + {num2} = " + result); //the $ sign to directly include valid C# expression in side a string literal using braces like {expression
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
                        
                        if (num2 == 0)
                        {
                            Console.WriteLine("Division with a Zero is not allowed");
                        }
                        else
                        {
                            result = num1 / num2;   
                            Console.WriteLine($"Your Result: {num1} / {num2} =" + result);
                        }
                        break;
                    default:
                        Console.WriteLine("That was not valid option");
                        break;
                }
                Console.WriteLine("Should we continue!(Press Y for Yes and N for No): ");
            }while(Console.ReadLine().ToUpper() == "Y"); // the check condition for the loop
            Console.WriteLine("See You again!");
            Console.ReadKey(); //to read the key press from the user
        }
    }
}