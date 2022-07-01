using System;
using Decorator.Common;

namespace Decorator.Birthday;

class Cake
{
    public string Name { get; }
    public Size Dimensions { get; }

    public Cake(string name, Size dimensions)
    {
        Name = name;
        Dimensions = dimensions;
    }

    public override string ToString() => $"{Name} - {Dimensions}";
}

