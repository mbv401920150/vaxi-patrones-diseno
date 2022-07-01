using System;
namespace Decorator.Common;

// Le da la responsabilidad que todas las clases que hereden de esta clase
// van a poder implementar la logica de implementacion
abstract class AbstractParty
{
    // Solo las clases que hereden de la clase AbstractParty
    // van a poder usar esta propiedad de solo lectura
    protected abstract int EventNumber { get; }

    protected abstract void Implementation();

    public void Run()
    {
        Console.WriteLine($"Event number: {EventNumber}");
        Implementation();
        Console.WriteLine(new string('-', 20));
        Console.WriteLine();
    }
}

