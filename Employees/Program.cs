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

    Employee hex = new AnotherType();

    Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);

    SalesPerson jill = new PtSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);

    GivePromotion(jill);
    GivePromotion((Manager)frank);
    GivePromotion(hex);
}

static void GivePromotion(Employee emp)
{
    Console.WriteLine($"{emp.Name} was promoted!");

    if (emp is SalesPerson s)
    {
        Console.WriteLine($"{s.Name} made {s.SalesNumber} sale(s)!");
        Console.WriteLine();
    }
    else if (emp is Manager m)
    {
        Console.WriteLine($"{m.Name} had {m.StockOptions} stock options...");
        Console.WriteLine();
    }
    else if (emp is var _)
    {
        Console.WriteLine($"Unable to promote {emp.Name}. Wrong employee type");
        Console.WriteLine();
    }
}

object frank = new Manager();
Hexagon hex;

try 
{
    hex = (Hexagon)frank;
}
catch (InvalidCastException ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadLine();

object[] things = new object[4];
things[0] = new Hexagon();
things[1] = false;
things[2] = new Manager();
things[3] = "Last thing";

foreach (object item in things)
{
    Hexagon h = item as Hexagon;
    if (h == null)
    {
        Console.WriteLine("Item is not a hexagon");
    }
    else
    {
        h.Draw();
    }
}




class Hexagon
{
    public void Draw()
    {
        Console.WriteLine("Drawing a hexagon!");
    }
}

