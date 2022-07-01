using System;
using Decorator.Common;

namespace Decorator.Birthday;

class Cake
{
    public string Name { get; }

    private readonly Size _dimensions;

    // El atributo virtual permite que sea reescrito (Override) en el hijo
    public virtual Size Dimensions => _dimensions;

    public Cake(string name, Size dimensions)
    {
        Name = name;
        _dimensions = dimensions;
    }

    public Cake(Cake cake) : this(cake.Name, cake.Dimensions)
    { }

    public virtual Size GetDimensions(Length propagandaHeight) =>
        _dimensions.AddToTop(propagandaHeight);
        
    public override string ToString() => $"{Name} - {Dimensions}";
}

