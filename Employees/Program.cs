using System;
using Employees;


Console.WriteLine("***** The Employee Class Hierarchy *****\n");
SalesPerson fred = new SalesPerson
{
    Age = 31, Name = "Fred", SalesNumber = 50
};

Console.WriteLine(fred.Name, fred.Age, fred.SalesNumber);
Console.WriteLine(fred.Age);
Console.WriteLine(fred.SalesNumber);
