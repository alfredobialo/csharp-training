using System;
using Btreaties.BusinessSuite.Pos;
using helloworld;
using static System.Console;
class AppShell
{
    static void Main(string[] args)
    {
        Console.WriteLine("Logical Operators!");
        string data = "Elephant";  // a L f R e D
        //
        string result = "";
        int skipIndex = 0; 
        label:
        result += skipIndex % 2 > 0 ? data[skipIndex++].ToString().ToUpper() : data[skipIndex++].ToString().ToLower();
        if (skipIndex < data.Length)
        {
          goto label;  
        }
        
        
        Console.Write(result);
        ReadLine();
        
        int x = 10;
        int y = 2 * x++;
        int z = (++x) - 5 + y++;
        //TypeCasting.StudentGradeCalculator();
        //TypeCasting.RunTypeCastingDemo();
        long factorial = 1;
        Write("Enter a number to get Factorial : ");
        var isValidaNum = int.TryParse(ReadLine(), out int num);
        int num2 = num;
        if (isValidaNum && num > 0 && num <= 20)
        {
            factorial = num;  // 5
            runFactotial :
            factorial *= --num ;  // 5 * (4) * 3 * 2 *1
            if (num > 1)
            {
                goto runFactotial;
            }
            
            WriteLine($"Factorial is {factorial}");
            
            WriteLine($"Using Factorial Calculator : {Factorial(num2)}");
            WriteLine($"Using Factorial Loop : {FactorialN(num2)}");
        }
        else
        {
            WriteLine($"You entered an invalid number, Please try again");
        }
        
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

    static long Factorial(int n) => n <=1 ? 1 : n * Factorial(n - 1);

    static long FactorialN(int n)
    {
        long result = 1;
        for (int i = n; i >= 1 ; i--)
        {
            result *= i;
        }
        return result;
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
