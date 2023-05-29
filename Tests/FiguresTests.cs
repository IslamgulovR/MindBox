using Geometry.Figures;

namespace TestProject1;

public class FiguresTests
{
    [Theory]
    [InlineData(5, 78.54)]
    [InlineData(15.5, 754.77)]
    public void CircleSquare(double r, double s)
    {
        var circle = new Circle(r);
        
        var round = Math.Round(circle.CalculateSquare(), 2);

        Assert.Equal(s, round);
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(35, 35, 35, 530.44)]
    public void TriangleSquare(double a, double b, double c, double s)
    {
        var triangle = new Triangle(a, b, c);

        var roundedSquare = Math.Round(triangle.CalculateSquare(), 2);
        
        Assert.Equal(s, roundedSquare);
    }

    [Theory]
    [InlineData(-5)]
    [InlineData(0)]
    public void CircleDoesNotExit(double r)
    {
        Assert.Throws<ArgumentException>(() => new Circle(r));
    }
    
    [Theory]
    [InlineData(3, 3, 0)]
    [InlineData(-5, -3, 2)]
    public void TriangleDoesNotExist(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(3, 3, 3, false)]
    public void TriangleIsRectangular(double a, double b, double c, bool isRectangular)
    {
        var triangle = new Triangle(a, b, c);
        
        Assert.Equal(isRectangular, triangle.IsRectangular());
    }
}