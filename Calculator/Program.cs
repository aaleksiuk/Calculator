// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Please choose the operator: +,-,*,/");
char oper = GetOperator();
var firstDigitText = "first digit";
var secondDigitText = "second digit";
Console.WriteLine($"Please insert {firstDigitText}");
double firstDigit = GetDigit();
Console.WriteLine($"Please insert {secondDigitText}");
double secondDigit = GetDigit();
double WYNIK;
WYNIK = Operation(oper, firstDigit, secondDigit);


Console.WriteLine($"Result is: {WYNIK}");

double GetDigit()
{
    double digit;
    while (!double.TryParse(Console.ReadLine(), out digit))
    {
        Console.WriteLine($"Invalid input. Please enter a valid digit.");
    }
    return digit;
}

char GetOperator()
{
    char op;
    while (!char.TryParse(Console.ReadLine(), out op))
    {
        Console.WriteLine($"Invalid input. Please enter a valid operator: +,-,*,/.");
    }
    return op;
}
double Operation(char oper, double firstDigit, double secondDigit)
{
    double result;
    switch (oper)
    {
        case '+':
            result = firstDigit + secondDigit;
            Console.WriteLine($"Result is: {result}");
            break;

        case '-':
            result = firstDigit - secondDigit;
            Console.WriteLine($"Result is: {result}");
            break;

        case '/':
            result = firstDigit / secondDigit;
            Console.WriteLine($"Result is: {result}");
            break;

        case '*':
            result = firstDigit * secondDigit;
            break;

        default:
            Console.WriteLine($"Insert correct operator +,-,*,/.");
            break;
    }
    return result;
}