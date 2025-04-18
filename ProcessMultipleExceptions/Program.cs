using System;
using System.IO;
using ProcessMultipleExceptions;

Console.WriteLine("***** Handling Multiple Exceptions *****\n");
Car myCar = new Car("Rusty", 100);
myCar.Accelerate(100);


/*
try
{
    myCar.Accelerate(10);
}
catch (CarIsDeadException e)
when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
{
    Console.WriteLine("Catching car is dead!");
    Console.WriteLine(e.Message);
    /*
    try
    {
        FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
    }
    catch (Exception e2)
    {
        throw new CarIsDeadException(e.CauseOfError, e.ErrorTimeStamp, e.Message, e2);
    }
    
    //throw;
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
/*
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

catch
{
    Console.WriteLine("Something bad happened...");
}
finally
{
    myCar.CrankTunes(false);
}
Console.ReadLine();
*/