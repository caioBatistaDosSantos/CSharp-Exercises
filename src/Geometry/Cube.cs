namespace Geometry;
public class Cube : Parallelepiped
{
    public double Side;

    public Cube(double side) : base(side, side, side)
    {
        Side = side;
    }
    new public Square FaceA
    {
        get { return new Square(Side); }
    }
    new public Square FaceB
    {
        get { return new Square(Side); }
    }
    new public Square FaceC
    {
        get { return new Square(Side); }
    }
}