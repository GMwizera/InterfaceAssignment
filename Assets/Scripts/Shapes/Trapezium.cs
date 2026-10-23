using UnityEngine;

public class Trapezium : IShape
{
     int smallSide = 4;
     int largeSide = 10 ;
    int height = 4;
    int slantedSide = 5;

    // Both slanted sides are equal, so the unknown side matches the known one.
    public int CalculateUnknownSides()
    {
        return slantedSide;
    }

    // Area = (smallSide + largeSide) * height / 2
    public void CalculateArea()
    {
        Debug.Log("Area (Trapezium) = " + (smallSide + largeSide) * height / 2);
    }

    // Perimeter = all four sides added together
    public void CalculatePerimeter()
    {
        int perimeter = smallSide + largeSide + slantedSide + CalculateUnknownSides();
        Debug.Log("Perimeter (Trapezium) = " + perimeter);
    }

}