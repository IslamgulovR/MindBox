using Geometry.Interfaces;

namespace Geometry.Figures;

public class Circle : IShape
{
    private double Radius { get; set; }

    public Circle(double r)
    {
        if (r <= 0)
            throw new ArgumentException("Radius must be greater than 0.");
        
        Radius = r;
    }

    public double CalculateSquare()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}