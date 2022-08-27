namespace Geometry;
public class Rectangle
{
    public double Width;
    public double Height;
    public double Area
    {
        get { return Width * Height; }
    }
    public double Perimeter
    {
        get { return (Width + Height) * 2; }
    }

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("All sides must be greater than zero");
        
        Width = width;
        Height = height;
    }
}