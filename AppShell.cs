using System;
using Btreaties.BusinessSuite.Pos;

class AppShell
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        
        /*PosApplication app = new PosApplication();
        app.RenderPosMenus();
        
        CsharpTypes csTypes = new CsharpTypes();
        csTypes.ShowDataTypes();
        
        csTypes.IAgreeToTermsAndConditions();
        
        csTypes.AmAMan();
        
        csTypes.IDisagreeToTermsAndConditions();
        
        csTypes.AmAWoman();*/

        // Signed Integers  : -57 to 100
        byte myAge = 60; 
        short myAge2 = 10;
        sbyte mmms = -60;
        long myAge4 = 10;

        
        int anything = 90;
        Int32 myNewInt = 90;
        Int16 myNewIntd = 90;
        Int64 myNewLong = 90;

        uint nn = 80;
        ulong nn2 = 80;
        ushort nn3 = 67;
        byte myAge3 = 100; //  0 - 255 = (2^8)-1

        UInt16 unii = 8;

        Int128 veryLongVariable = 0;

        int hh = 90;
        hh = 5000;
        double accBal = 890_000.00;
        float pi = 3.142f;
        
        byte mms11 = 89;
        long ray = 50_000_000;
        long ree = ray-100_000;
        
        // Object Oriented Programming Language ( OOP )
        // Inherit from System.Object 
        string empEmail = CompanyEmployeeEmailAddressGenerator.GenerateEmployeeEmailAddress("Alfred","Obialo");
        
        Console.WriteLine("Employee Email for Alfred Obialo : " + empEmail );
        
        Console.ReadLine();
    }

}
