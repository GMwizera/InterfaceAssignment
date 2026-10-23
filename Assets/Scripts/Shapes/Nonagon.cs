using UnityEngine;

public class Nonagon : IShape
{
    int numberOfSides = 9;
    int length = 4;

  
    public void CalculateArea()
    {
        
        float area = numberOfSides * length * length / (4 * Mathf.Tan(Mathf.PI / numberOfSides));
        Debug.Log("Area (Nanogram) = " + area);
    }

    public void CalculatePerimeter()
    {
        Debug.Log("Perimeter (Nanogram) = " + CalculateNumberOfSides() * length);
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}