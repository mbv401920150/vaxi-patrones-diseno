using System;
using Decorator.Common;

namespace Decorator.Birthday;

class CakeHandler
{
    public void Handler(Cake cake)
    {
        var propagandaHeigth = 5 * Length.Millimeter;
        Size cakeSize = cake.GetDimensions(propagandaHeigth);

        Console.WriteLine($"Working on {cake.GetType().Name} size {cakeSize}");
    }
}

