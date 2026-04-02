using System;
using Btreaties.BusinessSuite.Pos;
using helloworld;
using static System.Console;
class AppShell
{
    static void Main(string[] args)
    {
        Console.WriteLine("Logical Operators!");

        int x = 10;
        int y = 2 * x++;
        int z = (++x) - 5 + y++;
        TypeCasting.StudentGradeCalculator();
        TypeCasting.RunTypeCastingDemo();
        Console.ReadLine();
    }

    static void StartCalculator()
    {
        PrintMenu();

        // Find x, y z ;
        Write("Please Enter Menu Option Number: ");
        var selectedMenu = ReadLine();

        if (selectedMenu == "1")
        {
            RunAdditionCalculator();
        }
    }

    private static void RunAdditionCalculator()
    {
        Clear();
        PrintMenu();
        ForegroundColor = ConsoleColor.Green;
        WriteLine(" 1) : Addition Calculator");
       ResetColor();
       
       
       //Parse : convert string content to numbers: fails if the parsed string is not a valid number
       // eg : var salary = decimal.Parse("50000"); = 50,000 
       // eg:  var vat = decimal.Parse("50a"); this throws an Exception and crashes the Program
       
       // TryParse : try to convert a string to number, if it succeeds, return TRUE and output the converted number to the variable assigned
       // in out parameter otherwise returns false for failed conversion
       Write("Enter First Number: ");  
       var isValidFirstNumber  = double.TryParse(ReadLine(), out double firstNumber);
       Write("Enter Second Number: ");
       var  isSecondNumberValid = double.TryParse( ReadLine(), out double secondNumber);

       if (isValidFirstNumber && isSecondNumberValid)
       {
           var sum = firstNumber + secondNumber;
           WriteLine($"{firstNumber} + {secondNumber} = {sum}");
       }
       else
       {
           WriteLine($"You entered an Invalid number, Please try again");
       }
       
    }
    static void PrintMenu()
    {
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine("Menu Options");
        ForegroundColor = ConsoleColor.Magenta;
        WriteLine("""
                    1) : Addition Calculator
                    2) : Subtraction Calculator
                    3) : Multiplication Calculator
                    4) : Division Calculator
                  """);
        WriteLine();
        ResetColor();
    }
}
