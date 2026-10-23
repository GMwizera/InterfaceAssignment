using UnityEngine;

public class Nonagon : IShape
{
    int numberOfSides;
    float sideLength;

     public Nonagon(float sideLength, int numberOfSides)
    {
        this.sideLength = sideLength;
        this.numberOfSides = numberOfSides;
    }
    public void CalculateArea()
    {
        Debug.Log("Area (Nanogram) = " + )
        
    }

    public void CalculatePerimeter()
    {
        
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}