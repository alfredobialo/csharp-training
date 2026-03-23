namespace Btreaties.BusinessSuite.Pos;

public class CompanyEmployeeEmailAddressGenerator
{
    static string cmpDomain = "btreaties.com";
    public static string GenerateEmployeeEmailAddress(string firstName, string lastName)
    {
        string email = firstName.ToLower() + "." +lastName.ToLower()+"@"+cmpDomain;
        string emailTemp = $"{firstName.ToLower()}.{lastName.ToLower()}@{cmpDomain}";
        return emailTemp;
    }
}
