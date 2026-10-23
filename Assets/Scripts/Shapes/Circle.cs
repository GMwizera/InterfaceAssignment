using UnityEngine;

public class Circle : IShape
{
    // Fixed test value
    int diameter = 10;

    // Area = PI * radius * radius
    public void CalculateArea()
    {
        float radius = CalculateRadius();
        Debug.Log("Area (Circle) = " + Mathf.PI * radius * radius);
    }

    // The radius is half the diameter
    public float CalculateRadius()
    {
       return diameter / 2;
    }

    // Perimeter (circumference) = 2 * PI * radius
    public void CalculatePerimeter()
    {
       float radius = CalculateRadius();
        Debug.Log("Perimeter (Circle) = " + 2f * Mathf.PI * radius);
        
    }
}