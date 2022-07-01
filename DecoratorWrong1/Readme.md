# Problema
Esta solucion utiliza dos clases, `Buyer` y `Employee`.

Pero estas dos clases usan la misma clase de `Cake` para representar un pastel.

La diferencia es que el `Buyer` obtiene el tamaño del pastel unicamente.

Y la clase `Employee` agrega un poco mas de tamaño para incluir la caja.

Dicho esto, el problema esta en que se usa dos clases, unicamente con la
diferencia de mostrar dos tamaños diferentes.

# Patron de diseño
Para solucionar esto se puede usar el patron de diseño `Decorator`.

Para poder implementar nuevas caracteristicas o Features a la clase base (`Cake`).


Regularmente se usa una clase `Wrapped` para incluir nuevas caracteristicas.
