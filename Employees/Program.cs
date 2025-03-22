using System;
using Employees;



Console.WriteLine("***** The Employee Class Hierarchy *****\n");

CastingExamples();

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

/*
Employee emp = new Manager();
Console.WriteLine(emp);
*/

static void CastingExamples()
{
    object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);

    Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);

    SalesPerson jill = new PtSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);

    GivePromotion(jill);
    GivePromotion((Manager)frank);
}

static void GivePromotion(Employee emp)
{
    Console.WriteLine($"{emp.Name} was promoted!");
}
    

