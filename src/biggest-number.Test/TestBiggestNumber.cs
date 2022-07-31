using Xunit;
using FluentAssertions;
using System;

namespace BiggestNumber.Test;

public class TestBiggestNumber
{
    [Theory]
    [InlineData(0, 0, 0, 0)]
    public void TestIdentifyBiggestNumberSucess(int first, int second, int third, int expectedNumber)
    {
        var result = BiggestNumber.IdentifyBiggestNumber(first, second, third);
        result.Should().Be(expectedNumber);
    }
}