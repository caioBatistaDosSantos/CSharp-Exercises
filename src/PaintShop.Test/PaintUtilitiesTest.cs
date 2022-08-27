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
        PaintUtilities.BucketSizeLiters.Should().Be(bucketSize);
        PaintUtilities.SquareMetersPerLiter.Should().Be(sqMtPerLiter);
        PaintUtilities.SquareMetersPerBucket.Should().Be(sqMtPerBucket);

        PaintUtilities.BucketSizeLiters = newBucketSize;
        PaintUtilities.SquareMetersPerLiter = newSqMtPerLiter;

        PaintUtilities.BucketSizeLiters.Should().Be(newBucketSize);
        PaintUtilities.SquareMetersPerLiter.Should().Be(newSqMtPerLiter);
        PaintUtilities.SquareMetersPerBucket.Should().Be(newSqMtPerBucket);
    }

    [Theory]
    [MemberData(nameof(ValidOverloadData))]
    public void TestGetNeededPaintBucketsCalculation(double area, Wall wall, Room room, int expectedBuckets)
    {
        int result1 = PaintUtilities.GetNeededPaintBuckets(area);
        result1.Should().Be(expectedBuckets);
        int result2 = PaintUtilities.GetNeededPaintBuckets(wall);
        result2.Should().Be(expectedBuckets);
        int result3 = PaintUtilities.GetNeededPaintBuckets(room);
        result3.Should().Be(expectedBuckets);
    }

    [Theory]
    [MemberData(nameof(ValidOverloadData))]
    public void TestCalculateCostCalculation(double area, Wall wall, Room room, int expectedBuckets)
    {
        decimal price = 4.25M;

        decimal expectedCost = price * expectedBuckets;

        decimal result = PaintUtilities.CalculateCost(price, area);
        result.Should().Be(expectedCost);
        result = PaintUtilities.CalculateCost(price, wall);
        result.Should().Be(expectedCost);
        result = PaintUtilities.CalculateCost(price, room);
        result.Should().Be(expectedCost);
    }
}