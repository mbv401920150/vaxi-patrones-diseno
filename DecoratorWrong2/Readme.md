# Problema
El codigo actual tiene problemas porque la clase base `Cake` tiene 2 decoradores.
- El `WrappedCake`
- Y el `CakePack`

Cuando se usa el `CakePack` dentro de `WrappedCake`, la segunda clase decoradora usa
la clase base `Cake`, en lugar de `CakePack`.

Ejemplo
``` CSharp
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
```

Teniendo como resultado:
```
Event number: 1
Working on Cake size 18.8 x 30 x 4.5 cm
Working on WrappedCake size 19.5 x 30.7 x 5.2 cm

--------------------

Working on CakePack size 18.8 x 30 x 8.5 cm
Working on WrappedCake size 19.5 x 30.7 x 5.2 cm
--------------------
```