using System;
using Decorator.Common;

namespace Decorator.Birthday;

class Buyer
{
    public void Handler(Cake cake)
    {
        Size cakeSize = cake.Dimensions;
        Console.WriteLine($"Buying cake {cake.Name} with size {cakeSize}");
    }
}

