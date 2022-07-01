using System;
using Decorator.Common;

namespace Decorator.Birthday;

class CakePack : CakeDecorator
{
    public CakePack(ICake cake) : base(cake)
    {

    }

    public override Size GetDimensions(Length propagandaHeight) =>
        base.GetDimensions(Length.Zero)
            .ScaleHeight(2)
            .AddToTop(propagandaHeight);
}

