using System;
using RecordInheritance;

Console.WriteLine("Record type inheritance!");

Car c = new Car("Honda", "Pilot", "Blue");
MiniVan m = new MiniVan("Honda", "Pilot", "Blue", 10);

Console.WriteLine($"Checking MiniVan is-a Car: {m is Car}");
Console.ReadLine();


PositionalCar pc = new PositionalCar("Honda", "Pilot", "Blue");
PositionalMiniVan pm = new PositionalMiniVan("Honda", "Pilot", "Blue", 10);
Console.WriteLine($"Checking PositionalMiniVan is-а PositionalCar: { pm is PositionalCar}");
Console.ReadLine();


