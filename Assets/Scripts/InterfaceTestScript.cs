using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InterfaceTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IShape circle = new Circle();
        IShape trapezium = new Trapezium();
        IShape nonagon = new Nonagon();
       
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




