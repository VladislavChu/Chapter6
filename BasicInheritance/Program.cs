using System;
using BasicInheritance;


Console.WriteLine("***** Basic Inheritance *****\n");
Car myCar = new Car(80) { Speed = 50 };
Console.WriteLine($"My car is going {myCar.Speed} MPH");
Console.ReadLine();

MiniVan myVan = new MiniVan { Speed = 10 };
Console.WriteLine($"My van is going {myVan.Speed} MPH");
Console.ReadLine();