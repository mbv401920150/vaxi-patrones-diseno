using System;
using Decorator.Common;

namespace Decorator.Birthday;

class WrappedCake : CakeDecorator
{
    public WrappedCake(ICake cake) : base(cake)
    {
    }

    public override Size GetDimensions(Length propagandaHeight) =>
        base.GetDimensions(propagandaHeight)
            .Add(new Size(
                    7 * Length.Millimeter,
                    7 * Length.Millimeter,
                    7 * Length.Millimeter
                )
            );
}

