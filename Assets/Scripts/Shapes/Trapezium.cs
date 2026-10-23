using UnityEngine;


public class Trapezium : IShape
{
     int smallSide = 4;
     int largeSide = 10 ;
    int height = 4;
    int slantedSide = 5;
    public int CalculateUnknownSides()
    {
        return slantedSide;
    }

    public void CalculateArea()
    {
        Debug.Log("Area (Trapezium) = " + (smallSide + largeSide) * height / 2);
    }

    public void CalculatePerimeter()
    {
        int perimeter = smallSide + largeSide + slantedSide + CalculateUnknownSides();
        Debug.Log("Perimeter (Trapezium) = " + perimeter);
    }

}