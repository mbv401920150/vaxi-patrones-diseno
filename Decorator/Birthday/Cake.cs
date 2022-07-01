using Decorator.Common;

namespace Decorator.Birthday;

class Cake : ICake
{
    public string Name { get; }
    public Size Dimensions { get; }

    public Cake(string name, Size dimensions)
    {
        Name = name;
        Dimensions = dimensions;
    }

    public Size GetDimensions(Length PropagandaHeight) =>
        Dimensions.AddToTop(PropagandaHeight);

    public override string ToString() => $"{Name} - {Dimensions}";
}

