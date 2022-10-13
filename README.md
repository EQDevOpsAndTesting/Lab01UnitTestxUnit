# Laboratorio No.1 de Test Unitarios

## Frameworks
* xUnit
* .NET 6.0

## Lenguaje de Programación & IDE

* C# .Net
* Visual Studio 2022

## Técnicas de Código Limpio
* Organización de la solución, proyectos, carpetas y clases.
* Comentarios y documentación en formato XML
* Programación Orientada a Abstracciones (Interface-Oriented Programming (IOP))
* Ley de Deméter
* Objetos inmutables y estructuras de datos
* Resharper

## Principios SOLID
* Single Responsibility Principle (SRP)
* Inyección de dependencias (Dependency Injection (DI)) y Inversión de Control (Inversion of Control (IoC))

## Otros Principios
* DRY

## Análisis de Código Estático
* Sonarqube

## TEMA

### Test Unitarios

 > La ¡dea es que vamos a partir de un escenario conocido, vamos a ejecutar nuestro código, y vamos a comprobar que hemos terminado en el escenario esperado. Esto, se consigue con 3 pasos claramente diferenciados que llamamos **triple A ("AAA")** por sus siglas en Inglés:
 
1. **Arrange (Aprovisiona/Organiza)**: en esta etapa crearemos el escenario para nuestra prueba.
2. **Act (Actúa)**: en esta etapa ejecutaremos el código que queremos probar con los datos del escenario que hemos creado anteriormente.
3. **Assert (Afirma)**: en esta última etapa vamos a comprobar que los resultados que hemos obtenido de la etapa anterior son exactamente los esperados.

_Nota: Los test muestran la presencia de errores, pero no su ausencia - Edsger Dijkstra_

### xUnit
Una vez que tenemos nuestro proyecto de librería, debemos añadir los siguientes paquetes:

* xunit: nos va a dar todas las clases necesarias para poder crear nuestras pruebas de código.
* xunit.runner.console: va a servir para ejecutar las pruebas desde consola.
* xunit.runner.visualstudio: será el encargado de añadirtoda la funcionalidad necesaria para integrar perfectamente las pruebas de xUnit con Visual Studio.

#### Atributo [FACT]

El atributo [Fact] es empleado para hacer pruebas con datos únicos ("Hechos"), para crear pruebas con conjuntos de datos que se ejecutarán automáticamente con cada dato del conjunto se emplea el atributo [Theory] ("Teorías").