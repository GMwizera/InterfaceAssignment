# Interface Assignment (Unity)

A Unity project that uses a C# interface, `IShape`, to calculate the area and perimeter of three shapes: a trapezium, a circle and a nonagon.

## How to run

1. Open the project in Unity 6000.5.10f1.
2. Open `Assets/Scenes/SampleScene`.
3. Press Play and open the Console. Each shape prints its area and perimeter.

## Scripts

- `Assets/Scripts/Interfaces/IShape.cs`: the interface. It declares `CalculateArea()` and `CalculatePerimeter()`, the two methods every shape shares.
- `Assets/Scripts/Shapes/`: `Trapezium`, `Circle` and `Nonagon` each implement `IShape` with their own formulas, using fixed test values.
- `Assets/Scripts/InterfaceTestScript.cs`: attached to the `MyShape` object in the scene. Its `Start()` creates each shape and calls its methods.

## SOLID principle: Dependency Inversion

Each shape is created and stored as an `IShape`, for example `IShape circle = new Circle();`. The test script depends on the interface, not on the concrete classes, so it doesn't need to know how each shape does its calculations.
