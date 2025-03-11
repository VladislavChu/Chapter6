using System;
using Employees;


Console.WriteLine("***** The Employee Class Hierarchy *****\n");

Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
double cost = chucky.GetBenefitCost();
Console.WriteLine($"Benefit Cost: {cost}");
Console.ReadLine();

SalesPerson fred = new SalesPerson
{
    Age = 31,
    Name = "Fred",
    SalesNumber = 50
};

Console.WriteLine(fred.Name, fred.Age, fred.SalesNumber);
Console.WriteLine(fred.Age);
Console.WriteLine(fred.SalesNumber);
