// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
char[] OperatorTab = { '+', '-', '*', '/' };
Console.WriteLine("Please choose the operator: +,-,*,/");
char validOp = GetOperator();
Console.WriteLine($"Please insert first digit");
int firstDigit = GetDigit();

Console.WriteLine($"Please insert second digit");
int secondDigit = GetDigit();

DoCalculation(validOp, firstDigit, secondDigit);
char GetOperator()
{
    char op;
    op = Convert.ToChar(Console.ReadLine());

    for(var i = 0; i < OperatorTab.Length; i++)
    {
        if (OperatorTab[i] == op)
        {
            return op;
        }
    }
    Console.WriteLine("Please choose the operator: +,-,*,/");
    return GetOperator();
}
   int GetDigit()
{
    int digit;
    while (!int.TryParse(Console.ReadLine(), out digit))
    {
        Console.WriteLine($"Invalid input. Please enter a valid digit.");
    }
    return digit;
}
void PrintHint(decimal result)
{
    Console.WriteLine($"Result is: {result}");
}
void DoCalculation(char oper, int firstDigit, int secondDigit)
{
    decimal result = 0M;
    switch (oper)
    {
        case '+':
            result = firstDigit + secondDigit;
            break;
        case '-':
            result = firstDigit - secondDigit;

            break;
        case '/':
            try
            {
                result = (decimal)firstDigit / (decimal)secondDigit;
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                break;
            }
        case '*':
            result = firstDigit * secondDigit;
            break;
    }
    PrintHint(result);
}