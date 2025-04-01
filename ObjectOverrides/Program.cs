using System;
using ObjectOverrides;


Console.WriteLine("***** Fun with System.Object *****\n");
Person p1 = new Person("Vladislav", "Chudaev", 26, "");

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
Console.ReadLine();


Person p3 = new Person("Homer", "Simpson", 50, "111-11-1111");
Person p4 = new Person("Homer", "Simpson", 50, "111-11-1111");

Console.WriteLine($"p3.ToString() = {p3.ToString()}");
Console.WriteLine($"p4.ToString() = {p4.ToString()}");

Console.WriteLine($"p3 = p4?: {p3.Equals(p4)}");

Console.WriteLine($"Same hash codes?: {p3.GetHashCode() == p4.GetHashCode()}");
Console.WriteLine();

p4.Age = 45;

Console.WriteLine($"p3.ToString() = {p3.ToString()}");
Console.WriteLine($"p4.ToString() = {p4.ToString()}");

Console.WriteLine($"p3 = p4?: {p3.Equals(p4)}");

Console.WriteLine($"Same hash codes?: {p3.GetHashCode() == p4.GetHashCode()}");
Console.ReadLine();