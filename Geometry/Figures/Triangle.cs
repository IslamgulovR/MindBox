using Geometry.Interfaces;

namespace Geometry.Figures;

public class Triangle : IShape
{
    private double SideA { get; set; }

    private double SideB { get; set; }

    private double SideC { get; set; }

    public Triangle(double a, double b, double c)
    {
        if (a + b <= c || b + c <= a || a + c <= b)
            throw new ArgumentException("Triangle does not exist. Sum of any two sides must be greater than third.");
        
        SideA = a;
        SideB = b;
        SideC = c;
    }
    
    public double CalculateSquare()
    {
        var halfPerimeter = (SideA + SideB + SideC) / 2.0;

        return Math.Sqrt(halfPerimeter *
                         (halfPerimeter - SideA) *
                         (halfPerimeter - SideB) *
                         (halfPerimeter - SideC));
    }

    public bool IsRectangular()
    {
        var sidesList = new List<double>
        {
            SideA, SideB, SideC
        };
        
        sidesList.Sort();
        sidesList.Reverse();
        
        return Math.Pow(sidesList[0], 2) == Math.Pow(sidesList[1], 2) + Math.Pow(sidesList[2], 2);
    }
}