namespace PaintShop;

public class Room
{
    public Wall[] Walls { get; }
    public double TotalPaintableArea { get; set; } = 0;
    public Room(params Wall[] walls)
    {
        Walls = walls;
        foreach (Wall item in walls)
        {
            TotalPaintableArea += item.PaintableArea;
        }
    }
}