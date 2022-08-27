namespace Geometry.Test;

public class ParallelepipedTest
{
    [InlineData(2, 3, 4)]
    [InlineData(3, 4, 5)]
    [Theory]
    public void TestParallelepiped(double height, double width, double depth)
    {
        var parallelepiped = new Parallelepiped(width, height, depth);

        parallelepiped.Width.Should().Be(width);
        parallelepiped.Height.Should().Be(height);
        parallelepiped.Depth.Should().Be(depth);

        parallelepiped.FaceA.GetType().IsInstanceOfType(typeof(Rectangle));
        parallelepiped.FaceB.GetType().IsInstanceOfType(typeof(Rectangle));
        parallelepiped.FaceC.GetType().IsInstanceOfType(typeof(Rectangle));

        parallelepiped.Volume.Should().Be(width * height * depth);

        double result = ((width * height) + (width * depth) + (height * depth)) * 2;

        parallelepiped.SurfaceArea.Should().Be(result);
    }
}