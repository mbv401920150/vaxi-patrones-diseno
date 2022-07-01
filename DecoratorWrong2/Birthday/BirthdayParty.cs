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

        var buyer = new CakeHandler();
        buyer.Handler(cake);

        var wrappedCake = new WrappedCake(cake);

        var employee = new CakeHandler();
        employee.Handler(wrappedCake);

        Console.WriteLine($"\r\n{new string('-', 20)}\r\n");

        var cakePack = new CakePack(cake);

        var buyer2 = new CakeHandler();

        buyer2.Handler(cakePack);

        var wrappedCakePack = new WrappedCake(cakePack);
        var employee2 = new CakeHandler();

        employee2.Handler(wrappedCakePack);
    }
}

