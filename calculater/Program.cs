using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;



double Addition(double num1, double num2)
{
    return num1 + num2;
}
double Substract(double num1, double num2)
{
    return (num1 - num2);   
}
double Multiply(double num1, double num2)
{
    return (num1 * num2);
}
double Divide(double num1, double num2)
{
    return (num1 / num2);
}
do
{



    double num1 = 0; //the double to define numeric variables holding numbers with decimal points
    double num2 = 0;
    double result = 0;




    Console.WriteLine("Selectan Operation: ");
    Console.WriteLine("\t+:Add , -:Substact , *:Multiply , /:Divide");





    switch (Console.ReadLine())
    {
        case "+":
            num1 = AskUserForNumber();
            num2 = AskUserForNumber();

            result = Addition(num1, num2);
            Console.WriteLine($"The Result : {num1} + {num2} = " + result); //the $ sign to directly include valid C# expression in side a string literal using braces like {expression

            break;
        case "-":
            num1 = AskUserForNumber();
            num2 = AskUserForNumber();

            result = Substract(num1, num2);
            Console.WriteLine($"The Result: {num1} - {num2} = " + result);
            break;
        case "*":
            num1 = AskUserForNumber();
            num2 = AskUserForNumber();

            result = Multiply(num1, num2);
            Console.WriteLine($"The Result: {num1} * {num2} =" + result);
            break;
        case "/":
            num1 = AskUserForNumber();
            num2 = AskUserForNumber();
            if (num2 != 0) //added if here to recogoniz the 0 input
            {
                result =Divide(num1, num2);
                Console.WriteLine($"The Result: {num1} / {num2}= " + result);
            }
            else Console.WriteLine("Can not be divided!");
            break;
        default:
            Console.WriteLine("That was not valid option");
            break;
    }
    Console.WriteLine("Should we continue!(Press Y for Yes and N for No): ");
} while (Console.ReadLine().ToUpper() == "Y"); // the check condition for the loop
Console.WriteLine("See You again!");
Console.ReadKey(); //to read the key press from the user

double AskUserForNumber()
{
    double num1;
    Console.WriteLine("Please Enter a number: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    return num1;
}
