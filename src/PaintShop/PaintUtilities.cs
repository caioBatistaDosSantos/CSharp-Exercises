namespace PaintShop.Test;

public static class PaintUtilities
{
    public static int BucketSizeLiters { get; set; } = 20;
    public static int SquareMetersPerLiter { get; set; } = 10;
    public static int SquareMetersPerBucket
    {
        get { return BucketSizeLiters * SquareMetersPerLiter; }
    }

    public static int GetNeededPaintBuckets(double area)
    {
        double result = Math.Ceiling(area / SquareMetersPerBucket);
        return Convert.ToInt32(result);
    }
    public static int GetNeededPaintBuckets(Wall wall)
    {
        double result = Math.Ceiling(wall.PaintableArea / SquareMetersPerBucket);
        return Convert.ToInt32(result);
    }
    public static int GetNeededPaintBuckets(Room room)
    {
        double result = Math.Ceiling(room.TotalPaintableArea / SquareMetersPerBucket);
        return Convert.ToInt32(result);
    }

    public static decimal CalculateCost(decimal price, double area)
    {
        return Convert.ToDecimal(GetNeededPaintBuckets(area)) * price;
    }
    public static decimal CalculateCost(decimal price, Wall wall)
    {
        return Convert.ToDecimal(GetNeededPaintBuckets(wall)) * price;
    }
    public static decimal CalculateCost(decimal price, Room room)
    {
        return Convert.ToDecimal(GetNeededPaintBuckets(room)) * price;
    }
}