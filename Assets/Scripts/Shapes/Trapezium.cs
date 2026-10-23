using UnityEngine;


public class Trapezium : IShape
{
     int smallSide;
     int largeSide;
     int height;
    public void CalculateUnknownSides()
    {
        Debug.Log("Unknown sides(Trapezium) =  " + smallSide + largeSide + height);
    }

    public void CalculateArea()
    {
        Debug.Log("Area(Trapezium) =  " + (smallSide + largeSide) * height / 2);
    }

    public void CalculatePerimeter()
    {
        Debug.Log("Perimeter(Trapezium) =  " + smallSide + largeSide + height);
    }

    
}