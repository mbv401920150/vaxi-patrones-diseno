using System;
using Decorator.Common;

namespace Decorator.Birthday;

class WrappedCake : Cake
{
    public WrappedCake(Cake cake) : base(cake)
    { }

    public override Size GetDimensions(Length propagandaHeight) =>
        base.GetDimensions(propagandaHeight)
            .Add(new Size(
                    7 * Length.Millimeter,
                    7 * Length.Millimeter,
                    7 * Length.Millimeter
                )
            );
}

