using System;
using Btreaties.BusinessSuite.Pos;

class AppShell
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        
        PosApplication app = new PosApplication();
        app.RenderPosMenus();
        
        CsharpTypes csTypes = new CsharpTypes();
        csTypes.ShowDataTypes();
        
        csTypes.IAgreeToTermsAndConditions();
        
        csTypes.AmAMan();
        
        csTypes.IDisagreeToTermsAndConditions();
        
        csTypes.AmAWoman();
        
        Console.ReadLine();
    }

}
