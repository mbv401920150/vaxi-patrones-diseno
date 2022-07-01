# Patrones de diseño

## Patron decorator
Este patron pretende agregar funcionalidades o Features a una clase. Extendiendole la funcionalidad.

Es util para poder tener una clase basica, y agregarle funcionalidades nuevas especificas dentro de
otra clase.

### Cosas a tomar en cuenta
- Nunca heredes desde un Decorator.
Esto causa problemas cuando se usa varios decoradores de forma consecutiva.
Ya que se hara referencia siempre a la clase base.

### Summary
- El decorador envuelve un objeto
- Expone la misma interface
- Un decorador puede sustituir un objeto decorado
- Es un diseño permitido por el principio de sustitucion
- Un decorador puede agregar comportamientos
- Un decorador simplifica el consumer
- Se puede derivar de la clase decorador y tambien puede implementar la misma interface
- La herencia o subclases pueden causar problemas
Lo ideal es implementar la misma interface en ambas clases