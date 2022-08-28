namespace Geometry.Test;

public class CubeTest
{
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [Theory]
    public void TestCube(double side)
    {
        var cube = new Cube(side);

        cube.Side.Should().Be(side);

        cube.FaceA.GetType().IsInstanceOfType(typeof(Square));
        cube.FaceB.GetType().IsInstanceOfType(typeof(Square));
        cube.FaceC.GetType().IsInstanceOfType(typeof(Square));

        cube.GetType().IsInstanceOfType(typeof(Parallelepiped));
    }
}