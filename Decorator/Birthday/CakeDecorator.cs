using System;
using Decorator.Common;

namespace Decorator.Birthday;

abstract class CakeDecorator : ICake
{
    private readonly ICake _cake;
    public CakeDecorator(ICake cake)
    {
        _cake = cake;
    }

    public virtual string Name => _cake.Name;

    public virtual Size GetDimensions(Length propagandaHeight) =>
        _cake.GetDimensions(propagandaHeight);
}

