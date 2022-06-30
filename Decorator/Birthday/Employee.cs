using System;
using Decorator.Common;

namespace Decorator.Birthday;

class Employee
{
    public void Handler(Cake cake)
    {
        Size originalSize = cake.Dimensions;

        Size packageSize = originalSize.Add(new Size(
            7 * Length.Millimeter,
            7 * Length.Millimeter,
            7 * Length.Millimeter
        ));

        Console.WriteLine($"Selling cake with package {cake.Name} size {packageSize}");
    }
}

