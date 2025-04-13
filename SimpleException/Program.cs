using System;
using System.Collections;
using SimpleException;

Console.WriteLine("***** Fun with simple exception example *****");
Console.WriteLine("=> Creating a car and stepping on it!");

Car myCar = new Car("Zippy", 20);
myCar.CrankTunes(true);

try
{
    for (int i = 0; i < 10; i++)
    {
        myCar.Accelerate(10);
    }
} 
catch (Exception e)
{
    Console.WriteLine("\n*** Error! ***");
    Console.WriteLine($"Method: {e.TargetSite}");
    Console.WriteLine($"Class defining member: {e.TargetSite.DeclaringType}");
    Console.WriteLine($"Member type: {e.TargetSite.MemberType}");
    Console.WriteLine($"Message: {e.Message}");
    Console.WriteLine($"Source: {e.Source}");
    Console.WriteLine($"Stack: {e.StackTrace}");
    Console.WriteLine($"Help Link: {e.HelpLink}");
    Console.WriteLine("\n-> Custom Data:");
    foreach (DictionaryEntry de in e.Data)
    {
        Console.WriteLine($"-> {de.Key} : {de.Value}");
    }
}

Console.WriteLine("\n***** Out of exception logic *****");
Console.ReadLine();