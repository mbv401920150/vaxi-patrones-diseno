using System;
using Decorator.Common;

namespace Decorator.Birthday;

class BirthdayParty : AbstractParty
{
    protected override int EventNumber { get; } = 1;

    protected override void Implementation()
    {
        var cake = new Cake("Michael Party",
            new Size(
                188 * Length.Millimeter,
                300 * Length.Millimeter,
                40 * Length.Millimeter
            )
        );

        var buyer = new Buyer();
        buyer.Handler(cake);

        var employee = new Employee();
        employee.Handler(cake);
    }
}

