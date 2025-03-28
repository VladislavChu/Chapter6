using System;
using ObjectOverrides;


Console.WriteLine("***** Fun with System.Object *****\n");
Person p1 = new Person("Vladislav", "Chudaev", 26);

Console.WriteLine($"ToString: {p1.ToString()}");
Console.WriteLine($"ToString: {p1.GetHashCode()}");
Console.WriteLine($"ToString: {p1.GetType()}");
//Console.WriteLine($"ToString: {p1.ToString()}");

Person p2 = p1;
object o = p2;

if (o.Equals(p1) && p2.Equals(o))
{
    Console.WriteLine("Same instance!");
}
Console.WriteLine();