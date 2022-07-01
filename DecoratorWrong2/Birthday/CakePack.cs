using System;
using Decorator.Common;

namespace Decorator.Birthday;

class CakePack : Cake
{
    public CakePack(Cake cake) : base(cake)
    {

    }

    public override Size GetDimensions(Length propagandaHeight) =>
        base.GetDimensions(Length.Zero)
            .ScaleHeight(2)
            .AddToTop(propagandaHeight);
}

