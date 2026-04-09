using System;
using Btreaties.BusinessSuite.Pos;
using helloworld;
using static System.Console;
class AppShell
{
    static void Main(string[] args)
    {
        Clear();
        Write("Enter your Gender : ");
        string gender  =  ReadLine();

        var result = gender?.ToLower().Trim() switch
        {
            "male" => "Welcome Mr",
            "female" => "Welcome Miss",
            _ => "Hmmm! we can't identify your gender"
        };
        
        WriteLine(result);

        switch (gender?.ToLower().Trim())
        {
            case "male":
                WriteLine("Welcome Mr");
                break;
            case "female":
                WriteLine("Welcome Miss");
                break;
            default:
                WriteLine("Hmmm! we can't identify your gender");
                break;
        }
        Console.ReadLine();
    }
    

    
}
