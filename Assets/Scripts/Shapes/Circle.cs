using UnityEngine;


public class Circle : IShape
{
    int diameter = 10;
    public void CalculateArea()
    {
        float radius = CalculateRadius();
        Debug.Log("Area (Circle) = " + Mathf.PI * radius * radius);
    }

    public float CalculateRadius()
    {
       return diameter / 2;
    }

    public void CalculatePerimeter()
    {
       float radius = CalculateRadius();
        Debug.Log("Perimeter (Circle) = " + 2f * Mathf.PI * radius);
        
    }
}