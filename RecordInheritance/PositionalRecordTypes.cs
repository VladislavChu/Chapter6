﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordInheritance
{
    public record PositionalCar (string Make, string Model, string Color);
    public record PositionalMiniVan (string Make, string Model, string Color, int Seating) : PositionalCar (Make, Model, Color);
}
