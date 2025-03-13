using System;
using Employees;



Console.WriteLine("***** The Employee Class Hierarchy *****\n");

Manager chuck = new Manager("Chuck", 50, 92, 100000f, "333-23-2322", 9000);
double cost = chuck.GetBenefitCost();
Console.WriteLine($"Benefit Cost: {cost}");
Console.ReadLine();


Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
chucky.GiveBonus(300);
chucky.DisplayStatus();
Console.ReadLine();

SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
fran.GiveBonus(200);
fran.DisplayStatus();
Console.ReadLine();


    

