using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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




