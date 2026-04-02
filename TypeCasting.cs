namespace helloworld;

public class TypeCasting
{
    public static void RunTypeCastingDemo()
    { 
        WriteLine("Type Casting Demo");
        float abc = 40.788676f;
        float salary =  abc;
        long age = 20;
        int myNewAge = (int) age;
        WriteLine($"abc = {abc},  salary = {salary},   myNewAge = {myNewAge}");

        byte allowedFailedTries = 3;
        byte failureCount = 0;
        blessingAppStartPoint:
        WriteLine("Think of a Number:");
        
        var isValidNumber = int.TryParse(ReadLine(), out  int myNum);
        
        if (isValidNumber)
        {
            Write("Your number: ");
            ForegroundColor = ConsoleColor.Green;
            Write( myNum); 
            ResetColor();
        }
        else
        {
            failureCount++;
            if (failureCount >= allowedFailedTries)
            {
                ForegroundColor=ConsoleColor.Yellow;
                Write($"You've retried {allowedFailedTries} times, ");
                ForegroundColor=ConsoleColor.Cyan;
                Write("what's wrong with you? can't you enter simple numeric value?");
                ResetColor();
                return;
            }
            ForegroundColor=ConsoleColor.Red;
            WriteLine("Hey! you entered an invalid number. Please try again");
            ResetColor(); 
            goto blessingAppStartPoint;
        }
        // TryParse 
       
    }

    public static void StudentGradeCalculator()
    {
        WriteLine("Student Grade Calculator");
        
        WriteLine("Enter Student Score : ");
        double score = double.Parse(ReadLine());

        string grade = "F";
        string g = score >= 80 ? "A" : 
            (score >= 70  && score <= 79 ) ? "AB" :
            (score >= 60  && score <= 69) ? "B" :
            (score >= 50  && score <= 59) ? "C" :
            (score >= 40  && score <= 49) ? "CD" :
            (score >= 35  && score <= 39) ? "D" :
            (score >= 30  && score <= 34) ? "E" : "F"
            ;
        if (score >= 80)
        {
            grade = "A";
        }
       
        else if (score >= 70  && score <= 79)
        {
            grade = "AB";
        }
        else if (score >= 60  && score <= 69)
        {
            grade = "B";
        }
        else if (score >= 50  && score <= 59)
        {
            grade = "C";
        }
        else if (score >= 40  && score <= 49)
        {
            grade = "CD";
        }
        else if (score >= 35  && score <= 39)
        {
            grade = "D";
        }
        else if (score >= 30  && score <= 34)
        {
            grade = "E";
        }
        
        Console.WriteLine($"The grade with if statement {grade} for {score}");
        Console.WriteLine($"The grade with ternary operator is {g} for {score}");
        
    }
}
