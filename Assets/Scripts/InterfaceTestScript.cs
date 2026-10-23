using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Creates one of each shape and prints its area and perimeter to the Console.
//
// SOLID principle: Dependency Inversion Principle (DIP).
// High-level code should depend on abstractions, not on concrete classes.
// Each shape is stored as an IShape, so this script only relies on the
// IShape contract and not on how each shape does its calculations.
public class InterfaceTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Create each shape and store it as an IShape (Dependency Inversion)
        IShape circle = new Circle();
        IShape trapezium = new Trapezium();
        IShape nonagon = new Nonagon();
       
        // Same two calls for every shape; each one runs its own formula
        circle.CalculateArea();
        circle.CalculatePerimeter();

        trapezium.CalculateArea();
        trapezium.CalculatePerimeter();

        nonagon.CalculateArea();
        nonagon.CalculatePerimeter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}




