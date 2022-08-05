namespace PaintShop.Test;

public class PaintUtilitiesTest
{
    public static TheoryData<double, Wall, Room, int> ValidOverloadData =>
        new TheoryData<double, Wall, Room, int>
        {
            {
                1000,
                new Wall(100, 10),
                new Room(new Wall(100, 5), new Wall(100, 5)),
                5
            },
        };

    [Theory]
    [InlineData(20, 10, 200, 40, 20, 800)]
    public void TestPaintUtilitiesInitialValues(
        int bucketSize,
        int sqMtPerLiter,
        int sqMtPerBucket,
        int newBucketSize,
        int newSqMtPerLiter,
        int newSqMtPerBucket)
    {
        throw new NotImplementedException();
    }

    [Theory]
    [MemberData(nameof(ValidOverloadData))]
    public void TestGetNeededPaintBucketsCalculation(double area, Wall wall, Room room, int expectedBuckets)
    {
        throw new NotImplementedException();
    }

    [Theory]
    [MemberData(nameof(ValidOverloadData))]
    public void TestCalculateCostCalculation(double area, Wall wall, Room room, int expectedBuckets)
    {
        throw new NotImplementedException();
    }
}