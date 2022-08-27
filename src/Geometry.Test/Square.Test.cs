namespace Geometry.Test;

public class SquareTest
{
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [Theory]
    public void TestSquare(double side)
    {
        var square = new Square(side);
        square.GetType().IsInstanceOfType(typeof(Rectangle));
    }
}