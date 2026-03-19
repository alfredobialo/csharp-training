namespace Btreaties.BusinessSuite.Pos;

public class CsharpTypes
{
    bool agreeToTermsAndConditions = false;
    bool isMale = true;
    private bool isCrazy = false;

    public void ShowDataTypes()
    {
        // Booleans false ||  false =  false
        isCrazy = agreeToTermsAndConditions == true || isMale == false;

        Console.WriteLine("Is Crazy :  " + isCrazy);
        Console.WriteLine("Is Male :  " + isMale);
        Console.WriteLine("I Agree to terms and Condition :  " + agreeToTermsAndConditions);
    }

    public void IAgreeToTermsAndConditions()
    {
        agreeToTermsAndConditions = true;
        Console.ForegroundColor = ConsoleColor.Green;
        ShowDataTypes();
        Console.ResetColor();
    }

    public void IDisagreeToTermsAndConditions()
    {
        agreeToTermsAndConditions = false;
        Console.ForegroundColor = ConsoleColor.Yellow;
        ShowDataTypes();
        Console.ResetColor();
    }

    public void AmAWoman()
    {
        isMale = false;
        ShowDataTypes();
    }

    public void AmAMan()
    {
        isMale = true;
        ShowDataTypes();
    }
}
