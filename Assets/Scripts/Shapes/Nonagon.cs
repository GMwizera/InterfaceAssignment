using UnityEngine;

// A regular nonagon: 9 equal sides.
public class Nonagon : IShape
{
    // A nonagon always has 9 sides
    int numberOfSides = 9;
    int length = 4;

  
    // Area of a regular polygon = (sides * length * length) / (4 * tan(PI / sides))
    public void CalculateArea()
    {
        
        float area = numberOfSides * length * length / (4 * Mathf.Tan(Mathf.PI / numberOfSides));
        Debug.Log("Area (Nonagon) = " + area);
    }

    // Perimeter = number of sides * side length
    public void CalculatePerimeter()
    {
        Debug.Log("Perimeter (Nonagon) = " + CalculateNumberOfSides() * length);
    }

    // Returns how many sides the shape has (always 9)
    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}