using UnityEngine;


public class Circle : IShape
{
    int diameter;
    public void CalculateArea()
    {
        float radius = CalculateRadius();
        Debug.Log("Areaa (Circle) = " + Mathf.PI * radius * radius);
    }

    public float CalculateRadius()
    {
       return diameter / 2;
    }

    public void CalculatePerimeter()
    {
       float radius = CalculateRadius();
        Debug.Log("Perimeter (Circle) = " + 2f * Mathf.PI * CalculateRadius());
        
    }
}